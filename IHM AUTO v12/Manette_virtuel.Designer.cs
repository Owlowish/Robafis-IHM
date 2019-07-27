namespace PipesClientTest
{
    partial class Manette_virtuel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manette_virtuel));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.b_joystick = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.panel1.Location = new System.Drawing.Point(150, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 341);
            this.panel1.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.tb1);
            this.panel2.Controls.Add(this.tb2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(4, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 341);
            this.panel2.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::PipesClientTest.Properties.Resources.RHJAH41;
            this.button1.Location = new System.Drawing.Point(28, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 60);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb1
            // 
            this.tb1.AutoSize = true;
            this.tb1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb1.Location = new System.Drawing.Point(33, 160);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(61, 22);
            this.tb1.TabIndex = 37;
            this.tb1.Text = "label1";
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(28, 196);
            this.tb2.Margin = new System.Windows.Forms.Padding(2);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(76, 20);
            this.tb2.TabIndex = 1;
            this.tb2.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 20);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 89);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // b_joystick
            // 
            this.b_joystick.BackColor = System.Drawing.Color.Gray;
            this.b_joystick.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.b_joystick.FlatAppearance.BorderSize = 0;
            this.b_joystick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.b_joystick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.b_joystick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_joystick.Image = ((System.Drawing.Image)(resources.GetObject("b_joystick.Image")));
            this.b_joystick.Location = new System.Drawing.Point(300, 100);
            this.b_joystick.Name = "b_joystick";
            this.b_joystick.Size = new System.Drawing.Size(100, 100);
            this.b_joystick.TabIndex = 0;
            this.b_joystick.UseVisualStyleBackColor = false;
            this.b_joystick.MouseDown += new System.Windows.Forms.MouseEventHandler(this.b_joystick_MouseDown);
            this.b_joystick.MouseMove += new System.Windows.Forms.MouseEventHandler(this.b_joystick_MouseMove);
            this.b_joystick.MouseUp += new System.Windows.Forms.MouseEventHandler(this.b_joystick_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(197, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 300);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // Manette_virtuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(548, 345);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.b_joystick);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manette_virtuel";
            this.Text = "Manette_virtuel";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Manette_virtuel_Paint);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button b_joystick;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label tb1;
    }
}