
namespace MyLinkLabel_form
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.mylinklabel3 = new MyLinkLabel_form.mylinklabel();
            this.mylinklabel2 = new MyLinkLabel_form.mylinklabel();
            this.mylinklabel1 = new MyLinkLabel_form.mylinklabel();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(546, 101);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(641, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // mylinklabel3
            // 
            this.mylinklabel3.ActiveLinkColor = System.Drawing.Color.Red;
            this.mylinklabel3.AutoSize = true;
            this.mylinklabel3.BackColor = System.Drawing.Color.Transparent;
            this.mylinklabel3.DisabledLinkColor = System.Drawing.Color.Empty;
            this.mylinklabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
            this.mylinklabel3.ForeColor = System.Drawing.Color.Blue;
            this.mylinklabel3.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.mylinklabel3.LinkColor = System.Drawing.Color.Empty;
            this.mylinklabel3.Location = new System.Drawing.Point(448, 101);
            this.mylinklabel3.Name = "mylinklabel3";
            this.mylinklabel3.Size = new System.Drawing.Size(64, 13);
            this.mylinklabel3.TabIndex = 6;
            this.mylinklabel3.Text = "mylinklabel3";
            this.mylinklabel3.VisitedLinkColor = System.Drawing.Color.Empty;
            // 
            // mylinklabel2
            // 
            this.mylinklabel2.ActiveLinkColor = System.Drawing.Color.ForestGreen;
            this.mylinklabel2.AutoSize = true;
            this.mylinklabel2.BackColor = System.Drawing.Color.Transparent;
            this.mylinklabel2.DisabledLinkColor = System.Drawing.Color.Empty;
            this.mylinklabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mylinklabel2.ForeColor = System.Drawing.Color.Blue;
            this.mylinklabel2.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.mylinklabel2.LinkColor = System.Drawing.Color.Empty;
            this.mylinklabel2.Location = new System.Drawing.Point(306, 94);
            this.mylinklabel2.Name = "mylinklabel2";
            this.mylinklabel2.Size = new System.Drawing.Size(106, 20);
            this.mylinklabel2.TabIndex = 4;
            this.mylinklabel2.Text = "mylinklabel2";
            this.mylinklabel2.VisitedLinkColor = System.Drawing.Color.Empty;
            this.mylinklabel2.Click += new System.EventHandler(this.mylinklabel2_Click);
            // 
            // mylinklabel1
            // 
            this.mylinklabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mylinklabel1.AutoSize = true;
            this.mylinklabel1.BackColor = System.Drawing.Color.Transparent;
            this.mylinklabel1.DisabledLinkColor = System.Drawing.Color.Empty;
            this.mylinklabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mylinklabel1.ForeColor = System.Drawing.Color.Blue;
            this.mylinklabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.mylinklabel1.LinkColor = System.Drawing.Color.Fuchsia;
            this.mylinklabel1.Location = new System.Drawing.Point(105, 87);
            this.mylinklabel1.Name = "mylinklabel1";
            this.mylinklabel1.Size = new System.Drawing.Size(143, 25);
            this.mylinklabel1.TabIndex = 3;
            this.mylinklabel1.Text = "mylinklabel1";
            this.mylinklabel1.VisitedLinkColor = System.Drawing.Color.Empty;
            this.mylinklabel1.Click += new System.EventHandler(this.mylinklabel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mylinklabel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mylinklabel2);
            this.Controls.Add(this.mylinklabel1);
            this.Controls.Add(this.linkLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private mylinklabel mylinklabel1;
        private mylinklabel mylinklabel2;
        private System.Windows.Forms.Label label1;
        private mylinklabel mylinklabel3;
    }
}

