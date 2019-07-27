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
            this.b_sequence = new System.Windows.Forms.Button();
            this.lb_sequence = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_flag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_sequence
            // 
            this.b_sequence.Location = new System.Drawing.Point(11, 124);
            this.b_sequence.Margin = new System.Windows.Forms.Padding(2);
            this.b_sequence.Name = "b_sequence";
            this.b_sequence.Size = new System.Drawing.Size(83, 34);
            this.b_sequence.TabIndex = 4;
            this.b_sequence.Text = "sequence";
            this.b_sequence.UseVisualStyleBackColor = true;
            this.b_sequence.Click += new System.EventHandler(this.b_sequence_Click);
            // 
            // lb_sequence
            // 
            this.lb_sequence.AutoSize = true;
            this.lb_sequence.Location = new System.Drawing.Point(156, 132);
            this.lb_sequence.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_sequence.Name = "lb_sequence";
            this.lb_sequence.Size = new System.Drawing.Size(35, 13);
            this.lb_sequence.TabIndex = 5;
            this.lb_sequence.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_flag
            // 
            this.lb_flag.AutoSize = true;
            this.lb_flag.Location = new System.Drawing.Point(84, 59);
            this.lb_flag.Name = "lb_flag";
            this.lb_flag.Size = new System.Drawing.Size(35, 13);
            this.lb_flag.TabIndex = 6;
            this.lb_flag.Text = "label1";
            // 
            // DEBUG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 194);
            this.Controls.Add(this.lb_flag);
            this.Controls.Add(this.lb_sequence);
            this.Controls.Add(this.b_sequence);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DEBUG";
            this.Text = "DEBUG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button b_sequence;
        private System.Windows.Forms.Label lb_sequence;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_flag;
    }
}