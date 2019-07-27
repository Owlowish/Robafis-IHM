namespace PipesClientTest
{
    partial class DEBUG
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_bluetooth = new System.Windows.Forms.Label();
            this.lb_robot = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_sequence = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.flag_message1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "DEBUG MODE";
            // 
            // lb_bluetooth
            // 
            this.lb_bluetooth.AutoSize = true;
            this.lb_bluetooth.Location = new System.Drawing.Point(169, 66);
            this.lb_bluetooth.Name = "lb_bluetooth";
            this.lb_bluetooth.Size = new System.Drawing.Size(0, 17);
            this.lb_bluetooth.TabIndex = 3;
            // 
            // lb_robot
            // 
            this.lb_robot.AutoSize = true;
            this.lb_robot.Location = new System.Drawing.Point(169, 94);
            this.lb_robot.Name = "lb_robot";
            this.lb_robot.Size = new System.Drawing.Size(0, 17);
            this.lb_robot.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_sequence
            // 
            this.lb_sequence.AutoSize = true;
            this.lb_sequence.Location = new System.Drawing.Point(211, 106);
            this.lb_sequence.Name = "lb_sequence";
            this.lb_sequence.Size = new System.Drawing.Size(46, 17);
            this.lb_sequence.TabIndex = 5;
            this.lb_sequence.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 153);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flag_message1
            // 
            this.flag_message1.AutoSize = true;
            this.flag_message1.Location = new System.Drawing.Point(211, 173);
            this.flag_message1.Name = "flag_message1";
            this.flag_message1.Size = new System.Drawing.Size(92, 17);
            this.flag_message1.TabIndex = 7;
            this.flag_message1.Text = "flag message";
            // 
            // DEBUG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(343, 370);
            this.Controls.Add(this.flag_message1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_sequence);
            this.Controls.Add(this.lb_robot);
            this.Controls.Add(this.lb_bluetooth);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DEBUG";
            this.Text = "DEBUG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_bluetooth;
        private System.Windows.Forms.Label lb_robot;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_sequence;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label flag_message1;
    }
}