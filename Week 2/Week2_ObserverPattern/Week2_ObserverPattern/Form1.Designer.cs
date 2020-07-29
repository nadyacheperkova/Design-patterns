namespace Week2_ObserverPattern
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
            this.lbCurrent = new System.Windows.Forms.ListBox();
            this.gbCurrent = new System.Windows.Forms.GroupBox();
            this.gbCurrent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCurrent
            // 
            this.lbCurrent.FormattingEnabled = true;
            this.lbCurrent.ItemHeight = 16;
            this.lbCurrent.Location = new System.Drawing.Point(19, 54);
            this.lbCurrent.Name = "lbCurrent";
            this.lbCurrent.Size = new System.Drawing.Size(395, 324);
            this.lbCurrent.TabIndex = 0;
            // 
            // gbCurrent
            // 
            this.gbCurrent.Controls.Add(this.lbCurrent);
            this.gbCurrent.Location = new System.Drawing.Point(23, 12);
            this.gbCurrent.Name = "gbCurrent";
            this.gbCurrent.Size = new System.Drawing.Size(437, 404);
            this.gbCurrent.TabIndex = 4;
            this.gbCurrent.TabStop = false;
            this.gbCurrent.Text = "Weather Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.Controls.Add(this.gbCurrent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbCurrent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbCurrent;
        private System.Windows.Forms.GroupBox gbCurrent;
    }
}

