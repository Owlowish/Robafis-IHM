namespace PipesClientTest
{
    partial class IHM_connecter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IHM_connecter));
            this.b_connecter = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_connecter
            // 
            this.b_connecter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(130)))), ((int)(((byte)(186)))));
            this.b_connecter.FlatAppearance.BorderSize = 0;
            this.b_connecter.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b_connecter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(130)))), ((int)(((byte)(186)))));
            this.b_connecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_connecter.Image = ((System.Drawing.Image)(resources.GetObject("b_connecter.Image")));
            this.b_connecter.Location = new System.Drawing.Point(66, 215);
            this.b_connecter.Margin = new System.Windows.Forms.Padding(2);
            this.b_connecter.Name = "b_connecter";
            this.b_connecter.Size = new System.Drawing.Size(154, 35);
            this.b_connecter.TabIndex = 0;
            this.b_connecter.UseVisualStyleBackColor = true;
            this.b_connecter.Click += new System.EventHandler(this.b_connecter_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 130);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(46, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Veuillez vous connecter à";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(105, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "IHM Pilot";
            // 
            // IHM_connecter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(130)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(308, 301);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.b_connecter);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IHM_connecter";
            this.Text = "IHM_connecter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IHM_connecter_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_connecter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}