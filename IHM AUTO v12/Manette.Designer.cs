namespace PipesClientTest
{
    partial class Manette
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manette));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_vitesse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pb_vitesse_nok1 = new System.Windows.Forms.PictureBox();
            this.b_help = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_vitesse_ok1 = new System.Windows.Forms.PictureBox();
            this.pb_vitesse_nok0 = new System.Windows.Forms.PictureBox();
            this.pb_vitesse_ok0 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_vitesse_nok1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_vitesse_ok1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_vitesse_nok0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_vitesse_ok0)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lb_vitesse
            // 
            this.lb_vitesse.AutoSize = true;
            this.lb_vitesse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vitesse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_vitesse.Location = new System.Drawing.Point(261, 127);
            this.lb_vitesse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_vitesse.Name = "lb_vitesse";
            this.lb_vitesse.Size = new System.Drawing.Size(69, 20);
            this.lb_vitesse.TabIndex = 0;
            this.lb_vitesse.Text = "Vitesse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(180, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONTRÔLE MANETTE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(117)))), ((int)(((byte)(109)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-1, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 85);
            this.panel2.TabIndex = 23;
            // 
            // pb_vitesse_nok1
            // 
            this.pb_vitesse_nok1.Image = ((System.Drawing.Image)(resources.GetObject("pb_vitesse_nok1.Image")));
            this.pb_vitesse_nok1.Location = new System.Drawing.Point(451, 115);
            this.pb_vitesse_nok1.Name = "pb_vitesse_nok1";
            this.pb_vitesse_nok1.Size = new System.Drawing.Size(64, 67);
            this.pb_vitesse_nok1.TabIndex = 28;
            this.pb_vitesse_nok1.TabStop = false;
            this.pb_vitesse_nok1.Visible = false;
            // 
            // b_help
            // 
            this.b_help.Image = ((System.Drawing.Image)(resources.GetObject("b_help.Image")));
            this.b_help.Location = new System.Drawing.Point(22, 115);
            this.b_help.Name = "b_help";
            this.b_help.Size = new System.Drawing.Size(83, 46);
            this.b_help.TabIndex = 27;
            this.b_help.UseVisualStyleBackColor = true;
            this.b_help.Visible = false;
            this.b_help.Click += new System.EventHandler(this.b_help_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(172, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 222);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pb_vitesse_ok1
            // 
            this.pb_vitesse_ok1.Image = ((System.Drawing.Image)(resources.GetObject("pb_vitesse_ok1.Image")));
            this.pb_vitesse_ok1.Location = new System.Drawing.Point(528, 115);
            this.pb_vitesse_ok1.Name = "pb_vitesse_ok1";
            this.pb_vitesse_ok1.Size = new System.Drawing.Size(64, 67);
            this.pb_vitesse_ok1.TabIndex = 28;
            this.pb_vitesse_ok1.TabStop = false;
            this.pb_vitesse_ok1.Visible = false;
            // 
            // pb_vitesse_nok0
            // 
            this.pb_vitesse_nok0.Image = ((System.Drawing.Image)(resources.GetObject("pb_vitesse_nok0.Image")));
            this.pb_vitesse_nok0.Location = new System.Drawing.Point(451, 115);
            this.pb_vitesse_nok0.Name = "pb_vitesse_nok0";
            this.pb_vitesse_nok0.Size = new System.Drawing.Size(64, 67);
            this.pb_vitesse_nok0.TabIndex = 28;
            this.pb_vitesse_nok0.TabStop = false;
            // 
            // pb_vitesse_ok0
            // 
            this.pb_vitesse_ok0.Image = ((System.Drawing.Image)(resources.GetObject("pb_vitesse_ok0.Image")));
            this.pb_vitesse_ok0.Location = new System.Drawing.Point(528, 115);
            this.pb_vitesse_ok0.Name = "pb_vitesse_ok0";
            this.pb_vitesse_ok0.Size = new System.Drawing.Size(64, 67);
            this.pb_vitesse_ok0.TabIndex = 28;
            this.pb_vitesse_ok0.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(169, 427);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Appuyez sur START pour de l\'aide.";
            // 
            // tb2
            // 
            this.tb2.AutoSize = true;
            this.tb2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb2.Location = new System.Drawing.Point(219, 161);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(42, 21);
            this.tb2.TabIndex = 32;
            this.tb2.Text = "Bras";
            // 
            // Manette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(604, 452);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_vitesse_ok0);
            this.Controls.Add(this.pb_vitesse_ok1);
            this.Controls.Add(this.pb_vitesse_nok0);
            this.Controls.Add(this.pb_vitesse_nok1);
            this.Controls.Add(this.b_help);
            this.Controls.Add(this.lb_vitesse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Manette";
            this.Text = "Manette";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_vitesse_nok1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_vitesse_ok1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_vitesse_nok0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_vitesse_ok0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_vitesse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button b_help;
        private System.Windows.Forms.PictureBox pb_vitesse_nok1;
        private System.Windows.Forms.PictureBox pb_vitesse_ok1;
        private System.Windows.Forms.PictureBox pb_vitesse_nok0;
        private System.Windows.Forms.PictureBox pb_vitesse_ok0;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tb2;
    }
}