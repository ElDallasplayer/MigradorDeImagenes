namespace WinFormsApp1
{
    partial class MIGRADOR
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HOST_SQL = new System.Windows.Forms.TextBox();
            this.PORT_SQL = new System.Windows.Forms.TextBox();
            this.DB_SQL = new System.Windows.Forms.TextBox();
            this.USER_SQL = new System.Windows.Forms.TextBox();
            this.PASSWORD_SQL = new System.Windows.Forms.TextBox();
            this.PASSWORD_POSTGRES = new System.Windows.Forms.TextBox();
            this.USER_POSTGRES = new System.Windows.Forms.TextBox();
            this.DB_POSTGRES = new System.Windows.Forms.TextBox();
            this.PORT_POSTGRES = new System.Windows.Forms.TextBox();
            this.HOST_POSTGRES = new System.Windows.Forms.TextBox();
            this.START_BUTTON = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Logs = new System.Windows.Forms.TextBox();
            this.NUMBER_MIGRAR = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.STOP_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HOST_SQL
            // 
            this.HOST_SQL.Location = new System.Drawing.Point(12, 67);
            this.HOST_SQL.Name = "HOST_SQL";
            this.HOST_SQL.Size = new System.Drawing.Size(363, 27);
            this.HOST_SQL.TabIndex = 0;
            this.HOST_SQL.Text = "INTANCIA";
            // 
            // PORT_SQL
            // 
            this.PORT_SQL.Location = new System.Drawing.Point(12, 133);
            this.PORT_SQL.Name = "PORT_SQL";
            this.PORT_SQL.Size = new System.Drawing.Size(363, 27);
            this.PORT_SQL.TabIndex = 1;
            this.PORT_SQL.Text = "0000";
            // 
            // DB_SQL
            // 
            this.DB_SQL.Location = new System.Drawing.Point(12, 199);
            this.DB_SQL.Name = "DB_SQL";
            this.DB_SQL.Size = new System.Drawing.Size(363, 27);
            this.DB_SQL.TabIndex = 2;
            this.DB_SQL.Text = "1_ServicioHikvision";
            // 
            // USER_SQL
            // 
            this.USER_SQL.Location = new System.Drawing.Point(12, 270);
            this.USER_SQL.Name = "USER_SQL";
            this.USER_SQL.Size = new System.Drawing.Size(363, 27);
            this.USER_SQL.TabIndex = 3;
            this.USER_SQL.Text = "User";
            // 
            // PASSWORD_SQL
            // 
            this.PASSWORD_SQL.Location = new System.Drawing.Point(12, 339);
            this.PASSWORD_SQL.Name = "PASSWORD_SQL";
            this.PASSWORD_SQL.Size = new System.Drawing.Size(363, 27);
            this.PASSWORD_SQL.TabIndex = 4;
            this.PASSWORD_SQL.Text = "Password";
            // 
            // PASSWORD_POSTGRES
            // 
            this.PASSWORD_POSTGRES.Location = new System.Drawing.Point(423, 339);
            this.PASSWORD_POSTGRES.Name = "PASSWORD_POSTGRES";
            this.PASSWORD_POSTGRES.Size = new System.Drawing.Size(363, 27);
            this.PASSWORD_POSTGRES.TabIndex = 9;
            this.PASSWORD_POSTGRES.Text = "Us3r_t4ct1c0$";
            // 
            // USER_POSTGRES
            // 
            this.USER_POSTGRES.Location = new System.Drawing.Point(423, 270);
            this.USER_POSTGRES.Name = "USER_POSTGRES";
            this.USER_POSTGRES.Size = new System.Drawing.Size(363, 27);
            this.USER_POSTGRES.TabIndex = 8;
            this.USER_POSTGRES.Text = "tactico_user";
            // 
            // DB_POSTGRES
            // 
            this.DB_POSTGRES.Location = new System.Drawing.Point(423, 199);
            this.DB_POSTGRES.Name = "DB_POSTGRES";
            this.DB_POSTGRES.Size = new System.Drawing.Size(363, 27);
            this.DB_POSTGRES.TabIndex = 7;
            this.DB_POSTGRES.Text = "tactico_desa";
            // 
            // PORT_POSTGRES
            // 
            this.PORT_POSTGRES.Location = new System.Drawing.Point(423, 133);
            this.PORT_POSTGRES.Name = "PORT_POSTGRES";
            this.PORT_POSTGRES.Size = new System.Drawing.Size(363, 27);
            this.PORT_POSTGRES.TabIndex = 6;
            this.PORT_POSTGRES.Text = "5432";
            // 
            // HOST_POSTGRES
            // 
            this.HOST_POSTGRES.Location = new System.Drawing.Point(423, 67);
            this.HOST_POSTGRES.Name = "HOST_POSTGRES";
            this.HOST_POSTGRES.Size = new System.Drawing.Size(363, 27);
            this.HOST_POSTGRES.TabIndex = 5;
            this.HOST_POSTGRES.Text = "127.0.0.1";
            // 
            // START_BUTTON
            // 
            this.START_BUTTON.Location = new System.Drawing.Point(12, 458);
            this.START_BUTTON.Name = "START_BUTTON";
            this.START_BUTTON.Size = new System.Drawing.Size(227, 33);
            this.START_BUTTON.TabIndex = 10;
            this.START_BUTTON.Text = "INICIAR";
            this.START_BUTTON.UseVisualStyleBackColor = true;
            this.START_BUTTON.Click += new System.EventHandler(this.START_BUTTON_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "HOST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "DATABASE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "USER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "PASSWORD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "PASSWORD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "USER";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "DATABASE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(423, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "PORT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(423, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "HOST";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(143, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "SQL SERVER";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(561, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "POSTGRESSQL";
            // 
            // Logs
            // 
            this.Logs.HideSelection = false;
            this.Logs.Location = new System.Drawing.Point(250, 393);
            this.Logs.Multiline = true;
            this.Logs.Name = "Logs";
            this.Logs.ReadOnly = true;
            this.Logs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Logs.Size = new System.Drawing.Size(536, 137);
            this.Logs.TabIndex = 23;
            this.Logs.Text = "LOGS:";
            // 
            // NUMBER_MIGRAR
            // 
            this.NUMBER_MIGRAR.Location = new System.Drawing.Point(12, 416);
            this.NUMBER_MIGRAR.Name = "NUMBER_MIGRAR";
            this.NUMBER_MIGRAR.Size = new System.Drawing.Size(227, 27);
            this.NUMBER_MIGRAR.TabIndex = 24;
            this.NUMBER_MIGRAR.Text = "5000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 393);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(200, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "CANTIDAD POR MIGRACION";
            // 
            // STOP_BUTTON
            // 
            this.STOP_BUTTON.Location = new System.Drawing.Point(12, 497);
            this.STOP_BUTTON.Name = "STOP_BUTTON";
            this.STOP_BUTTON.Size = new System.Drawing.Size(227, 33);
            this.STOP_BUTTON.TabIndex = 26;
            this.STOP_BUTTON.Text = "DETENER";
            this.STOP_BUTTON.UseVisualStyleBackColor = true;
            this.STOP_BUTTON.Click += new System.EventHandler(this.STOP_BUTTON_Click);
            // 
            // MIGRADOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 542);
            this.Controls.Add(this.STOP_BUTTON);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.NUMBER_MIGRAR);
            this.Controls.Add(this.Logs);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.START_BUTTON);
            this.Controls.Add(this.PASSWORD_POSTGRES);
            this.Controls.Add(this.USER_POSTGRES);
            this.Controls.Add(this.DB_POSTGRES);
            this.Controls.Add(this.PORT_POSTGRES);
            this.Controls.Add(this.HOST_POSTGRES);
            this.Controls.Add(this.PASSWORD_SQL);
            this.Controls.Add(this.USER_SQL);
            this.Controls.Add(this.DB_SQL);
            this.Controls.Add(this.PORT_SQL);
            this.Controls.Add(this.HOST_SQL);
            this.Name = "MIGRADOR";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox HOST_SQL;
        private TextBox PORT_SQL;
        private TextBox DB_SQL;
        private TextBox USER_SQL;
        private TextBox PASSWORD_SQL;
        private TextBox PASSWORD_POSTGRES;
        private TextBox USER_POSTGRES;
        private TextBox DB_POSTGRES;
        private TextBox PORT_POSTGRES;
        private TextBox HOST_POSTGRES;
        private Button START_BUTTON;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox Logs;
        private TextBox NUMBER_MIGRAR;
        private Label label13;
        private Button STOP_BUTTON;
    }
}