namespace Week1_StrategyPattern
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
            this.gbStrategy = new System.Windows.Forms.GroupBox();
            this.rbScanDisk = new System.Windows.Forms.RadioButton();
            this.rbSSTF = new System.Windows.Forms.RadioButton();
            this.rbFFCS = new System.Windows.Forms.RadioButton();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.lbNumbers = new System.Windows.Forms.ListBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.gbStrategy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbStrategy
            // 
            this.gbStrategy.Controls.Add(this.rbScanDisk);
            this.gbStrategy.Controls.Add(this.rbSSTF);
            this.gbStrategy.Controls.Add(this.rbFFCS);
            this.gbStrategy.Location = new System.Drawing.Point(299, 12);
            this.gbStrategy.Name = "gbStrategy";
            this.gbStrategy.Size = new System.Drawing.Size(200, 100);
            this.gbStrategy.TabIndex = 0;
            this.gbStrategy.TabStop = false;
            this.gbStrategy.Text = "Strategy";
            // 
            // rbScanDisk
            // 
            this.rbScanDisk.AutoSize = true;
            this.rbScanDisk.Location = new System.Drawing.Point(3, 73);
            this.rbScanDisk.Name = "rbScanDisk";
            this.rbScanDisk.Size = new System.Drawing.Size(157, 21);
            this.rbScanDisk.TabIndex = 2;
            this.rbScanDisk.TabStop = true;
            this.rbScanDisk.Text = "Scan Disk (elevator)";
            this.rbScanDisk.UseVisualStyleBackColor = true;
            // 
            // rbSSTF
            // 
            this.rbSSTF.AutoSize = true;
            this.rbSSTF.Location = new System.Drawing.Point(3, 46);
            this.rbSSTF.Name = "rbSSTF";
            this.rbSSTF.Size = new System.Drawing.Size(184, 21);
            this.rbSSTF.TabIndex = 1;
            this.rbSSTF.TabStop = true;
            this.rbSSTF.Text = "Shortest Seek Time First";
            this.rbSSTF.UseVisualStyleBackColor = true;
            // 
            // rbFFCS
            // 
            this.rbFFCS.AutoSize = true;
            this.rbFFCS.Location = new System.Drawing.Point(3, 18);
            this.rbFFCS.Name = "rbFFCS";
            this.rbFFCS.Size = new System.Drawing.Size(168, 21);
            this.rbFFCS.TabIndex = 0;
            this.rbFFCS.TabStop = true;
            this.rbFFCS.Text = "First Come First Serve";
            this.rbFFCS.UseVisualStyleBackColor = true;
            this.rbFFCS.CheckedChanged += new System.EventHandler(this.rbFFCS_CheckedChanged);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(299, 165);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(200, 38);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(299, 225);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(200, 38);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click_1);
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(175, 12);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(108, 22);
            this.tbNumber.TabIndex = 3;
            // 
            // lbNumbers
            // 
            this.lbNumbers.FormattingEnabled = true;
            this.lbNumbers.ItemHeight = 16;
            this.lbNumbers.Location = new System.Drawing.Point(175, 42);
            this.lbNumbers.Name = "lbNumbers";
            this.lbNumbers.Size = new System.Drawing.Size(108, 388);
            this.lbNumbers.TabIndex = 4;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(23, 12);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 418);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(85, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 7;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lbNumbers);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.gbStrategy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbStrategy.ResumeLayout(false);
            this.gbStrategy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStrategy;
        private System.Windows.Forms.RadioButton rbScanDisk;
        private System.Windows.Forms.RadioButton rbSSTF;
        private System.Windows.Forms.RadioButton rbFFCS;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.ListBox lbNumbers;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}

