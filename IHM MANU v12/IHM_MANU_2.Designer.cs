namespace PipesClientTest
{
    partial class IHM_MANU_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IHM_MANU_2));
            this.b_mode_manu = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_debug = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_mode_manu
            // 
            this.b_mode_manu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(130)))), ((int)(((byte)(186)))));
            this.b_mode_manu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(130)))), ((int)(((byte)(186)))));
            this.b_mode_manu.FlatAppearance.BorderSize = 0;
            this.b_mode_manu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b_mode_manu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(130)))), ((int)(((byte)(186)))));
            this.b_mode_manu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_mode_manu.Image = ((System.Drawing.Image)(resources.GetObject("b_mode_manu.Image")));
            this.b_mode_manu.Location = new System.Drawing.Point(68, 274);
            this.b_mode_manu.Margin = new System.Windows.Forms.Padding(2);
            this.b_mode_manu.Name = "b_mode_manu";
            this.b_mode_manu.Size = new System.Drawing.Size(191, 33);
            this.b_mode_manu.TabIndex = 0;
            this.b_mode_manu.UseVisualStyleBackColor = false;
            this.b_mode_manu.Click += new System.EventHandler(this.b_mode_manu_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(130)))), ((int)(((byte)(186)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.b_mode_manu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.b_debug);
            this.panel1.Location = new System.Drawing.Point(-9, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 344);
            this.panel1.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(98, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 130);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(130)))), ((int)(((byte)(186)))));
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(44, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "MODE AUTO EN COURS";
            // 
            // b_debug
            // 
            this.b_debug.Image = ((System.Drawing.Image)(resources.GetObject("b_debug.Image")));
            this.b_debug.Location = new System.Drawing.Point(476, 549);
            this.b_debug.Margin = new System.Windows.Forms.Padding(2);
            this.b_debug.Name = "b_debug";
            this.b_debug.Size = new System.Drawing.Size(92, 35);
            this.b_debug.TabIndex = 15;
            this.b_debug.UseVisualStyleBackColor = true;
            // 
            // IHM_MANU_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(318, 325);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IHM_MANU_2";
            this.Text = "IHM_MANU_2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IHM_MANU_2_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_mode_manu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_debug;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}