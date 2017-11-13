using Oracle.ManagedDataAccess.Client;
using System;
using System.Configuration;
using System.Data;

namespace Strategy_Manager
{
    partial class EditarEstrategia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarEstrategia));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.connectionTfd = new System.Windows.Forms.TextBox();
            this.priorityTfd = new System.Windows.Forms.TextBox();
            this.strategyIdTfd = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 26F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Strategy";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(30, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Connection";
            this.label2.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(30, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Priority";
            this.label3.UseMnemonic = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(30, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Strategy Id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 261);
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
            this.button2.Location = new System.Drawing.Point(295, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // connectionTfd
            // 
            this.connectionTfd.Enabled = false;
            this.connectionTfd.Location = new System.Drawing.Point(239, 111);
            this.connectionTfd.Name = "connectionTfd";
            this.connectionTfd.Size = new System.Drawing.Size(100, 20);
            this.connectionTfd.TabIndex = 5;
            // 
            // priorityTfd
            // 
            this.priorityTfd.Enabled = false;
            this.priorityTfd.Location = new System.Drawing.Point(239, 159);
            this.priorityTfd.Name = "priorityTfd";
            this.priorityTfd.Size = new System.Drawing.Size(100, 20);
            this.priorityTfd.TabIndex = 8;
            // 
            // strategyIdTfd
            // 
            this.strategyIdTfd.Enabled = false;
            this.strategyIdTfd.Location = new System.Drawing.Point(239, 65);
            this.strategyIdTfd.Name = "strategyIdTfd";
            this.strategyIdTfd.Size = new System.Drawing.Size(100, 20);
            this.strategyIdTfd.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(239, 210);
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
            this.label11.Location = new System.Drawing.Point(30, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Active/Deactive";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(133, 261);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // EditarEstrategia
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(382, 311);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.strategyIdTfd);
            this.Controls.Add(this.connectionTfd);
            this.Controls.Add(this.priorityTfd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(398, 444);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(398, 350);
            this.Name = "EditarEstrategia";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Estrategia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox connectionTfd;
        private System.Windows.Forms.TextBox priorityTfd;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private ListaEstrategia app;

        private void agregar_Click(object sender, EventArgs e)
            
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                String generaId = "C_" + strategyIdTfd.Text + connectionTfd.Text; ;

                int checkAlive;
                if (checkBox1.Checked == true){checkAlive = 1; } else { checkAlive = 0; }
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "update_strategy";
                objCmd.CommandType = CommandType.StoredProcedure;

                objCmd.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, strategyIdTfd.Text, ParameterDirection.Input));
                objCmd.Parameters.Add(new OracleParameter("2", OracleDbType.Varchar2, connectionTfd.Text, ParameterDirection.Input));
                objCmd.Parameters.Add(new OracleParameter("3", OracleDbType.Varchar2, priorityTfd.Text, ParameterDirection.Input));
                objCmd.Parameters.Add(new OracleParameter("4", OracleDbType.Varchar2, checkAlive, ParameterDirection.Input));

                OracleCommand objCmd1 = new OracleCommand();
                objCmd1.Connection = objConn;
                objCmd1.CommandText = "update_strategyRemote";
                objCmd1.CommandType = CommandType.StoredProcedure;

                objCmd1.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, strategyIdTfd.Text, ParameterDirection.Input));
                objCmd1.Parameters.Add(new OracleParameter("2", OracleDbType.Varchar2, connectionTfd.Text, ParameterDirection.Input));
                objCmd1.Parameters.Add(new OracleParameter("3", OracleDbType.Varchar2, priorityTfd.Text, ParameterDirection.Input));
                objCmd1.Parameters.Add(new OracleParameter("4", OracleDbType.Varchar2, checkAlive, ParameterDirection.Input));

                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();
                    objCmd1.ExecuteNonQuery();
                    app.solicitaEstrategias(connectionTfd.Text);
                    this.Close();
                    System.Windows.Forms.MessageBox.Show("Strategy updated successfully");
                }
                catch (Exception ex)
                {

                    objConn.Close();
                }

                objConn.Close();
                objConn.Dispose();
            }
        }
        public void solicitaLogs(String estrategia)
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                DataSet basesRegistradas = new DataSet("Bases");
                // Create and execute the command
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "get_logCount";
                objCmd.CommandType = CommandType.StoredProcedure;
                // Set parameters
                OracleParameter retParam = objCmd.Parameters.Add("return_value", OracleDbType.Decimal, ParameterDirection.ReturnValue);
                objCmd.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, estrategia, ParameterDirection.Input));
                String logs;
                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();
                    logs= ("" + retParam.Value);
                    if (logs=="0") { btnDelete.Visible = true; } else { btnDelete.Visible = false; }
                    System.Windows.Forms.MessageBox.Show("Logs: "+ logs);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Logs: error");
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
        private void Delete_Click(object sender, EventArgs e)
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                String generaId = "C_" + strategyIdTfd.Text + connectionTfd.Text; ;

                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "delete from frequency where STRATEGY_ID =:1";
                objCmd.Parameters.Add(new OracleParameter("1", strategyIdTfd.Text));

                OracleCommand objCmd1 = new OracleCommand();
                objCmd1.Connection = objConn;
                objCmd1.CommandText = "delete from strategy_line where  STRATEGY_ID =:1";
                objCmd1.Parameters.Add(new OracleParameter("1", strategyIdTfd.Text));

                OracleCommand objCmd2 = new OracleCommand();
                objCmd2.Connection = objConn;
                objCmd2.CommandText = "delete from strategy where  STRATEGY_ID =:1";
                objCmd2.Parameters.Add(new OracleParameter("1", strategyIdTfd.Text));

                OracleCommand objCmd3 = new OracleCommand();
                objCmd3.Connection = objConn;
                objCmd3.CommandText = "delete_frequencyRemote";
                objCmd3.CommandType = CommandType.StoredProcedure;
                objCmd3.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, strategyIdTfd.Text, ParameterDirection.Input));
                objCmd3.Parameters.Add(new OracleParameter("2", OracleDbType.Varchar2, connectionTfd.Text, ParameterDirection.Input));

                OracleCommand objCmd4 = new OracleCommand();
                objCmd4.Connection = objConn;
                objCmd4.CommandText = "delete_strategyLineRemote";
                objCmd4.CommandType = CommandType.StoredProcedure;
                objCmd4.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, strategyIdTfd.Text, ParameterDirection.Input));
                objCmd4.Parameters.Add(new OracleParameter("2", OracleDbType.Varchar2, connectionTfd.Text, ParameterDirection.Input));

                OracleCommand objCmd5 = new OracleCommand();
                objCmd5.Connection = objConn;
                objCmd5.CommandText = "delete_strategyRemote";
                objCmd5.CommandType = CommandType.StoredProcedure;
                objCmd5.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, strategyIdTfd.Text, ParameterDirection.Input));
                objCmd5.Parameters.Add(new OracleParameter("2", OracleDbType.Varchar2, connectionTfd.Text, ParameterDirection.Input));

                try
                {
                    objConn.Open();
                    //objCmd.ExecuteNonQuery();
                    //objCmd1.ExecuteNonQuery();
                    //objCmd2.ExecuteNonQuery();
                    objCmd3.ExecuteNonQuery();
                    objCmd4.ExecuteNonQuery();
                    objCmd5.ExecuteNonQuery();
                    app.solicitaEstrategias(connectionTfd.Text);
                    this.Close();
                    System.Windows.Forms.MessageBox.Show("Strategy deleted successfully");
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error");
                    objConn.Close();
                }

                objConn.Close();
                objConn.Dispose();
            }
            app.editNuevaEstrategia(strategyIdTfd.Text);
            System.Windows.Forms.MessageBox.Show("Strategy:" +strategyIdTfd.Text);
        }

        private System.Windows.Forms.TextBox strategyIdTfd;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDelete;
    }
}