namespace Introduction
{
	partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_time = new System.Windows.Forms.Label();
            this.main_timer = new System.Windows.Forms.Timer(this.components);
            this.lb_date = new System.Windows.Forms.Label();
            this.cb_showdate = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_auto_on = new System.Windows.Forms.Button();
            this.bt_auto_off = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.BackColor = System.Drawing.Color.Violet;
            this.lb_time.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_time.Location = new System.Drawing.Point(78, 30);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(0, 51);
            this.lb_time.TabIndex = 0;
            // 
            // main_timer
            // 
            this.main_timer.Enabled = true;
            this.main_timer.Interval = 1000;
            this.main_timer.Tick += new System.EventHandler(this.main_timer_Tick);
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.BackColor = System.Drawing.Color.Violet;
            this.lb_date.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_date.ForeColor = System.Drawing.Color.Black;
            this.lb_date.Location = new System.Drawing.Point(55, 134);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(91, 51);
            this.lb_date.TabIndex = 1;
            this.lb_date.Text = "Date";
            this.lb_date.Visible = false;
            this.lb_date.Click += new System.EventHandler(this.lb_date_Click);
            // 
            // cb_showdate
            // 
            this.cb_showdate.AutoSize = true;
            this.cb_showdate.BackColor = System.Drawing.Color.Violet;
            this.cb_showdate.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_showdate.Location = new System.Drawing.Point(33, 240);
            this.cb_showdate.Name = "cb_showdate";
            this.cb_showdate.Size = new System.Drawing.Size(124, 29);
            this.cb_showdate.TabIndex = 2;
            this.cb_showdate.Text = "Show date";
            this.cb_showdate.UseVisualStyleBackColor = false;
            this.cb_showdate.CheckedChanged += new System.EventHandler(this.cb_showdate_CheckedChanged);
            this.cb_showdate.MouseLeave += new System.EventHandler(this.cb_showdate_MouseLeave);
            this.cb_showdate.MouseHover += new System.EventHandler(this.cb_showdate_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Introduction.Properties.Resources.Danieledesantis_Playstation_Flat_Playstation_cross_black_and_white__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(511, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 21);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bt_auto_on
            // 
            this.bt_auto_on.BackColor = System.Drawing.Color.Lime;
            this.bt_auto_on.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_auto_on.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_auto_on.Location = new System.Drawing.Point(501, 225);
            this.bt_auto_on.Name = "bt_auto_on";
            this.bt_auto_on.Size = new System.Drawing.Size(33, 23);
            this.bt_auto_on.TabIndex = 5;
            this.bt_auto_on.Text = "on";
            this.bt_auto_on.UseVisualStyleBackColor = false;
            this.bt_auto_on.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_auto_off
            // 
            this.bt_auto_off.BackColor = System.Drawing.Color.Crimson;
            this.bt_auto_off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_auto_off.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_auto_off.Location = new System.Drawing.Point(501, 254);
            this.bt_auto_off.Name = "bt_auto_off";
            this.bt_auto_off.Size = new System.Drawing.Size(33, 23);
            this.bt_auto_off.TabIndex = 6;
            this.bt_auto_off.Text = "off";
            this.bt_auto_off.UseVisualStyleBackColor = false;
            this.bt_auto_off.Click += new System.EventHandler(this.bt_auto_off_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Introduction.Properties.Resources.fsdf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(546, 289);
            this.Controls.Add(this.bt_auto_off);
            this.Controls.Add(this.bt_auto_on);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cb_showdate);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.lb_time);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MyClock";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lb_time;
		private System.Windows.Forms.Timer main_timer;
		private System.Windows.Forms.Label lb_date;
		private System.Windows.Forms.CheckBox cb_showdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_auto_on;
        private System.Windows.Forms.Button bt_auto_off;
    }
}

