﻿
namespace SigmaSinavSistemi
{
    partial class Sifre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sifre));
            this.btn_gonder = new System.Windows.Forms.Button();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_kod = new System.Windows.Forms.Label();
            this.txt_Onaykodu = new System.Windows.Forms.TextBox();
            this.btn_onayla = new System.Windows.Forms.Button();
            this.cmb_uzanti = new System.Windows.Forms.ComboBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_gonder
            // 
            this.btn_gonder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_gonder.Location = new System.Drawing.Point(151, 55);
            this.btn_gonder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_gonder.Name = "btn_gonder";
            this.btn_gonder.Size = new System.Drawing.Size(79, 22);
            this.btn_gonder.TabIndex = 6;
            this.btn_gonder.Text = "Gönder";
            this.btn_gonder.UseVisualStyleBackColor = true;
            this.btn_gonder.Click += new System.EventHandler(this.btn_gonder_Click);
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_mail.Location = new System.Drawing.Point(34, 29);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(74, 15);
            this.lbl_mail.TabIndex = 4;
            this.lbl_mail.Text = "Mail Adresi :";
            // 
            // lbl_kod
            // 
            this.lbl_kod.AutoSize = true;
            this.lbl_kod.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_kod.Location = new System.Drawing.Point(39, 92);
            this.lbl_kod.Name = "lbl_kod";
            this.lbl_kod.Size = new System.Drawing.Size(70, 15);
            this.lbl_kod.TabIndex = 4;
            this.lbl_kod.Text = "Onay Kodu:";
            // 
            // txt_Onaykodu
            // 
            this.txt_Onaykodu.Location = new System.Drawing.Point(121, 90);
            this.txt_Onaykodu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Onaykodu.Multiline = true;
            this.txt_Onaykodu.Name = "txt_Onaykodu";
            this.txt_Onaykodu.PlaceholderText = "Onay Kodu";
            this.txt_Onaykodu.Size = new System.Drawing.Size(133, 22);
            this.txt_Onaykodu.TabIndex = 5;
            // 
            // btn_onayla
            // 
            this.btn_onayla.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_onayla.Location = new System.Drawing.Point(151, 122);
            this.btn_onayla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_onayla.Name = "btn_onayla";
            this.btn_onayla.Size = new System.Drawing.Size(79, 22);
            this.btn_onayla.TabIndex = 8;
            this.btn_onayla.Text = "Onayla";
            this.btn_onayla.UseVisualStyleBackColor = true;
            this.btn_onayla.Click += new System.EventHandler(this.btn_onayla_Click);
            // 
            // cmb_uzanti
            // 
            this.cmb_uzanti.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_uzanti.FormattingEnabled = true;
            this.cmb_uzanti.Items.AddRange(new object[] {
            "@sigmatematik.com",
            "@hotmail.com",
            "@outlook.com",
            "@gmail.com"});
            this.cmb_uzanti.Location = new System.Drawing.Point(252, 26);
            this.cmb_uzanti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_uzanti.Name = "cmb_uzanti";
            this.cmb_uzanti.Size = new System.Drawing.Size(158, 23);
            this.cmb_uzanti.TabIndex = 10;
            this.cmb_uzanti.Text = "@sigmatematik.com";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(121, 26);
            this.txt_mail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mail.Multiline = true;
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.PlaceholderText = "Mail";
            this.txt_mail.Size = new System.Drawing.Size(133, 22);
            this.txt_mail.TabIndex = 9;
            // 
            // Sifre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(438, 165);
            this.Controls.Add(this.cmb_uzanti);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.btn_onayla);
            this.Controls.Add(this.btn_gonder);
            this.Controls.Add(this.txt_Onaykodu);
            this.Controls.Add(this.lbl_kod);
            this.Controls.Add(this.lbl_mail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sifre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sifre";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sifre_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Sifre_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_gonder;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_kod;
        private System.Windows.Forms.TextBox txt_Onaykodu;
        private System.Windows.Forms.Button btn_onayla;
        private System.Windows.Forms.ComboBox cmb_uzanti;
        private System.Windows.Forms.TextBox txt_mail;
    }
}