namespace PipesClientTest
{
    partial class IHM_CONTROLE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IHM_CONTROLE));
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lb_pos = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b_monter = new System.Windows.Forms.Button();
            this.b_descendre = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(300, 101);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Vitesse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(72)))), ((int)(((byte)(127)))));
            this.label6.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 39);
            this.label6.TabIndex = 20;
            this.label6.Text = "Manette";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(72)))), ((int)(((byte)(127)))));
            this.panel5.Controls.Add(this.lb_pos);
            this.panel5.Controls.Add(this.tb2);
            this.panel5.Controls.Add(this.tb1);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(11, 349);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(705, 48);
            this.panel5.TabIndex = 33;
            // 
            // lb_pos
            // 
            this.lb_pos.AutoSize = true;
            this.lb_pos.Location = new System.Drawing.Point(634, 15);
            this.lb_pos.Name = "lb_pos";
            this.lb_pos.Size = new System.Drawing.Size(37, 13);
            this.lb_pos.TabIndex = 33;
            this.lb_pos.Text = "debug";
            this.lb_pos.Visible = false;
            // 
            // tb2
            // 
            this.tb2.AutoSize = true;
            this.tb2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb2.Location = new System.Drawing.Point(354, 15);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(61, 22);
            this.tb2.TabIndex = 32;
            this.tb2.Text = "label4";
            // 
            // tb1
            // 
            this.tb1.AutoSize = true;
            this.tb1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb1.Location = new System.Drawing.Point(91, 7);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(72, 31);
            this.tb1.TabIndex = 31;
            this.tb1.Text = "label9";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(72)))), ((int)(((byte)(127)))));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.b_monter);
            this.panel3.Controls.Add(this.b_descendre);
            this.panel3.Location = new System.Drawing.Point(559, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(157, 341);
            this.panel3.TabIndex = 34;
            // 
            // pictureBox3
            // 
            this.pictureBox3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(72)))), ((int)(((byte)(127)))));
            this.pictureBox3.FlatAppearance.BorderSize = 0;
            this.pictureBox3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.pictureBox3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.pictureBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(47, 6);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 60);
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.UseVisualStyleBackColor = true;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(47, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Quitter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Monter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 282);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Descendre";
            // 
            // b_monter
            // 
            this.b_monter.BackColor = System.Drawing.Color.White;
            this.b_monter.Image = ((System.Drawing.Image)(resources.GetObject("b_monter.Image")));
            this.b_monter.Location = new System.Drawing.Point(35, 228);
            this.b_monter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_monter.Name = "b_monter";
            this.b_monter.Size = new System.Drawing.Size(88, 52);
            this.b_monter.TabIndex = 6;
            this.b_monter.UseVisualStyleBackColor = false;
            this.b_monter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.b_monter_MouseDown);
            this.b_monter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.b_monter_MouseUp);
            // 
            // b_descendre
            // 
            this.b_descendre.BackColor = System.Drawing.Color.White;
            this.b_descendre.Image = ((System.Drawing.Image)(resources.GetObject("b_descendre.Image")));
            this.b_descendre.Location = new System.Drawing.Point(35, 137);
            this.b_descendre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_descendre.Name = "b_descendre";
            this.b_descendre.Size = new System.Drawing.Size(88, 52);
            this.b_descendre.TabIndex = 5;
            this.b_descendre.UseVisualStyleBackColor = false;
            this.b_descendre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.b_descendre_MouseDown);
            this.b_descendre.MouseUp += new System.Windows.Forms.MouseEventHandler(this.b_descendre_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(72)))), ((int)(((byte)(127)))));
            this.label7.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(5, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 39);
            this.label7.TabIndex = 21;
            this.label7.Text = "Virtuelle";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 20);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 89);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(72)))), ((int)(((byte)(127)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(157, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 341);
            this.panel1.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 337);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(72)))), ((int)(((byte)(127)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(11, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 341);
            this.panel2.TabIndex = 32;
            // 
            // IHM_CONTROLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(724, 406);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "IHM_CONTROLE";
            this.Text = "IHM_CONTROLE";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.IHM_CONTROLE_Paint);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_monter;
        private System.Windows.Forms.Button b_descendre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tb1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button pictureBox3;
        private System.Windows.Forms.Label tb2;
        private System.Windows.Forms.Label lb_pos;
    }
}