using Oracle.ManagedDataAccess.Client;
using System;
using System.Configuration;
using System.Data;

namespace Strategy_Manager
{
    partial class EditarBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarBase));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.baseDatos = new System.Windows.Forms.TextBox();
            this.ip_base = new System.Windows.Forms.TextBox();
            this.puerto = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.nombreServidor = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(30, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(30, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Database name";
            this.label2.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(30, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "IP Address";
            this.label3.UseMnemonic = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(30, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Port";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.agregar_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(295, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // baseDatos
            // 
            this.baseDatos.Location = new System.Drawing.Point(239, 209);
            this.baseDatos.Name = "baseDatos";
            this.baseDatos.Size = new System.Drawing.Size(100, 20);
            this.baseDatos.TabIndex = 5;
            // 
            // ip_base
            // 
            this.ip_base.Location = new System.Drawing.Point(239, 238);
            this.ip_base.Name = "ip_base";
            this.ip_base.Size = new System.Drawing.Size(100, 20);
            this.ip_base.TabIndex = 8;
            // 
            // puerto
            // 
            this.puerto.Location = new System.Drawing.Point(239, 270);
            this.puerto.Name = "puerto";
            this.puerto.Size = new System.Drawing.Size(100, 20);
            this.puerto.TabIndex = 9;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(126, 34);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(150, 150);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // nombreServidor
            // 
            this.nombreServidor.Location = new System.Drawing.Point(239, 181);
            this.nombreServidor.Name = "nombreServidor";
            this.nombreServidor.Size = new System.Drawing.Size(100, 20);
            this.nombreServidor.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(239, 296);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(30, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Active/Deactive";
            // 
            // EditarBase
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(382, 405);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nombreServidor);
            this.Controls.Add(this.baseDatos);
            this.Controls.Add(this.ip_base);
            this.Controls.Add(this.puerto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(398, 444);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(398, 444);
            this.Name = "EditarBase";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Database";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox baseDatos;
        private System.Windows.Forms.TextBox ip_base;
        private System.Windows.Forms.TextBox puerto;
        private System.Windows.Forms.PictureBox pictureBox;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private Application app;

        private void agregar_Click(object sender, EventArgs e)
            
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                String generaId = "C_" + nombreServidor.Text + baseDatos.Text; ;

                OracleCommand objCmd2 = new OracleCommand();
                objCmd2.Connection = objConn;
                
                objCmd2.CommandText = "delete from connection where conn_id =:1";
                objCmd2.Parameters.Add(new OracleParameter("1", generaId));


                OracleCommand objCmd4 = new OracleCommand();
                objCmd4.Connection = objConn;
                objCmd4.CommandText = "delete from connection@"+generaId +" where conn_id=:1";
                objCmd4.Parameters.Add(new OracleParameter("1", generaId));
                 

                

                try
                {
                    objConn.Open();
                    objCmd4.ExecuteNonQuery();
                    //lose()
                    
                    objCmd2.ExecuteNonQuery();
                    //objConn.Close();

                    // objConn.Open();

                    dropCreateDL();

                    //objCmd3.ExecuteNonQuery();
                    //objCmd6.ExecuteNonQuery();
                    //objCmd7.ExecuteNonQuery();

                    
                    app.solicitaBases();
                    this.Close();
                    System.Windows.Forms.MessageBox.Show("Database connection updated successfully");
                   

                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error");
                    dropCreateDLOld();
                   
                    OracleCommand objCmd11 = new OracleCommand();
                    objCmd11.Connection = objConn;
                    objCmd11.CommandText = "insert_connection";
                    objCmd11.CommandType = CommandType.StoredProcedure;
                    objCmd11.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, generaId, ParameterDirection.Input));
                    objCmd11.Parameters.Add(new OracleParameter("2", OracleDbType.Varchar2, nombreServidor.Text, ParameterDirection.Input));
                    objCmd11.Parameters.Add(new OracleParameter("3", OracleDbType.Varchar2, baseDatos.Text, ParameterDirection.Input));
                    objCmd11.Parameters.Add(new OracleParameter("4", OracleDbType.Varchar2, ip_anterior, ParameterDirection.Input));
                    objCmd11.Parameters.Add(new OracleParameter("5", OracleDbType.Varchar2, puerto_anterior, ParameterDirection.Input));
                    objCmd11.Parameters.Add(new OracleParameter("6", OracleDbType.Decimal, check, ParameterDirection.Input));
                   
                    objCmd11.ExecuteNonQuery();

                    OracleCommand objCmd12 = new OracleCommand();
                    objCmd12.Connection = objConn;
                    objCmd12.CommandText = "insert into connection@" + generaId + " values(:1,:2,:3,:4,:5,:6)";
                    objCmd12.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, generaId, ParameterDirection.Input));
                    objCmd12.Parameters.Add(new OracleParameter("2", OracleDbType.Varchar2, nombreServidor.Text, ParameterDirection.Input));
                    objCmd12.Parameters.Add(new OracleParameter("3", OracleDbType.Varchar2, baseDatos.Text, ParameterDirection.Input));
                    objCmd12.Parameters.Add(new OracleParameter("4", OracleDbType.Varchar2, ip_anterior, ParameterDirection.Input));
                    objCmd12.Parameters.Add(new OracleParameter("5", OracleDbType.Varchar2, puerto_anterior, ParameterDirection.Input));
                    objCmd12.Parameters.Add(new OracleParameter("6", OracleDbType.Decimal, check, ParameterDirection.Input));
                    
                    objCmd12.ExecuteNonQuery();
                    objConn.Close();
                }

                objConn.Close();
                objConn.Dispose();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
        }
        public void llenaFormulario(String based,String servidor,String ip,String puerto,String alive)
        {
            nombreServidor.Enabled = false;
            baseDatos.Enabled = false;
            baseDatos.Text = based;
            nombreServidor.Text = servidor;
            ip_base.Text = ip;
            ip_anterior = ip;
            check = alive;
            puerto_anterior = puerto;
            this.puerto.Text = puerto;

            bD = based;
            s = servidor;
            if (alive == "1") { checkBox1.Checked = true; } else { checkBox1.Checked = false; }
        }
        public void dropCreateDL()
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                String generaId = "C_" + nombreServidor.Text + baseDatos.Text;
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "drop database link " + generaId;
               // objCmd.Parameters.Add(new OracleParameter("1", generaId));


                OracleCommand objCmd3 = new OracleCommand();
                objCmd3.Connection = objConn;
                objCmd3.CommandText = "create database link " + "C_" + nombreServidor.Text + baseDatos.Text + "\n" +
                                       "connect to SYSTEM identified by MANAGER \n" +
                                        "using \n" +
                                       "'(DESCRIPTION = \n" +
                                        "(ADDRESS = (PROTOCOL = TCP)(HOST = " + ip_base.Text + ")(PORT =" + puerto.Text + ")) \n" +
                                        "(CONNECT_DATA = \n" +
                                        "(SERVER = DEDICATED) \n" +
                                        "(SERVICE_NAME = XE) \n " +
                                        ") \n" +
                                        ")' \n ";

                String number;
                if (checkBox1.Checked) { number = "1"; } else { number = "0"; }
                OracleCommand objCmd7 = new OracleCommand();
                objCmd7.Connection = objConn;
                objCmd7.CommandText = "insert_connection";
                objCmd7.CommandType = CommandType.StoredProcedure;
                objCmd7.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, generaId, ParameterDirection.Input));
                objCmd7.Parameters.Add(new OracleParameter("2", OracleDbType.Varchar2, nombreServidor.Text, ParameterDirection.Input));
                objCmd7.Parameters.Add(new OracleParameter("3", OracleDbType.Varchar2, baseDatos.Text, ParameterDirection.Input));
                objCmd7.Parameters.Add(new OracleParameter("4", OracleDbType.Varchar2, ip_base.Text, ParameterDirection.Input));
                objCmd7.Parameters.Add(new OracleParameter("5", OracleDbType.Varchar2, puerto.Text, ParameterDirection.Input));
                objCmd7.Parameters.Add(new OracleParameter("6", OracleDbType.Decimal, number, ParameterDirection.Input));

                OracleCommand objCmd6 = new OracleCommand();
                objCmd6.Connection = objConn;
                objCmd6.CommandText = "insert into connection@" + generaId + " values(:1,:2,:3,:4,:5,:6)";
                objCmd6.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, generaId, ParameterDirection.Input));
                objCmd6.Parameters.Add(new OracleParameter("2", OracleDbType.Varchar2, nombreServidor.Text, ParameterDirection.Input));
                objCmd6.Parameters.Add(new OracleParameter("3", OracleDbType.Varchar2, baseDatos.Text, ParameterDirection.Input));
                objCmd6.Parameters.Add(new OracleParameter("4", OracleDbType.Varchar2, ip_base.Text, ParameterDirection.Input));
                objCmd6.Parameters.Add(new OracleParameter("5", OracleDbType.Varchar2, puerto.Text, ParameterDirection.Input));
                objCmd6.Parameters.Add(new OracleParameter("6", OracleDbType.Decimal, number, ParameterDirection.Input));

                try {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();
                    objCmd3.ExecuteNonQuery();
                    objCmd6.ExecuteNonQuery();
                    objCmd7.ExecuteNonQuery();
    
                }
                catch (Exception ex)
           
                {
                    objConn.Close();
                    objConn.Dispose();
                    throw new Exception();
                }
                objConn.Close();
                objConn.Dispose();
            }
            
        }
        public void dropCreateDLOld()
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                String generaId = "C_" + nombreServidor.Text + baseDatos.Text;
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "drop database link " + generaId;
                objCmd.Parameters.Add(new OracleParameter("1", generaId));


                OracleCommand objCmd3 = new OracleCommand();
                objCmd3.Connection = objConn;
                objCmd3.CommandText = "create database link " + "C_" + nombreServidor.Text + baseDatos.Text + "\n" +
                                       "connect to SYSTEM identified by MANAGER \n" +
                                        "using \n" +
                                       "'(DESCRIPTION = \n" +
                                        "(ADDRESS = (PROTOCOL = TCP)(HOST = " + ip_anterior + ")(PORT =" + puerto_anterior + ")) \n" +
                                        "(CONNECT_DATA = \n" +
                                        "(SERVER = DEDICATED) \n" +
                                        "(SERVICE_NAME = XE) \n " +
                                        ") \n" +
                                        ")' \n ";

                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();
                    objCmd3.ExecuteNonQuery();

                }
                catch (Exception ex)
                {

                }
                objConn.Close();
                objConn.Dispose();
            }
        }

        private System.Windows.Forms.TextBox nombreServidor;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label11;
        private String ip_anterior;
        private String puerto_anterior;
        private String check;
        String bD;
        String s;
    }
}