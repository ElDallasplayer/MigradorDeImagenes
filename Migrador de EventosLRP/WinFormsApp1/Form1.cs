using WinFormsApp1.Clases;
using System.Data.SqlClient;
using Npgsql;

namespace WinFormsApp1
{
    public partial class MIGRADOR : Form
    {
        public bool DetenerProceso = false;

        public MIGRADOR()
        {
            InitializeComponent();
        }

        public async void START_BUTTON_Click(object sender, EventArgs e)
        {
            DetenerProceso = false;
            var task = Task.Run(() => StartProcess());
            START_BUTTON.Enabled = false;
        }

        private void STOP_BUTTON_Click(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(() =>
            {
                DetenerProceso = true;
                START_BUTTON.Enabled = true;
            }));
        }

        public async void StartProcess()
        {
            try
            {
                AgregarLOG("INICIANDO PROCESO");
                
                Conexion_SqlServer connSql = new Conexion_SqlServer(HOST_SQL.Text, PORT_SQL.Text, DB_SQL.Text, USER_SQL.Text, PASSWORD_SQL.Text);

                Conexion_Postgres connPost = new Conexion_Postgres(HOST_POSTGRES.Text, PORT_POSTGRES.Text, DB_POSTGRES.Text, USER_POSTGRES.Text, PASSWORD_POSTGRES.Text);
                
                
                int startValueToMigrate = ObtenerUltimaIdSQL(connSql);
                AgregarLOG("ULTIMO ID: " + startValueToMigrate);

                while(DetenerProceso == false)
                {
                    try
                    {
                        int valueToMigrate = Convert.ToInt32(NUMBER_MIGRAR.Text);

                        if (startValueToMigrate != -1)
                        {
                            string sqlCommand = "select top " + valueToMigrate + " CONCAT('update " + DB_POSTGRES.Text + ".lpr.capturas set path_vehiculo =',CHAR(39),event_PictureVehicle,CHAR(39),', path_patente=',CHAR(39),event_PicturePlate,CHAR(39),' where captura_id= ',event_id, ';' ) as queries from t_events where event_id < " + startValueToMigrate + " order by event_id desc";
                            List<string> commandLines = new List<string>();

                            connSql.Connection.Open();
                            SqlCommand command = new SqlCommand(sqlCommand, connSql.Connection);
                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    if (DetenerProceso == false)
                                    {
                                        try
                                        {
                                            startValueToMigrate -= 1;

                                            connPost.Connection.Open();
                                            NpgsqlCommand commandPost = new NpgsqlCommand(reader["queries"].ToString(), connPost.Connection);
                                            commandPost.ExecuteNonQuery();
                                            connPost.Connection.Close();
                                            AgregarLOG("EJECUCION: " + reader["queries"].ToString());

                                            AgregarLOG("Valor de iteracion: " + startValueToMigrate);
                                        }
                                        catch (Exception ex)
                                        {
                                            connSql.Connection.Close();
                                            
                                            AgregarLOG("ERROR - " + ex.Message);
                                        }
                                    }
                                    else
                                    {
                                        Invoke(new MethodInvoker(() =>
                                        {
                                            DetenerProceso = true;
                                            START_BUTTON.Enabled = true;
                                        }));
                                        throw new Exception("SE DETUVO EL PROCESO");
                                    }
                                }
                                connSql.Connection.Close();

                                //foreach (string querie in commandLines)
                                //{
                                //    connPost.Connection.Open();
                                //    NpgsqlCommand commandPost = new NpgsqlCommand(querie, connPost.Connection);
                                //    commandPost.ExecuteNonQuery();
                                //    connPost.Connection.Close();
                                //    AgregarLOG("EJECUCION: " + querie);
                                //}
                            }
                            else
                            {
                                AgregarLOG("Migracion finalizada por no tener mas IDs");
                                break;
                            }
                        }
                        else
                        {
                            AgregarLOG("ERROR AL OBTENER ID");
                            break;
                        }
                    }
                    catch (Exception ex) { AgregarLOG(ex.Message); break; }
                }
            }
            catch (Exception ex) { AgregarLOG("ERROR - Durante peticiones SQL"); AgregarLOG("ERROR - " + ex.Message); }
        }

        public int ObtenerUltimaIdSQL(Conexion_SqlServer conexion)
        {
            try
            {
                int lastId = 0;
                string sql = "select top 1 event_id from t_events order by event_id desc";
                conexion.Connection.Open();

                SqlCommand sqlCommand = new SqlCommand(sql, conexion.Connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    lastId = reader.GetInt32(0);
                }
                conexion.Connection.Close();
                return lastId;
            }catch (Exception ex)
            {
                AgregarLOG("ERROR - " + ex.Message);
                return -1;
            }
        }

        public async void AgregarLOG(string Text)
        {
            Invoke(new MethodInvoker(() =>
            {
                Logs.Text = Text + "\r\n" + Logs.Text;
            }));
        }
    }
}