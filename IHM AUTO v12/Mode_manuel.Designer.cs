namespace PipesClientTest
{
    partial class Mode_manuel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mode_manuel));
            this.b_manette = new System.Windows.Forms.Button();
            this.b_manette_virtuel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // b_manette
            // 
            this.b_manette.Image = ((System.Drawing.Image)(resources.GetObject("b_manette.Image")));
            this.b_manette.Location = new System.Drawing.Point(83, 179);
            this.b_manette.Name = "b_manette";
            this.b_manette.Size = new System.Drawing.Size(89, 45);
            this.b_manette.TabIndex = 0;
            this.b_manette.UseVisualStyleBackColor = true;
            this.b_manette.Click += new System.EventHandler(this.b_manette_Click);
            // 
            // b_manette_virtuel
            // 
            this.b_manette_virtuel.Image = ((System.Drawing.Image)(resources.GetObject("b_manette_virtuel.Image")));
            this.b_manette_virtuel.Location = new System.Drawing.Point(329, 179);
            this.b_manette_virtuel.Name = "b_manette_virtuel";
            this.b_manette_virtuel.Size = new System.Drawing.Size(81, 47);
            this.b_manette_virtuel.TabIndex = 1;
            this.b_manette_virtuel.UseVisualStyleBackColor = true;
            this.b_manette_virtuel.Click += new System.EventHandler(this.b_manette_virtuel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(306, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 139);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(64, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 141);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Mode_manuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(482, 287);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.b_manette_virtuel);
            this.Controls.Add(this.b_manette);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mode_manuel";
            this.Text = "Mode_manuel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_manette;
        private System.Windows.Forms.Button b_manette_virtuel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}