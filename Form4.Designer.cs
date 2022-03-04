
namespace instawapi1
{
    partial class Form4
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.profil = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hesapgizlimi = new System.Windows.Forms.Label();
            this.takipettikleri = new System.Windows.Forms.Label();
            this.takipcisayisi = new System.Windows.Forms.Label();
            this.kadi = new System.Windows.Forms.Label();
            this.lood = new System.Windows.Forms.PictureBox();
            this.kullanicinintakipcileri = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saniyebekle = new System.Windows.Forms.NumericUpDown();
            this.takipcisienaz = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profil)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lood)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saniyebekle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takipcisienaz)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(14, 305);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(341, 160);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "GETİR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // profil
            // 
            this.profil.Location = new System.Drawing.Point(17, 23);
            this.profil.Name = "profil";
            this.profil.Size = new System.Drawing.Size(155, 134);
            this.profil.TabIndex = 4;
            this.profil.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hesapgizlimi);
            this.groupBox1.Controls.Add(this.takipettikleri);
            this.groupBox1.Controls.Add(this.takipcisayisi);
            this.groupBox1.Controls.Add(this.kadi);
            this.groupBox1.Controls.Add(this.profil);
            this.groupBox1.Location = new System.Drawing.Point(15, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 172);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // hesapgizlimi
            // 
            this.hesapgizlimi.AutoSize = true;
            this.hesapgizlimi.Location = new System.Drawing.Point(179, 73);
            this.hesapgizlimi.Name = "hesapgizlimi";
            this.hesapgizlimi.Size = new System.Drawing.Size(46, 17);
            this.hesapgizlimi.TabIndex = 8;
            this.hesapgizlimi.Text = "label2";
            // 
            // takipettikleri
            // 
            this.takipettikleri.AutoSize = true;
            this.takipettikleri.Location = new System.Drawing.Point(179, 57);
            this.takipettikleri.Name = "takipettikleri";
            this.takipettikleri.Size = new System.Drawing.Size(46, 17);
            this.takipettikleri.TabIndex = 7;
            this.takipettikleri.Text = "label2";
            // 
            // takipcisayisi
            // 
            this.takipcisayisi.AutoSize = true;
            this.takipcisayisi.Location = new System.Drawing.Point(179, 41);
            this.takipcisayisi.Name = "takipcisayisi";
            this.takipcisayisi.Size = new System.Drawing.Size(46, 17);
            this.takipcisayisi.TabIndex = 6;
            this.takipcisayisi.Text = "label2";
            // 
            // kadi
            // 
            this.kadi.AutoSize = true;
            this.kadi.Location = new System.Drawing.Point(179, 25);
            this.kadi.Name = "kadi";
            this.kadi.Size = new System.Drawing.Size(46, 17);
            this.kadi.TabIndex = 5;
            this.kadi.Text = "label2";
            // 
            // lood
            // 
            this.lood.Location = new System.Drawing.Point(211, 21);
            this.lood.Name = "lood";
            this.lood.Size = new System.Drawing.Size(144, 90);
            this.lood.TabIndex = 9;
            this.lood.TabStop = false;
            this.lood.Click += new System.EventHandler(this.lood_Click);
            // 
            // kullanicinintakipcileri
            // 
            this.kullanicinintakipcileri.HideSelection = false;
            this.kullanicinintakipcileri.Location = new System.Drawing.Point(378, 13);
            this.kullanicinintakipcileri.Name = "kullanicinintakipcileri";
            this.kullanicinintakipcileri.Size = new System.Drawing.Size(325, 443);
            this.kullanicinintakipcileri.TabIndex = 10;
            this.kullanicinintakipcileri.UseCompatibleStateImageBehavior = false;
            this.kullanicinintakipcileri.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saniyebekle);
            this.groupBox2.Controls.Add(this.takipcisienaz);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(711, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 444);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // saniyebekle
            // 
            this.saniyebekle.Location = new System.Drawing.Point(221, 80);
            this.saniyebekle.Name = "saniyebekle";
            this.saniyebekle.Size = new System.Drawing.Size(59, 22);
            this.saniyebekle.TabIndex = 8;
            // 
            // takipcisienaz
            // 
            this.takipcisienaz.Location = new System.Drawing.Point(131, 51);
            this.takipcisienaz.Name = "takipcisienaz";
            this.takipcisienaz.Size = new System.Drawing.Size(73, 22);
            this.takipcisienaz.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Her işlemden sonra saniye bekle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "den takip et";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Takipçisi büyükse";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(177, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Gizli Hesapları Takip Et";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 145);
            this.button2.TabIndex = 0;
            this.button2.Text = "TAKİP ET";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 480);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.kullanicinintakipcileri);
            this.Controls.Add(this.lood);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Name = "Form4";
            this.Text = "KULLANICININ TAKİPÇİLERİNİ TAKİP ET";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profil)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lood)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saniyebekle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takipcisienaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox profil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label hesapgizlimi;
        private System.Windows.Forms.Label takipettikleri;
        private System.Windows.Forms.Label takipcisayisi;
        private System.Windows.Forms.Label kadi;
        private System.Windows.Forms.PictureBox lood;
        private System.Windows.Forms.ListView kullanicinintakipcileri;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown saniyebekle;
        private System.Windows.Forms.NumericUpDown takipcisienaz;
        private System.Windows.Forms.Label label4;
    }
}