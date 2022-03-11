namespace Test_Gaming.Lvl
{
    partial class lvl2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblblg = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblisim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilgisayardan Daha Hızlı Olduğunu Kanıtla!!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(0, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(801, 67);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label3.Location = new System.Drawing.Point(0, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(801, 59);
            this.label3.TabIndex = 2;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 453);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(175, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 386);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(762, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 453);
            this.label6.TabIndex = 5;
            this.label6.Text = "B\r\nİ\r\nT\r\nİ\r\nŞ\r\n\r\nÇ\r\nİ\r\nZ\r\nG\r\nİ\r\nS\r\nİ\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblblg
            // 
            this.lblblg.AutoSize = true;
            this.lblblg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblblg.Location = new System.Drawing.Point(51, 329);
            this.lblblg.Name = "lblblg";
            this.lblblg.Size = new System.Drawing.Size(96, 25);
            this.lblblg.TabIndex = 6;
            this.lblblg.Text = "Bilgisayar";
            this.lblblg.LocationChanged += new System.EventHandler(this.lblblg_LocationChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblisim
            // 
            this.lblisim.AutoSize = true;
            this.lblisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblisim.Location = new System.Drawing.Point(85, 97);
            this.lblisim.Name = "lblisim";
            this.lblisim.Size = new System.Drawing.Size(23, 25);
            this.lblisim.TabIndex = 8;
            this.lblisim.Text = "0";
            this.lblisim.LocationChanged += new System.EventHandler(this.lblisim_LocationChanged);
            // 
            // lvl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblisim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblblg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "lvl2";
            this.ShowIcon = false;
            this.Text = "Bölüm 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lvl2_FormClosing);
            this.Load += new System.EventHandler(this.lvl2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvl2_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblblg;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblisim;
    }
}