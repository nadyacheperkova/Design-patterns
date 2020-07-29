namespace CommandPattern
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
            this.rbTshirt = new System.Windows.Forms.RadioButton();
            this.rbPants = new System.Windows.Forms.RadioButton();
            this.rbShoes = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lbOrder = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbShoes = new System.Windows.Forms.PictureBox();
            this.pbTshirt = new System.Windows.Forms.PictureBox();
            this.pbPants = new System.Windows.Forms.PictureBox();
            this.lbBuy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTshirt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPants)).BeginInit();
            this.SuspendLayout();
            // 
            // rbTshirt
            // 
            this.rbTshirt.AutoSize = true;
            this.rbTshirt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTshirt.Location = new System.Drawing.Point(92, 337);
            this.rbTshirt.Margin = new System.Windows.Forms.Padding(4);
            this.rbTshirt.Name = "rbTshirt";
            this.rbTshirt.Size = new System.Drawing.Size(100, 23);
            this.rbTshirt.TabIndex = 0;
            this.rbTshirt.Text = "T-shirt";
            this.rbTshirt.UseVisualStyleBackColor = true;
            this.rbTshirt.CheckedChanged += new System.EventHandler(this.rbTshirt_CheckedChanged);
            // 
            // rbPants
            // 
            this.rbPants.AutoSize = true;
            this.rbPants.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPants.Location = new System.Drawing.Point(385, 337);
            this.rbPants.Margin = new System.Windows.Forms.Padding(4);
            this.rbPants.Name = "rbPants";
            this.rbPants.Size = new System.Drawing.Size(80, 23);
            this.rbPants.TabIndex = 0;
            this.rbPants.Text = "Pants";
            this.rbPants.UseVisualStyleBackColor = true;
            this.rbPants.CheckedChanged += new System.EventHandler(this.rbPants_CheckedChanged);
            // 
            // rbShoes
            // 
            this.rbShoes.AutoSize = true;
            this.rbShoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbShoes.Location = new System.Drawing.Point(667, 337);
            this.rbShoes.Margin = new System.Windows.Forms.Padding(4);
            this.rbShoes.Name = "rbShoes";
            this.rbShoes.Size = new System.Drawing.Size(80, 23);
            this.rbShoes.TabIndex = 0;
            this.rbShoes.Text = "Shoes";
            this.rbShoes.UseVisualStyleBackColor = true;
            this.rbShoes.CheckedChanged += new System.EventHandler(this.rbShoes_CheckedChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Black;
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Miriam Mono CLM", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(537, 425);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(114, 35);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.Black;
            this.btnBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Miriam Mono CLM", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Location = new System.Drawing.Point(537, 468);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(114, 35);
            this.btnBuy.TabIndex = 5;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
            // 
            // lbOrder
            // 
            this.lbOrder.AutoSize = true;
            this.lbOrder.Font = new System.Drawing.Font("Miriam Mono CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbOrder.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbOrder.Location = new System.Drawing.Point(214, 425);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(0, 22);
            this.lbOrder.TabIndex = 12;
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = global::CommandPattern.Properties.Resources.close;
            this.pbClose.Location = new System.Drawing.Point(814, 12);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(28, 26);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 13;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pbShoes
            // 
            this.pbShoes.Image = global::CommandPattern.Properties.Resources.shoes;
            this.pbShoes.Location = new System.Drawing.Point(610, 115);
            this.pbShoes.Name = "pbShoes";
            this.pbShoes.Size = new System.Drawing.Size(187, 204);
            this.pbShoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShoes.TabIndex = 8;
            this.pbShoes.TabStop = false;
            // 
            // pbTshirt
            // 
            this.pbTshirt.Image = global::CommandPattern.Properties.Resources.tshirt;
            this.pbTshirt.Location = new System.Drawing.Point(327, 115);
            this.pbTshirt.Name = "pbTshirt";
            this.pbTshirt.Size = new System.Drawing.Size(187, 204);
            this.pbTshirt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTshirt.TabIndex = 7;
            this.pbTshirt.TabStop = false;
            // 
            // pbPants
            // 
            this.pbPants.Image = global::CommandPattern.Properties.Resources.pants;
            this.pbPants.Location = new System.Drawing.Point(46, 115);
            this.pbPants.Name = "pbPants";
            this.pbPants.Size = new System.Drawing.Size(187, 204);
            this.pbPants.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPants.TabIndex = 6;
            this.pbPants.TabStop = false;
            // 
            // lbBuy
            // 
            this.lbBuy.AutoSize = true;
            this.lbBuy.Font = new System.Drawing.Font("Miriam Mono CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbBuy.Location = new System.Drawing.Point(214, 481);
            this.lbBuy.Name = "lbBuy";
            this.lbBuy.Size = new System.Drawing.Size(0, 22);
            this.lbBuy.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miriam Mono CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(199, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Please select a product to order and then buy it.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 532);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBuy);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.lbOrder);
            this.Controls.Add(this.pbShoes);
            this.Controls.Add(this.pbTshirt);
            this.Controls.Add(this.pbPants);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.rbShoes);
            this.Controls.Add(this.rbPants);
            this.Controls.Add(this.rbTshirt);
            this.Font = new System.Drawing.Font("Miriam Mono CLM", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTshirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbTshirt;
        private System.Windows.Forms.RadioButton rbPants;
        private System.Windows.Forms.RadioButton rbShoes;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.PictureBox pbPants;
        private System.Windows.Forms.PictureBox pbTshirt;
        private System.Windows.Forms.PictureBox pbShoes;
        private System.Windows.Forms.Label lbOrder;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label lbBuy;
        private System.Windows.Forms.Label label1;
    }
}

