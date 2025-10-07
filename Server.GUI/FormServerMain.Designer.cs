namespace Server.GUI
{
    partial class FormServerMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.tbxLog = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.tbxIPAddress = new System.Windows.Forms.TextBox();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblReceived = new System.Windows.Forms.Label();
            this.tbxReceived = new System.Windows.Forms.TextBox();
            this.tbxFiltered = new System.Windows.Forms.TextBox();
            this.lblFiltered = new System.Windows.Forms.Label();
            this.tbxCountReceived = new System.Windows.Forms.TextBox();
            this.lblCountReceived = new System.Windows.Forms.Label();
            this.lblCountFiltered = new System.Windows.Forms.Label();
            this.tbxCountFiltered = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(28, 136);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(318, 47);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbxLog
            // 
            this.tbxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLog.Location = new System.Drawing.Point(875, 57);
            this.tbxLog.Multiline = true;
            this.tbxLog.Name = "tbxLog";
            this.tbxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxLog.Size = new System.Drawing.Size(455, 268);
            this.tbxLog.TabIndex = 1;
            this.tbxLog.TextChanged += new System.EventHandler(this.tbxLog_TextChanged);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(403, 136);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(318, 47);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tbxIPAddress
            // 
            this.tbxIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIPAddress.Location = new System.Drawing.Point(140, 60);
            this.tbxIPAddress.Name = "tbxIPAddress";
            this.tbxIPAddress.Size = new System.Drawing.Size(206, 29);
            this.tbxIPAddress.TabIndex = 3;
            // 
            // tbxPort
            // 
            this.tbxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPort.Location = new System.Drawing.Point(591, 65);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(130, 29);
            this.tbxPort.TabIndex = 4;
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPAddress.Location = new System.Drawing.Point(24, 60);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(106, 24);
            this.lblIPAddress.TabIndex = 5;
            this.lblIPAddress.Text = "IP Address:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(502, 65);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(48, 24);
            this.lblPort.TabIndex = 6;
            this.lblPort.Text = "Port:";
            // 
            // lblReceived
            // 
            this.lblReceived.AutoSize = true;
            this.lblReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceived.Location = new System.Drawing.Point(24, 397);
            this.lblReceived.Name = "lblReceived";
            this.lblReceived.Size = new System.Drawing.Size(95, 24);
            this.lblReceived.TabIndex = 7;
            this.lblReceived.Text = "Received:";
            // 
            // tbxReceived
            // 
            this.tbxReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxReceived.Location = new System.Drawing.Point(140, 397);
            this.tbxReceived.Name = "tbxReceived";
            this.tbxReceived.Size = new System.Drawing.Size(206, 29);
            this.tbxReceived.TabIndex = 8;
            // 
            // tbxFiltered
            // 
            this.tbxFiltered.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFiltered.Location = new System.Drawing.Point(140, 470);
            this.tbxFiltered.Name = "tbxFiltered";
            this.tbxFiltered.Size = new System.Drawing.Size(206, 29);
            this.tbxFiltered.TabIndex = 9;
            // 
            // lblFiltered
            // 
            this.lblFiltered.AutoSize = true;
            this.lblFiltered.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltered.Location = new System.Drawing.Point(24, 475);
            this.lblFiltered.Name = "lblFiltered";
            this.lblFiltered.Size = new System.Drawing.Size(78, 24);
            this.lblFiltered.TabIndex = 10;
            this.lblFiltered.Text = "Filtered:";
            // 
            // tbxCountReceived
            // 
            this.tbxCountReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCountReceived.Location = new System.Drawing.Point(528, 394);
            this.tbxCountReceived.Name = "tbxCountReceived";
            this.tbxCountReceived.Size = new System.Drawing.Size(206, 29);
            this.tbxCountReceived.TabIndex = 11;
            // 
            // lblCountReceived
            // 
            this.lblCountReceived.AutoSize = true;
            this.lblCountReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountReceived.Location = new System.Drawing.Point(399, 402);
            this.lblCountReceived.Name = "lblCountReceived";
            this.lblCountReceived.Size = new System.Drawing.Size(65, 24);
            this.lblCountReceived.TabIndex = 12;
            this.lblCountReceived.Text = "Count:";
            // 
            // lblCountFiltered
            // 
            this.lblCountFiltered.AutoSize = true;
            this.lblCountFiltered.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountFiltered.Location = new System.Drawing.Point(399, 475);
            this.lblCountFiltered.Name = "lblCountFiltered";
            this.lblCountFiltered.Size = new System.Drawing.Size(65, 24);
            this.lblCountFiltered.TabIndex = 13;
            this.lblCountFiltered.Text = "Count:";
            // 
            // tbxCountFiltered
            // 
            this.tbxCountFiltered.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCountFiltered.Location = new System.Drawing.Point(528, 475);
            this.tbxCountFiltered.Name = "tbxCountFiltered";
            this.tbxCountFiltered.Size = new System.Drawing.Size(206, 29);
            this.tbxCountFiltered.TabIndex = 14;
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(875, 343);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(218, 33);
            this.btnImport.TabIndex = 15;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(1116, 343);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(214, 33);
            this.btnExport.TabIndex = 16;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(875, 393);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(455, 33);
            this.btnClean.TabIndex = 17;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(875, 461);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(455, 48);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormServerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 689);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.tbxCountFiltered);
            this.Controls.Add(this.lblCountFiltered);
            this.Controls.Add(this.lblCountReceived);
            this.Controls.Add(this.tbxCountReceived);
            this.Controls.Add(this.lblFiltered);
            this.Controls.Add(this.tbxFiltered);
            this.Controls.Add(this.tbxReceived);
            this.Controls.Add(this.lblReceived);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblIPAddress);
            this.Controls.Add(this.tbxPort);
            this.Controls.Add(this.tbxIPAddress);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.tbxLog);
            this.Controls.Add(this.btnStart);
            this.Name = "FormServerMain";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbxLog;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox tbxIPAddress;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblReceived;
        private System.Windows.Forms.TextBox tbxReceived;
        private System.Windows.Forms.TextBox tbxFiltered;
        private System.Windows.Forms.Label lblFiltered;
        private System.Windows.Forms.TextBox tbxCountReceived;
        private System.Windows.Forms.Label lblCountReceived;
        private System.Windows.Forms.Label lblCountFiltered;
        private System.Windows.Forms.TextBox tbxCountFiltered;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnExit;
    }
}

