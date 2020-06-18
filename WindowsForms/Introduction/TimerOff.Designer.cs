namespace Introduction
{
    partial class TimerOff
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
            this.tb_h = new System.Windows.Forms.TextBox();
            this.tb_m = new System.Windows.Forms.TextBox();
            this.tb_s = new System.Windows.Forms.TextBox();
            this.bt_off_your_pc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lb_timer_pc_off = new System.Windows.Forms.Label();
            this.pictureBox_cancel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cancel)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_h
            // 
            this.tb_h.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_h.Location = new System.Drawing.Point(68, 42);
            this.tb_h.MaxLength = 2;
            this.tb_h.Name = "tb_h";
            this.tb_h.Size = new System.Drawing.Size(29, 25);
            this.tb_h.TabIndex = 0;
            // 
            // tb_m
            // 
            this.tb_m.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_m.Location = new System.Drawing.Point(129, 42);
            this.tb_m.MaxLength = 2;
            this.tb_m.Name = "tb_m";
            this.tb_m.Size = new System.Drawing.Size(29, 25);
            this.tb_m.TabIndex = 1;
            // 
            // tb_s
            // 
            this.tb_s.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_s.Location = new System.Drawing.Point(189, 42);
            this.tb_s.MaxLength = 2;
            this.tb_s.Name = "tb_s";
            this.tb_s.Size = new System.Drawing.Size(28, 25);
            this.tb_s.TabIndex = 2;
            this.tb_s.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // bt_off_your_pc
            // 
            this.bt_off_your_pc.Location = new System.Drawing.Point(108, 85);
            this.bt_off_your_pc.Name = "bt_off_your_pc";
            this.bt_off_your_pc.Size = new System.Drawing.Size(75, 23);
            this.bt_off_your_pc.TabIndex = 3;
            this.bt_off_your_pc.Text = "Off your PC";
            this.bt_off_your_pc.UseVisualStyleBackColor = true;
            this.bt_off_your_pc.Click += new System.EventHandler(this.bt_off_your_pc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = ":";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_off_pc_Tick);
            // 
            // lb_timer_pc_off
            // 
            this.lb_timer_pc_off.AutoSize = true;
            this.lb_timer_pc_off.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_timer_pc_off.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_timer_pc_off.ForeColor = System.Drawing.Color.Black;
            this.lb_timer_pc_off.Location = new System.Drawing.Point(59, 122);
            this.lb_timer_pc_off.Name = "lb_timer_pc_off";
            this.lb_timer_pc_off.Size = new System.Drawing.Size(103, 51);
            this.lb_timer_pc_off.TabIndex = 6;
            this.lb_timer_pc_off.Text = "timer";
            this.lb_timer_pc_off.Visible = false;
            this.lb_timer_pc_off.Click += new System.EventHandler(this.timer_pc_off_Click);
            // 
            // pictureBox_cancel
            // 
            this.pictureBox_cancel.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_cancel.BackgroundImage = global::Introduction.Properties.Resources.Danieledesantis_Playstation_Flat_Playstation_cross_black_and_white__1_;
            this.pictureBox_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_cancel.Location = new System.Drawing.Point(196, 140);
            this.pictureBox_cancel.Name = "pictureBox_cancel";
            this.pictureBox_cancel.Size = new System.Drawing.Size(21, 21);
            this.pictureBox_cancel.TabIndex = 7;
            this.pictureBox_cancel.TabStop = false;
            this.pictureBox_cancel.Visible = false;
            this.pictureBox_cancel.Click += new System.EventHandler(this.pictureBox_cancel_Click);
            // 
            // TimerOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 205);
            this.Controls.Add(this.pictureBox_cancel);
            this.Controls.Add(this.lb_timer_pc_off);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_off_your_pc);
            this.Controls.Add(this.tb_s);
            this.Controls.Add(this.tb_m);
            this.Controls.Add(this.tb_h);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TimerOff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimerOff";
            this.Load += new System.EventHandler(this.TimerOff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_h;
        private System.Windows.Forms.TextBox tb_m;
        private System.Windows.Forms.TextBox tb_s;
        private System.Windows.Forms.Button bt_off_your_pc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lb_timer_pc_off;
        private System.Windows.Forms.PictureBox pictureBox_cancel;
    }
}