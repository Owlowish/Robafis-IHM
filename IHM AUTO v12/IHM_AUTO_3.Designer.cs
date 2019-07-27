namespace PipesClientTest
{
    partial class IHM_AUTO_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IHM_AUTO_3));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_vitesse = new System.Windows.Forms.Label();
            this.lb_direction = new System.Windows.Forms.Label();
            this.pb_droit = new System.Windows.Forms.PictureBox();
            this.pb_gauche = new System.Windows.Forms.PictureBox();
            this.pb_bas = new System.Windows.Forms.PictureBox();
            this.pb_haut = new System.Windows.Forms.PictureBox();
            this.b_arret = new System.Windows.Forms.Button();
            this.lb_message = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_droit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gauche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_haut)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(199, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUIVI DE LIGNE EN COURS";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(117)))), ((int)(((byte)(109)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-9, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 105);
            this.panel2.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PipesClientTest.Properties.Resources.settings;
            this.pictureBox1.Location = new System.Drawing.Point(65, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 84);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lb_vitesse
            // 
            this.lb_vitesse.AutoSize = true;
            this.lb_vitesse.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vitesse.ForeColor = System.Drawing.Color.White;
            this.lb_vitesse.Location = new System.Drawing.Point(268, 311);
            this.lb_vitesse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_vitesse.Name = "lb_vitesse";
            this.lb_vitesse.Size = new System.Drawing.Size(125, 39);
            this.lb_vitesse.TabIndex = 24;
            this.lb_vitesse.Text = "Vitesse";
            // 
            // lb_direction
            // 
            this.lb_direction.AutoSize = true;
            this.lb_direction.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_direction.ForeColor = System.Drawing.Color.White;
            this.lb_direction.Location = new System.Drawing.Point(487, 402);
            this.lb_direction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_direction.Name = "lb_direction";
            this.lb_direction.Size = new System.Drawing.Size(148, 39);
            this.lb_direction.TabIndex = 25;
            this.lb_direction.Text = "Direction";
            this.lb_direction.Visible = false;
            // 
            // pb_droit
            // 
            this.pb_droit.Image = ((System.Drawing.Image)(resources.GetObject("pb_droit.Image")));
            this.pb_droit.Location = new System.Drawing.Point(248, 138);
            this.pb_droit.Margin = new System.Windows.Forms.Padding(4);
            this.pb_droit.Name = "pb_droit";
            this.pb_droit.Size = new System.Drawing.Size(171, 158);
            this.pb_droit.TabIndex = 26;
            this.pb_droit.TabStop = false;
            this.pb_droit.Visible = false;
            // 
            // pb_gauche
            // 
            this.pb_gauche.Image = ((System.Drawing.Image)(resources.GetObject("pb_gauche.Image")));
            this.pb_gauche.Location = new System.Drawing.Point(248, 138);
            this.pb_gauche.Margin = new System.Windows.Forms.Padding(4);
            this.pb_gauche.Name = "pb_gauche";
            this.pb_gauche.Size = new System.Drawing.Size(171, 158);
            this.pb_gauche.TabIndex = 26;
            this.pb_gauche.TabStop = false;
            this.pb_gauche.Visible = false;
            // 
            // pb_bas
            // 
            this.pb_bas.Image = ((System.Drawing.Image)(resources.GetObject("pb_bas.Image")));
            this.pb_bas.Location = new System.Drawing.Point(248, 138);
            this.pb_bas.Margin = new System.Windows.Forms.Padding(4);
            this.pb_bas.Name = "pb_bas";
            this.pb_bas.Size = new System.Drawing.Size(171, 158);
            this.pb_bas.TabIndex = 26;
            this.pb_bas.TabStop = false;
            this.pb_bas.Visible = false;
            // 
            // pb_haut
            // 
            this.pb_haut.Image = ((System.Drawing.Image)(resources.GetObject("pb_haut.Image")));
            this.pb_haut.Location = new System.Drawing.Point(248, 138);
            this.pb_haut.Margin = new System.Windows.Forms.Padding(4);
            this.pb_haut.Name = "pb_haut";
            this.pb_haut.Size = new System.Drawing.Size(171, 158);
            this.pb_haut.TabIndex = 26;
            this.pb_haut.TabStop = false;
            this.pb_haut.Visible = false;
            // 
            // b_arret
            // 
            this.b_arret.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.b_arret.FlatAppearance.BorderSize = 0;
            this.b_arret.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.b_arret.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.b_arret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_arret.Image = ((System.Drawing.Image)(resources.GetObject("b_arret.Image")));
            this.b_arret.Location = new System.Drawing.Point(257, 366);
            this.b_arret.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_arret.Name = "b_arret";
            this.b_arret.Size = new System.Drawing.Size(137, 62);
            this.b_arret.TabIndex = 7;
            this.b_arret.UseVisualStyleBackColor = true;
            this.b_arret.Click += new System.EventHandler(this.b_arret_Click);
            // 
            // lb_message
            // 
            this.lb_message.AutoSize = true;
            this.lb_message.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_message.ForeColor = System.Drawing.Color.Tomato;
            this.lb_message.Location = new System.Drawing.Point(488, 235);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(107, 33);
            this.lb_message.TabIndex = 27;
            this.lb_message.Text = "message";
            // 
            // IHM_AUTO_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(659, 453);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.pb_droit);
            this.Controls.Add(this.pb_gauche);
            this.Controls.Add(this.pb_bas);
            this.Controls.Add(this.pb_haut);
            this.Controls.Add(this.lb_direction);
            this.Controls.Add(this.lb_vitesse);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.b_arret);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IHM_AUTO_3";
            this.Text = "IHM_AUTO_3";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_droit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gauche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_haut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_arret;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_vitesse;
        private System.Windows.Forms.Label lb_direction;
        private System.Windows.Forms.PictureBox pb_haut;
        private System.Windows.Forms.PictureBox pb_bas;
        private System.Windows.Forms.PictureBox pb_gauche;
        private System.Windows.Forms.PictureBox pb_droit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_message;
    }
}