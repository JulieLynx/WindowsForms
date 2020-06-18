namespace Introduction
{
    partial class stopwatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stopwatch));
            this.lb_stopWatch = new System.Windows.Forms.Label();
            this.sw_timer = new System.Windows.Forms.Timer(this.components);
            this.bt_sw_start = new System.Windows.Forms.Button();
            this.bt_sw_finish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_stopWatch
            // 
            this.lb_stopWatch.AutoSize = true;
            this.lb_stopWatch.BackColor = System.Drawing.Color.Violet;
            this.lb_stopWatch.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_stopWatch.ForeColor = System.Drawing.Color.Black;
            this.lb_stopWatch.Location = new System.Drawing.Point(51, 51);
            this.lb_stopWatch.Name = "lb_stopWatch";
            this.lb_stopWatch.Size = new System.Drawing.Size(173, 51);
            this.lb_stopWatch.TabIndex = 2;
            this.lb_stopWatch.Text = "stopwatch";
            this.lb_stopWatch.Visible = false;
            this.lb_stopWatch.Click += new System.EventHandler(this.lb_stopWatch_Click);
            // 
            // sw_timer
            // 
            this.sw_timer.Enabled = true;
            this.sw_timer.Interval = 1000;
            this.sw_timer.Tick += new System.EventHandler(this.sw_timer_Tick);
            // 
            // bt_sw_start
            // 
            this.bt_sw_start.Location = new System.Drawing.Point(50, 134);
            this.bt_sw_start.Name = "bt_sw_start";
            this.bt_sw_start.Size = new System.Drawing.Size(75, 23);
            this.bt_sw_start.TabIndex = 3;
            this.bt_sw_start.Text = "start";
            this.bt_sw_start.UseVisualStyleBackColor = true;
            this.bt_sw_start.Click += new System.EventHandler(this.bt_sw_start_Click);
            // 
            // bt_sw_finish
            // 
            this.bt_sw_finish.Location = new System.Drawing.Point(149, 134);
            this.bt_sw_finish.Name = "bt_sw_finish";
            this.bt_sw_finish.Size = new System.Drawing.Size(75, 23);
            this.bt_sw_finish.TabIndex = 4;
            this.bt_sw_finish.Text = "finish";
            this.bt_sw_finish.UseVisualStyleBackColor = true;
            this.bt_sw_finish.Click += new System.EventHandler(this.bt_sw_finish_Click);
            // 
            // stopwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 210);
            this.Controls.Add(this.bt_sw_finish);
            this.Controls.Add(this.bt_sw_start);
            this.Controls.Add(this.lb_stopWatch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "stopwatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "stopwatch";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_stopWatch;
        private System.Windows.Forms.Timer sw_timer;
        private System.Windows.Forms.Button bt_sw_start;
        private System.Windows.Forms.Button bt_sw_finish;
    }
}