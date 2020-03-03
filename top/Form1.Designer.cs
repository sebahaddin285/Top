namespace top
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.top = new System.Windows.Forms.PictureBox();
            this.cubuk = new System.Windows.Forms.Label();
            this.timer_sure = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.top)).BeginInit();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.Image = ((System.Drawing.Image)(resources.GetObject("top.Image")));
            this.top.Location = new System.Drawing.Point(289, 219);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(49, 35);
            this.top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.top.TabIndex = 0;
            this.top.TabStop = false;
            // 
            // cubuk
            // 
            this.cubuk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cubuk.Location = new System.Drawing.Point(242, 267);
            this.cubuk.Name = "cubuk";
            this.cubuk.Size = new System.Drawing.Size(141, 19);
            this.cubuk.TabIndex = 1;
            // 
            // timer_sure
            // 
            this.timer_sure.Interval = 50;
            this.timer_sure.Tick += new System.EventHandler(this.timer_sure_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 404);
            this.Controls.Add(this.cubuk);
            this.Controls.Add(this.top);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.top)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox top;
        private System.Windows.Forms.Label cubuk;
        private System.Windows.Forms.Timer timer_sure;
    }
}

