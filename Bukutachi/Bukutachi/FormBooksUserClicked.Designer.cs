
namespace Bukutachi
{
    partial class FormBooksUserClicked
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
            this.lbBack = new System.Windows.Forms.Label();
            this.pnSynopsis = new Guna.UI2.WinForms.Guna2Panel();
            this.btPinjam = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbAvailable = new System.Windows.Forms.Label();
            this.pnBuku = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbL = new System.Windows.Forms.Label();
            this.lbPD = new System.Windows.Forms.Label();
            this.lbP = new System.Windows.Forms.Label();
            this.lbG = new System.Windows.Forms.Label();
            this.lbA = new System.Windows.Forms.Label();
            this.lbBT = new System.Windows.Forms.Label();
            this.lbBookTitle = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbPublisher = new System.Windows.Forms.Label();
            this.lbPublishDate = new System.Windows.Forms.Label();
            this.lbLocation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnSynopsis.SuspendLayout();
            this.pnBuku.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBack
            // 
            this.lbBack.AutoSize = true;
            this.lbBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBack.ForeColor = System.Drawing.Color.White;
            this.lbBack.Location = new System.Drawing.Point(13, 13);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(139, 18);
            this.lbBack.TabIndex = 7;
            this.lbBack.Text = "< Back to Search";
            // 
            // pnSynopsis
            // 
            this.pnSynopsis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.pnSynopsis.Controls.Add(this.label9);
            this.pnSynopsis.Controls.Add(this.label2);
            this.pnSynopsis.Location = new System.Drawing.Point(16, 279);
            this.pnSynopsis.Name = "pnSynopsis";
            this.pnSynopsis.Size = new System.Drawing.Size(737, 209);
            this.pnSynopsis.TabIndex = 8;
            // 
            // btPinjam
            // 
            this.btPinjam.BorderRadius = 5;
            this.btPinjam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btPinjam.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(194)))));
            this.btPinjam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(194)))));
            this.btPinjam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btPinjam.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(194)))));
            this.btPinjam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPinjam.ForeColor = System.Drawing.Color.White;
            this.btPinjam.Location = new System.Drawing.Point(629, 512);
            this.btPinjam.Name = "btPinjam";
            this.btPinjam.Size = new System.Drawing.Size(124, 31);
            this.btPinjam.TabIndex = 19;
            this.btPinjam.Tag = "0";
            this.btPinjam.Text = "Pinjam";
            this.btPinjam.Click += new System.EventHandler(this.btAddBook_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.pnSynopsis;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Availability :";
            // 
            // lbAvailable
            // 
            this.lbAvailable.AutoSize = true;
            this.lbAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvailable.ForeColor = System.Drawing.Color.Lime;
            this.lbAvailable.Location = new System.Drawing.Point(141, 512);
            this.lbAvailable.Name = "lbAvailable";
            this.lbAvailable.Size = new System.Drawing.Size(81, 20);
            this.lbAvailable.TabIndex = 21;
            this.lbAvailable.Text = "Available";
            // 
            // pnBuku
            // 
            this.pnBuku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.pnBuku.Controls.Add(this.lbLocation);
            this.pnBuku.Controls.Add(this.lbPublishDate);
            this.pnBuku.Controls.Add(this.lbPublisher);
            this.pnBuku.Controls.Add(this.lbGenre);
            this.pnBuku.Controls.Add(this.lbAuthor);
            this.pnBuku.Controls.Add(this.lbBookTitle);
            this.pnBuku.Controls.Add(this.label8);
            this.pnBuku.Controls.Add(this.label7);
            this.pnBuku.Controls.Add(this.label5);
            this.pnBuku.Controls.Add(this.label3);
            this.pnBuku.Controls.Add(this.label4);
            this.pnBuku.Controls.Add(this.label6);
            this.pnBuku.Controls.Add(this.lbL);
            this.pnBuku.Controls.Add(this.lbPD);
            this.pnBuku.Controls.Add(this.lbP);
            this.pnBuku.Controls.Add(this.lbG);
            this.pnBuku.Controls.Add(this.lbA);
            this.pnBuku.Controls.Add(this.lbBT);
            this.pnBuku.Location = new System.Drawing.Point(273, 48);
            this.pnBuku.Name = "pnBuku";
            this.pnBuku.Size = new System.Drawing.Size(480, 209);
            this.pnBuku.TabIndex = 9;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(54, 48);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(148, 209);
            this.guna2PictureBox1.TabIndex = 22;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.pnBuku;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(128, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 18);
            this.label8.TabIndex = 52;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(128, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 18);
            this.label7.TabIndex = 51;
            this.label7.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(128, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 18);
            this.label5.TabIndex = 50;
            this.label5.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(128, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 18);
            this.label3.TabIndex = 49;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(128, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 18);
            this.label4.TabIndex = 48;
            this.label4.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(128, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 18);
            this.label6.TabIndex = 47;
            this.label6.Text = ":";
            // 
            // lbL
            // 
            this.lbL.AutoSize = true;
            this.lbL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbL.ForeColor = System.Drawing.Color.White;
            this.lbL.Location = new System.Drawing.Point(14, 180);
            this.lbL.Name = "lbL";
            this.lbL.Size = new System.Drawing.Size(73, 18);
            this.lbL.TabIndex = 46;
            this.lbL.Text = "Location";
            // 
            // lbPD
            // 
            this.lbPD.AutoSize = true;
            this.lbPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPD.ForeColor = System.Drawing.Color.White;
            this.lbPD.Location = new System.Drawing.Point(14, 148);
            this.lbPD.Name = "lbPD";
            this.lbPD.Size = new System.Drawing.Size(103, 18);
            this.lbPD.TabIndex = 45;
            this.lbPD.Text = "Publish Date";
            // 
            // lbP
            // 
            this.lbP.AutoSize = true;
            this.lbP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbP.ForeColor = System.Drawing.Color.White;
            this.lbP.Location = new System.Drawing.Point(14, 111);
            this.lbP.Name = "lbP";
            this.lbP.Size = new System.Drawing.Size(78, 18);
            this.lbP.TabIndex = 44;
            this.lbP.Text = "Publisher";
            // 
            // lbG
            // 
            this.lbG.AutoSize = true;
            this.lbG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbG.ForeColor = System.Drawing.Color.White;
            this.lbG.Location = new System.Drawing.Point(14, 76);
            this.lbG.Name = "lbG";
            this.lbG.Size = new System.Drawing.Size(54, 18);
            this.lbG.TabIndex = 43;
            this.lbG.Text = "Genre";
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.ForeColor = System.Drawing.Color.White;
            this.lbA.Location = new System.Drawing.Point(14, 41);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(57, 18);
            this.lbA.TabIndex = 42;
            this.lbA.Text = "Author";
            // 
            // lbBT
            // 
            this.lbBT.AutoSize = true;
            this.lbBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBT.ForeColor = System.Drawing.Color.White;
            this.lbBT.Location = new System.Drawing.Point(14, 7);
            this.lbBT.Name = "lbBT";
            this.lbBT.Size = new System.Drawing.Size(85, 18);
            this.lbBT.TabIndex = 41;
            this.lbBT.Text = "Book Title";
            // 
            // lbBookTitle
            // 
            this.lbBookTitle.AutoSize = true;
            this.lbBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookTitle.ForeColor = System.Drawing.Color.White;
            this.lbBookTitle.Location = new System.Drawing.Point(147, 7);
            this.lbBookTitle.Name = "lbBookTitle";
            this.lbBookTitle.Size = new System.Drawing.Size(14, 18);
            this.lbBookTitle.TabIndex = 53;
            this.lbBookTitle.Text = "-";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor.ForeColor = System.Drawing.Color.White;
            this.lbAuthor.Location = new System.Drawing.Point(147, 41);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(14, 18);
            this.lbAuthor.TabIndex = 54;
            this.lbAuthor.Text = "-";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenre.ForeColor = System.Drawing.Color.White;
            this.lbGenre.Location = new System.Drawing.Point(147, 76);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(14, 18);
            this.lbGenre.TabIndex = 55;
            this.lbGenre.Text = "-";
            // 
            // lbPublisher
            // 
            this.lbPublisher.AutoSize = true;
            this.lbPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPublisher.ForeColor = System.Drawing.Color.White;
            this.lbPublisher.Location = new System.Drawing.Point(147, 111);
            this.lbPublisher.Name = "lbPublisher";
            this.lbPublisher.Size = new System.Drawing.Size(14, 18);
            this.lbPublisher.TabIndex = 56;
            this.lbPublisher.Text = "-";
            // 
            // lbPublishDate
            // 
            this.lbPublishDate.AutoSize = true;
            this.lbPublishDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPublishDate.ForeColor = System.Drawing.Color.White;
            this.lbPublishDate.Location = new System.Drawing.Point(147, 148);
            this.lbPublishDate.Name = "lbPublishDate";
            this.lbPublishDate.Size = new System.Drawing.Size(14, 18);
            this.lbPublishDate.TabIndex = 57;
            this.lbPublishDate.Text = "-";
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocation.ForeColor = System.Drawing.Color.White;
            this.lbLocation.Location = new System.Drawing.Point(147, 180);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(14, 18);
            this.lbLocation.TabIndex = 58;
            this.lbLocation.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 47;
            this.label2.Text = "Description";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(17, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(701, 133);
            this.label9.TabIndex = 59;
            this.label9.Text = "Location";
            // 
            // FormBooksUserClicked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(765, 560);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.pnBuku);
            this.Controls.Add(this.lbAvailable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btPinjam);
            this.Controls.Add(this.pnSynopsis);
            this.Controls.Add(this.lbBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBooksUserClicked";
            this.Text = "FormBooksUserClicked";
            this.pnSynopsis.ResumeLayout(false);
            this.pnSynopsis.PerformLayout();
            this.pnBuku.ResumeLayout(false);
            this.pnBuku.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBack;
        private Guna.UI2.WinForms.Guna2Panel pnSynopsis;
        private Guna.UI2.WinForms.Guna2Button btPinjam;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAvailable;
        private Guna.UI2.WinForms.Guna2Panel pnBuku;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label lbPublishDate;
        private System.Windows.Forms.Label lbPublisher;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbBookTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbL;
        private System.Windows.Forms.Label lbPD;
        private System.Windows.Forms.Label lbP;
        private System.Windows.Forms.Label lbG;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbBT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
    }
}