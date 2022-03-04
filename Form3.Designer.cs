
namespace instawapi1
{
    partial class Form3
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
            this.profil = new System.Windows.Forms.PictureBox();
            this.main = new System.Windows.Forms.Panel();
            this.bio = new System.Windows.Forms.Label();
            this.kadi = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profil)).BeginInit();
            this.main.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(14, 16);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(434, 365);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // profil
            // 
            this.profil.Location = new System.Drawing.Point(21, 21);
            this.profil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.profil.Name = "profil";
            this.profil.Size = new System.Drawing.Size(200, 183);
            this.profil.TabIndex = 1;
            this.profil.TabStop = false;
            this.profil.Click += new System.EventHandler(this.profil_Click);
            // 
            // main
            // 
            this.main.Controls.Add(this.bio);
            this.main.Controls.Add(this.kadi);
            this.main.Controls.Add(this.button1);
            this.main.Controls.Add(this.profil);
            this.main.Location = new System.Drawing.Point(455, 16);
            this.main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(378, 367);
            this.main.TabIndex = 2;
            this.main.Visible = false;
            // 
            // bio
            // 
            this.bio.AutoSize = true;
            this.bio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bio.Location = new System.Drawing.Point(21, 255);
            this.bio.Name = "bio";
            this.bio.Size = new System.Drawing.Size(93, 20);
            this.bio.TabIndex = 6;
            this.bio.Text = "Yükleniyor...";
            // 
            // kadi
            // 
            this.kadi.AutoSize = true;
            this.kadi.Location = new System.Drawing.Point(21, 223);
            this.kadi.Name = "kadi";
            this.kadi.Size = new System.Drawing.Size(86, 20);
            this.kadi.TabIndex = 3;
            this.kadi.Text = "Yükleniyor...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 317);
            this.button1.TabIndex = 2;
            this.button1.Text = "Engelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 392);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(819, 89);
            this.button2.TabIndex = 3;
            this.button2.Text = "Listeyi yenile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 491);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.main);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.Text = "Takipçilerim";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profil)).EndInit();
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox profil;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.Label bio;
        private System.Windows.Forms.Label kadi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}