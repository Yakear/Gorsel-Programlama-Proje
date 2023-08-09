namespace _212106053_Yekta_Alpagan_İO
{
    partial class Slot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Slot));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.JetonSayisiEtiket1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CasinoEtiket = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(183, 144);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 81);
            this.button2.TabIndex = 9;
            this.button2.Text = "Oyna";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(59, 144);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 81);
            this.button1.TabIndex = 8;
            this.button1.Text = "Para Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // JetonSayisiEtiket1
            // 
            this.JetonSayisiEtiket1.Location = new System.Drawing.Point(59, 116);
            this.JetonSayisiEtiket1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JetonSayisiEtiket1.Name = "JetonSayisiEtiket1";
            this.JetonSayisiEtiket1.Size = new System.Drawing.Size(220, 22);
            this.JetonSayisiEtiket1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(109, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Jeton Sayısı";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CasinoEtiket
            // 
            this.CasinoEtiket.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CasinoEtiket.Location = new System.Drawing.Point(63, 26);
            this.CasinoEtiket.Name = "CasinoEtiket";
            this.CasinoEtiket.Size = new System.Drawing.Size(200, 49);
            this.CasinoEtiket.TabIndex = 5;
            this.CasinoEtiket.Text = "Casino";
            this.CasinoEtiket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CasinoEtiket.Click += new System.EventHandler(this.CasinoEtiket_Click);
            // 
            // Slot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(340, 276);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.JetonSayisiEtiket1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CasinoEtiket);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Slot";
            this.Text = "Slot Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox JetonSayisiEtiket1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CasinoEtiket;
    }
}