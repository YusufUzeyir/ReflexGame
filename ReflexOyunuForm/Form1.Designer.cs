//bu kod YUSUF ÜZEYİR KAYA tarafından yazılmıştır.
namespace ReflexOyunuForm
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
            this.lblYukarı = new System.Windows.Forms.Label();
            this.lblAşağı = new System.Windows.Forms.Label();
            this.lblSol = new System.Windows.Forms.Label();
            this.lblSağ = new System.Windows.Forms.Label();
            this.lblOrta = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.PrograssBar = new System.Windows.Forms.ProgressBar();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblSkor2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSüre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblYukarı
            // 
            this.lblYukarı.AutoSize = true;
            this.lblYukarı.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYukarı.ForeColor = System.Drawing.Color.Gray;
            this.lblYukarı.Location = new System.Drawing.Point(414, -10);
            this.lblYukarı.Name = "lblYukarı";
            this.lblYukarı.Size = new System.Drawing.Size(204, 226);
            this.lblYukarı.TabIndex = 0;
            this.lblYukarı.Text = "⇧";
            this.lblYukarı.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAşağı
            // 
            this.lblAşağı.AutoSize = true;
            this.lblAşağı.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAşağı.ForeColor = System.Drawing.Color.Gray;
            this.lblAşağı.Location = new System.Drawing.Point(414, 342);
            this.lblAşağı.Name = "lblAşağı";
            this.lblAşağı.Size = new System.Drawing.Size(204, 226);
            this.lblAşağı.TabIndex = 1;
            this.lblAşağı.Text = "⇩";
            this.lblAşağı.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSol
            // 
            this.lblSol.AutoSize = true;
            this.lblSol.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSol.ForeColor = System.Drawing.Color.Gray;
            this.lblSol.Location = new System.Drawing.Point(186, 142);
            this.lblSol.Name = "lblSol";
            this.lblSol.Size = new System.Drawing.Size(235, 226);
            this.lblSol.TabIndex = 3;
            this.lblSol.Text = "⇦";
            this.lblSol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSağ
            // 
            this.lblSağ.AutoSize = true;
            this.lblSağ.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSağ.ForeColor = System.Drawing.Color.Gray;
            this.lblSağ.Location = new System.Drawing.Point(624, 142);
            this.lblSağ.Name = "lblSağ";
            this.lblSağ.Size = new System.Drawing.Size(235, 226);
            this.lblSağ.TabIndex = 4;
            this.lblSağ.Text = "⇨";
            this.lblSağ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrta
            // 
            this.lblOrta.AutoSize = true;
            this.lblOrta.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrta.Location = new System.Drawing.Point(458, 230);
            this.lblOrta.Name = "lblOrta";
            this.lblOrta.Size = new System.Drawing.Size(0, 60);
            this.lblOrta.TabIndex = 5;
            this.lblOrta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBaslat.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.ForeColor = System.Drawing.Color.Maroon;
            this.btnBaslat.Location = new System.Drawing.Point(25, 30);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(160, 69);
            this.btnBaslat.TabIndex = 6;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // PrograssBar
            // 
            this.PrograssBar.Location = new System.Drawing.Point(696, 38);
            this.PrograssBar.Name = "PrograssBar";
            this.PrograssBar.Size = new System.Drawing.Size(287, 23);
            this.PrograssBar.TabIndex = 7;
            this.PrograssBar.Value = 100;
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor.Location = new System.Drawing.Point(30, 128);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(68, 29);
            this.lblSkor.TabIndex = 8;
            this.lblSkor.Text = "Skor:";
            // 
            // lblSkor2
            // 
            this.lblSkor2.AutoSize = true;
            this.lblSkor2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor2.Location = new System.Drawing.Point(93, 130);
            this.lblSkor2.Name = "lblSkor2";
            this.lblSkor2.Size = new System.Drawing.Size(25, 29);
            this.lblSkor2.TabIndex = 9;
            this.lblSkor2.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSüre
            // 
            this.lblSüre.AutoSize = true;
            this.lblSüre.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSüre.Location = new System.Drawing.Point(693, 6);
            this.lblSüre.Name = "lblSüre";
            this.lblSüre.Size = new System.Drawing.Size(58, 29);
            this.lblSüre.TabIndex = 10;
            this.lblSüre.Text = "Süre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 587);
            this.Controls.Add(this.lblSüre);
            this.Controls.Add(this.lblSkor2);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.PrograssBar);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.lblOrta);
            this.Controls.Add(this.lblSağ);
            this.Controls.Add(this.lblSol);
            this.Controls.Add(this.lblAşağı);
            this.Controls.Add(this.lblYukarı);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reflex Game";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_Press_Up);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYukarı;
        private System.Windows.Forms.Label lblAşağı;
        private System.Windows.Forms.Label lblSol;
        private System.Windows.Forms.Label lblSağ;
        private System.Windows.Forms.Label lblOrta;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.ProgressBar PrograssBar;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblSkor2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSüre;
    }
}

