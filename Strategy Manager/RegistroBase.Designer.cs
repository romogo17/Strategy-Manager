﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Configuration;
using System.Data;

namespace Oracle_Tablespace_Monitor
{
    partial class RegistroBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroBase));
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.IP_Servidor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nombreServidor = new System.Windows.Forms.TextBox();
            this.baseDatos = new System.Windows.Forms.TextBox();
            this.ip_base = new System.Windows.Forms.TextBox();
            this.puerto_base = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.Control;
            this.Label1.Location = new System.Drawing.Point(30, 181);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(67, 20);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Servidor";
            this.Label1.UseMnemonic = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.Control;
            this.Label2.Location = new System.Drawing.Point(30, 207);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(213, 20);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Nombre de la Base de Datos";
            this.Label2.UseMnemonic = false;
            // 
            // IP_Servidor
            // 
            this.IP_Servidor.AutoSize = true;
            this.IP_Servidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP_Servidor.ForeColor = System.Drawing.SystemColors.Control;
            this.IP_Servidor.Location = new System.Drawing.Point(30, 240);
            this.IP_Servidor.Name = "IP_Servidor";
            this.IP_Servidor.Size = new System.Drawing.Size(111, 20);
            this.IP_Servidor.TabIndex = 0;
            this.IP_Servidor.Text = "IP del Servidor";
            this.IP_Servidor.UseMnemonic = false;
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
            // nombreServidor
            // 
            this.nombreServidor.Location = new System.Drawing.Point(249, 181);
            this.nombreServidor.Name = "nombreServidor";
            this.nombreServidor.Size = new System.Drawing.Size(100, 20);
            this.nombreServidor.TabIndex = 4;
            // 
            // baseDatos
            // 
            this.baseDatos.Location = new System.Drawing.Point(249, 207);
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
            // puerto_base
            // 
            this.puerto_base.Location = new System.Drawing.Point(249, 268);
            this.puerto_base.Name = "puerto_base";
            this.puerto_base.Size = new System.Drawing.Size(100, 20);
            this.puerto_base.TabIndex = 9;
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
            // RegistroBase
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.IP_Servidor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nombreServidor);
            this.Controls.Add(this.baseDatos);
            this.Controls.Add(this.ip_base);
            this.Controls.Add(this.puerto_base);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 450);
            this.Name = "RegistroBase";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro de una Base de Datos";
            
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label IP_Servidor;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox nombreServidor;
        private System.Windows.Forms.TextBox baseDatos;
        private System.Windows.Forms.TextBox ip_base;
        private System.Windows.Forms.TextBox puerto_base;
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
                objCmd.CommandText = "create database link Datalink_" + nombreServidor.Text + baseDatos.Text +
                                     " connect to system identified by manager " +
                                      "using" +
                                      "'(DESCRIPTION=" +
                                      "(ADDRESS =" +
                                      "(PROTOCOL = TCP)" +
                                      "(HOST =" + ip_base.Text + ")" +
                                      "(PORT =" + puerto_base.Text + "))" +
                                      "(CONNECT_DATA =" +
                                      "(SERVER = DEDICATED)" +
                                      "(SERVICE_NAME = XE)))'";

                objCmd.CommandType = CommandType.Text;
                OracleCommand objCmd2 = new OracleCommand();
                objCmd2.Connection = objConn;
                objCmd2.CommandText = "Insert into CONEXIONES VALUES (:1,:2,:3,:4,:5)";

                objCmd2.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, baseDatos.Text, ParameterDirection.Input));
                objCmd2.Parameters.Add(new OracleParameter("2", OracleDbType.Varchar2, nombreServidor.Text, ParameterDirection.Input));
                objCmd2.Parameters.Add(new OracleParameter("3", OracleDbType.Varchar2, ip_base.Text, ParameterDirection.Input));
                objCmd2.Parameters.Add(new OracleParameter("4", OracleDbType.Varchar2, puerto_base.Text, ParameterDirection.Input));
                objCmd2.Parameters.Add(new OracleParameter("5", OracleDbType.Char, '1', ParameterDirection.Input));
                try
                {
                    objConn.Open();
                    objCmd2.ExecuteNonQuery();
                    objCmd.ExecuteNonQuery();
                    app.solicitaBases();
                    this.Close();
                    System.Windows.Forms.MessageBox.Show("Base de datos Registrada correctamente");

                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Esa base de Datos ya esta registrada");
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
    }
}