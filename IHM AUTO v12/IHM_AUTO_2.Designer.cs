namespace PipesClientTest
{
    partial class IHM_AUTO_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IHM_AUTO_2));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_ihmauto2_modemanu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(127, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "IHM MANUEL EN COURS...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(203, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 161);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // b_ihmauto2_modemanu
            // 
            this.b_ihmauto2_modemanu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.b_ihmauto2_modemanu.FlatAppearance.BorderSize = 0;
            this.b_ihmauto2_modemanu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.b_ihmauto2_modemanu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.b_ihmauto2_modemanu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_ihmauto2_modemanu.Image = ((System.Drawing.Image)(resources.GetObject("b_ihmauto2_modemanu.Image")));
            this.b_ihmauto2_modemanu.Location = new System.Drawing.Point(187, 362);
            this.b_ihmauto2_modemanu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_ihmauto2_modemanu.Name = "b_ihmauto2_modemanu";
            this.b_ihmauto2_modemanu.Size = new System.Drawing.Size(200, 62);
            this.b_ihmauto2_modemanu.TabIndex = 1;
            this.b_ihmauto2_modemanu.UseVisualStyleBackColor = true;
            this.b_ihmauto2_modemanu.Click += new System.EventHandler(this.b_ihmauto2_modemanu_Click);
            // 
            // IHM_AUTO_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(559, 463);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_ihmauto2_modemanu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IHM_AUTO_2";
            this.Text = "IHM_AUTO_2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IHM_AUTO_2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button b_ihmauto2_modemanu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}