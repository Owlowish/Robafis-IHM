namespace PipesClientTest
{
    partial class ClientConnection
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
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbClientSend = new System.Windows.Forms.TextBox();
            this.tbClientReceived = new System.Windows.Forms.TextBox();
            this.btnSendToServer = new System.Windows.Forms.Button();
            this.gbClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.label2);
            this.gbClient.Controls.Add(this.tbClientSend);
            this.gbClient.Controls.Add(this.tbClientReceived);
            this.gbClient.Controls.Add(this.btnSendToServer);
            this.gbClient.Location = new System.Drawing.Point(3, 3);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(329, 96);
            this.gbClient.TabIndex = 6;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Received:";
            // 
            // tbClientSend
            // 
            this.tbClientSend.Location = new System.Drawing.Point(13, 21);
            this.tbClientSend.Margin = new System.Windows.Forms.Padding(2);
            this.tbClientSend.Name = "tbClientSend";
            this.tbClientSend.Size = new System.Drawing.Size(220, 20);
            this.tbClientSend.TabIndex = 1;
            this.tbClientSend.Text = "Test Message";
            // 
            // tbClientReceived
            // 
            this.tbClientReceived.Location = new System.Drawing.Point(13, 67);
            this.tbClientReceived.Name = "tbClientReceived";
            this.tbClientReceived.ReadOnly = true;
            this.tbClientReceived.Size = new System.Drawing.Size(301, 20);
            this.tbClientReceived.TabIndex = 2;
            // 
            // btnSendToServer
            // 
            this.btnSendToServer.Location = new System.Drawing.Point(237, 18);
            this.btnSendToServer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendToServer.Name = "btnSendToServer";
            this.btnSendToServer.Size = new System.Drawing.Size(77, 25);
            this.btnSendToServer.TabIndex = 0;
            this.btnSendToServer.Tag = "0";
            this.btnSendToServer.Text = "Send";
            this.btnSendToServer.UseVisualStyleBackColor = true;
            // 
            // ClientConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbClient);
            this.Name = "ClientConnection";
            this.Size = new System.Drawing.Size(334, 103);
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbClientSend;
        private System.Windows.Forms.TextBox tbClientReceived;
        private System.Windows.Forms.Button btnSendToServer;
    }
}
