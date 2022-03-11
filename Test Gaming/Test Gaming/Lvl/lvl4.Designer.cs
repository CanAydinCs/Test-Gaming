namespace Test_Gaming.Lvl
{
    partial class lvl4
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblisim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(-8, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(811, 63);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(584, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 203);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(584, -10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 103);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(563, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 45);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(563, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 45);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label6.Location = new System.Drawing.Point(21, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 46);
            this.label6.TabIndex = 5;
            this.label6.Text = "Karşıya Geç";
            // 
            // lblisim
            // 
            this.lblisim.AutoSize = true;
            this.lblisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblisim.Location = new System.Drawing.Point(23, 112);
            this.lblisim.Name = "lblisim";
            this.lblisim.Size = new System.Drawing.Size(23, 25);
            this.lblisim.TabIndex = 6;
            this.lblisim.Text = "0";
            this.lblisim.LocationChanged += new System.EventHandler(this.lblisim_LocationChanged);
            // 
            // lvl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblisim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "lvl4";
            this.ShowIcon = false;
            this.Text = "Bölüm 3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lvl4_FormClosing);
            this.Load += new System.EventHandler(this.lvl4_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvl4_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblisim;
    }
}