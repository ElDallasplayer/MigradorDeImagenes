using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Clases
{
    public class Conexion_SqlServer
    {
        public string StringConnection { get; set; }

        public SqlConnection Connection { get; set; }

        public Conexion_SqlServer() { }

        public Conexion_SqlServer(string Host,string Port,string DataBase, string User, string Password) 
        {
            StringConnection = ("server= " + Host + " ; database= " + DataBase + " ; integrated security= false ; user=" + User + "; password=" + Password);
            Connection = new SqlConnection(StringConnection);
        }
    }

    public class Conexion_Postgres
    {
        public string StringConnection { get; set; }

        public NpgsqlConnection Connection { get; set; }

        public Conexion_Postgres() { }

        public Conexion_Postgres(string Host, string Port, string DataBase, string User, string Password) 
        {
            StringConnection = ("Server=" + Host + ";Port=" + Port + ";Database=" + DataBase + ";User Id=" + User + ";Password=" + Password + ";Integrated Security=false;");
            Connection = new NpgsqlConnection(StringConnection);
        }
    }
}
