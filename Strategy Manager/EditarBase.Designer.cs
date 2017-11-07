using Oracle.ManagedDataAccess.Client;
using System;
using System.Configuration;
using System.Data;

namespace Oracle_Tablespace_Monitor
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
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(30, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre de la Base de Datos";
            this.label2.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(30, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "IP del Servidor";
            this.label3.UseMnemonic = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(30, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Puerto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 376);
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
            this.button2.Location = new System.Drawing.Point(296, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // baseDatos
            // 
            this.baseDatos.Location = new System.Drawing.Point(249, 209);
            this.baseDatos.Name = "baseDatos";
            this.baseDatos.Size = new System.Drawing.Size(100, 20);
            this.baseDatos.TabIndex = 5;
            // 
            // ip_base
            // 
            this.ip_base.Location = new System.Drawing.Point(249, 242);
            this.ip_base.Name = "ip_base";
            this.ip_base.Size = new System.Drawing.Size(100, 20);
            this.ip_base.TabIndex = 8;
            // 
            // puerto
            // 
            this.puerto.Location = new System.Drawing.Point(249, 268);
            this.puerto.Name = "puerto";
            this.puerto.Size = new System.Drawing.Size(100, 20);
            this.puerto.TabIndex = 9;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(111, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(149, 147);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // nombreServidor
            // 
            this.nombreServidor.Location = new System.Drawing.Point(249, 181);
            this.nombreServidor.Name = "nombreServidor";
            this.nombreServidor.Size = new System.Drawing.Size(100, 20);
            this.nombreServidor.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(249, 310);
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
            this.label11.Location = new System.Drawing.Point(30, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Activar/Desactivar";
            // 
            // EditarBase
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.ControlBox = false;
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 450);
            this.Name = "EditarBase";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar una Base de Datos";
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
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandType = CommandType.Text;
                objCmd.CommandText = "drop database link C_" + nombreServidor.Text + baseDatos.Text;
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

                
                OracleCommand objCmd2 = new OracleCommand();
                objCmd2.Connection = objConn;
                objCmd2.CommandType = CommandType.StoredProcedure;
                objCmd2.CommandText = "update_connection";
                objCmd2.Parameters.Add(new OracleParameter("1", ip_base.Text));
                objCmd2.Parameters.Add(new OracleParameter("2", puerto.Text));
         
                int check = ' ';
                if (checkBox1.Checked) { check = 1; } else { check = 0; };
                objCmd2.Parameters.Add(new OracleParameter("3", check));
                String generaId = "C_" + nombreServidor.Text + baseDatos.Text;
                objCmd2.Parameters.Add(new OracleParameter("4",generaId));
            

                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();
                    objCmd2.ExecuteNonQuery();
                    objCmd3.ExecuteNonQuery();

                    app.solicitaBases();
                    this.Close();
                    System.Windows.Forms.MessageBox.Show("Base de datos Modificada correctamente");

                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("No se pudo modificar la base de datos");
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
            this.puerto.Text = puerto;

            bD = based;
            s = servidor;
            if (alive == "1") { checkBox1.Checked = true; } else { checkBox1.Checked = false; }
        }

        private System.Windows.Forms.TextBox nombreServidor;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label11;
        String bD;
        String s;
    }
}