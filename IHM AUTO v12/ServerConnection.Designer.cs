namespace PipesClientTest
{
    partial class ServerConnection
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbServer = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbServerSend = new System.Windows.Forms.TextBox();
            this.tbServerReceived = new System.Windows.Forms.TextBox();
            this.btnSendToClient = new System.Windows.Forms.Button();
            this.gbServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbServer
            // 
            this.gbServer.Controls.Add(this.label1);
            this.gbServer.Controls.Add(this.tbServerSend);
            this.gbServer.Controls.Add(this.tbServerReceived);
            this.gbServer.Controls.Add(this.btnSendToClient);
            this.gbServer.Location = new System.Drawing.Point(3, 3);
            this.gbServer.Name = "gbServer";
            this.gbServer.Size = new System.Drawing.Size(329, 97);
            this.gbServer.TabIndex = 4;
            this.gbServer.TabStop = false;
            this.gbServer.Text = "Server";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Received:";
            // 
            // tbServerSend
            // 
            this.tbServerSend.Location = new System.Drawing.Point(15, 22);
            this.tbServerSend.Margin = new System.Windows.Forms.Padding(2);
            this.tbServerSend.Name = "tbServerSend";
            this.tbServerSend.Size = new System.Drawing.Size(220, 20);
            this.tbServerSend.TabIndex = 1;
            this.tbServerSend.Text = "Test Message";
            // 
            // tbServerReceived
            // 
            this.tbServerReceived.Location = new System.Drawing.Point(15, 68);
            this.tbServerReceived.Name = "tbServerReceived";
            this.tbServerReceived.ReadOnly = true;
            this.tbServerReceived.Size = new System.Drawing.Size(301, 20);
            this.tbServerReceived.TabIndex = 2;
            // 
            // btnSendToClient
            // 
            this.btnSendToClient.Location = new System.Drawing.Point(239, 19);
            this.btnSendToClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendToClient.Name = "btnSendToClient";
            this.btnSendToClient.Size = new System.Drawing.Size(77, 25);
            this.btnSendToClient.TabIndex = 0;
            this.btnSendToClient.Tag = "0";
            this.btnSendToClient.Text = "Send";
            this.btnSendToClient.UseVisualStyleBackColor = true;
            // 
            // ServerConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbServer);
            this.Name = "ServerConnection";
            this.Size = new System.Drawing.Size(336, 103);
            this.gbServer.ResumeLayout(false);
            this.gbServer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbServerSend;
        private System.Windows.Forms.TextBox tbServerReceived;
        private System.Windows.Forms.Button btnSendToClient;
    }
}
