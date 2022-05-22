
namespace Bukutachi
{
    partial class HomeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeAdmin));
            this.pnTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btClose = new Guna.UI2.WinForms.Guna2Button();
            this.lbHello = new System.Windows.Forms.Label();
            this.pnMain = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btCrystalReport = new Guna.UI2.WinForms.Guna2Button();
            this.btLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btAddBuku = new Guna.UI2.WinForms.Guna2Button();
            this.btBorrowed = new Guna.UI2.WinForms.Guna2Button();
            this.btBooks = new Guna.UI2.WinForms.Guna2Button();
            this.btHome = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitleBar
            // 
            this.pnTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnTitleBar.Controls.Add(this.label1);
            this.pnTitleBar.Controls.Add(this.guna2PictureBox1);
            this.pnTitleBar.Controls.Add(this.btMinimize);
            this.pnTitleBar.Controls.Add(this.btClose);
            this.pnTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnTitleBar.Name = "pnTitleBar";
            this.pnTitleBar.Size = new System.Drawing.Size(1000, 33);
            this.pnTitleBar.TabIndex = 4;
            this.pnTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitleBar_MouseDown);
            this.pnTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTitleBar_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Bukutachi - Admin";
            // 
            // btMinimize
            // 
            this.btMinimize.BorderRadius = 10;
            this.btMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(156)))), ((int)(((byte)(70)))));
            this.btMinimize.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinimize.ForeColor = System.Drawing.Color.White;
            this.btMinimize.Location = new System.Drawing.Point(942, 8);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(20, 20);
            this.btMinimize.TabIndex = 1;
            this.btMinimize.Text = "X";
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))));
            this.btClose.BorderRadius = 10;
            this.btClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btClose.Font = new System.Drawing.Font("Sitka Text", 3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.White;
            this.btClose.Location = new System.Drawing.Point(968, 8);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(20, 20);
            this.btClose.TabIndex = 0;
            this.btClose.Text = "X";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // lbHello
            // 
            this.lbHello.AutoSize = true;
            this.lbHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHello.ForeColor = System.Drawing.Color.White;
            this.lbHello.Location = new System.Drawing.Point(754, 41);
            this.lbHello.Name = "lbHello";
            this.lbHello.Size = new System.Drawing.Size(55, 20);
            this.lbHello.TabIndex = 5;
            this.lbHello.Text = "Hello,";
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.pnMain.Location = new System.Drawing.Point(212, 68);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(765, 560);
            this.pnMain.TabIndex = 6;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.pnMain;
            // 
            // btCrystalReport
            // 
            this.btCrystalReport.BorderRadius = 10;
            this.btCrystalReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCrystalReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCrystalReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCrystalReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCrystalReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btCrystalReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCrystalReport.ForeColor = System.Drawing.Color.White;
            this.btCrystalReport.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btCrystalReport.Image = global::Bukutachi.Properties.Resources.crystalreport_removebg_preview__1_;
            this.btCrystalReport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btCrystalReport.ImageOffset = new System.Drawing.Point(0, -1);
            this.btCrystalReport.ImageSize = new System.Drawing.Size(28, 28);
            this.btCrystalReport.Location = new System.Drawing.Point(15, 380);
            this.btCrystalReport.Name = "btCrystalReport";
            this.btCrystalReport.Size = new System.Drawing.Size(180, 50);
            this.btCrystalReport.TabIndex = 18;
            this.btCrystalReport.Text = "Report";
            this.btCrystalReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btCrystalReport.Click += new System.EventHandler(this.btCrystalReport_Click);
            // 
            // btLogout
            // 
            this.btLogout.BorderRadius = 10;
            this.btLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.ForeColor = System.Drawing.Color.White;
            this.btLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btLogout.Image = ((System.Drawing.Image)(resources.GetObject("btLogout.Image")));
            this.btLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btLogout.ImageOffset = new System.Drawing.Point(0, -1);
            this.btLogout.ImageSize = new System.Drawing.Size(28, 28);
            this.btLogout.Location = new System.Drawing.Point(15, 578);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(180, 50);
            this.btLogout.TabIndex = 17;
            this.btLogout.Text = "Logout";
            this.btLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btUsers
            // 
            this.btUsers.BorderRadius = 10;
            this.btUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUsers.ForeColor = System.Drawing.Color.White;
            this.btUsers.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btUsers.Image = ((System.Drawing.Image)(resources.GetObject("btUsers.Image")));
            this.btUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btUsers.ImageOffset = new System.Drawing.Point(0, -1);
            this.btUsers.ImageSize = new System.Drawing.Size(28, 28);
            this.btUsers.Location = new System.Drawing.Point(15, 320);
            this.btUsers.Name = "btUsers";
            this.btUsers.Size = new System.Drawing.Size(180, 50);
            this.btUsers.TabIndex = 16;
            this.btUsers.Text = "Users";
            this.btUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btUsers.Click += new System.EventHandler(this.btUsers_Click);
            // 
            // btAddBuku
            // 
            this.btAddBuku.BorderRadius = 10;
            this.btAddBuku.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAddBuku.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAddBuku.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAddBuku.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAddBuku.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btAddBuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddBuku.ForeColor = System.Drawing.Color.White;
            this.btAddBuku.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btAddBuku.Image = ((System.Drawing.Image)(resources.GetObject("btAddBuku.Image")));
            this.btAddBuku.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btAddBuku.ImageOffset = new System.Drawing.Point(0, -1);
            this.btAddBuku.ImageSize = new System.Drawing.Size(28, 28);
            this.btAddBuku.Location = new System.Drawing.Point(15, 260);
            this.btAddBuku.Name = "btAddBuku";
            this.btAddBuku.Size = new System.Drawing.Size(180, 50);
            this.btAddBuku.TabIndex = 15;
            this.btAddBuku.Text = "Add Buku";
            this.btAddBuku.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btAddBuku.Click += new System.EventHandler(this.btAddBuku_Click);
            // 
            // btBorrowed
            // 
            this.btBorrowed.BorderRadius = 10;
            this.btBorrowed.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btBorrowed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btBorrowed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btBorrowed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btBorrowed.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrowed.ForeColor = System.Drawing.Color.White;
            this.btBorrowed.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btBorrowed.Image = ((System.Drawing.Image)(resources.GetObject("btBorrowed.Image")));
            this.btBorrowed.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btBorrowed.ImageOffset = new System.Drawing.Point(0, -1);
            this.btBorrowed.ImageSize = new System.Drawing.Size(28, 28);
            this.btBorrowed.Location = new System.Drawing.Point(15, 200);
            this.btBorrowed.Name = "btBorrowed";
            this.btBorrowed.Size = new System.Drawing.Size(180, 50);
            this.btBorrowed.TabIndex = 14;
            this.btBorrowed.Text = "Borrowed";
            this.btBorrowed.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btBorrowed.Click += new System.EventHandler(this.btBorrowed_Click);
            // 
            // btBooks
            // 
            this.btBooks.BorderRadius = 10;
            this.btBooks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btBooks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btBooks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btBooks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btBooks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBooks.ForeColor = System.Drawing.Color.White;
            this.btBooks.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btBooks.Image = ((System.Drawing.Image)(resources.GetObject("btBooks.Image")));
            this.btBooks.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btBooks.ImageOffset = new System.Drawing.Point(0, -1);
            this.btBooks.ImageSize = new System.Drawing.Size(28, 28);
            this.btBooks.Location = new System.Drawing.Point(15, 140);
            this.btBooks.Name = "btBooks";
            this.btBooks.Size = new System.Drawing.Size(180, 50);
            this.btBooks.TabIndex = 13;
            this.btBooks.Text = "Books";
            this.btBooks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btBooks.Click += new System.EventHandler(this.btBooks_Click);
            // 
            // btHome
            // 
            this.btHome.BorderRadius = 10;
            this.btHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.ForeColor = System.Drawing.Color.White;
            this.btHome.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btHome.Image = ((System.Drawing.Image)(resources.GetObject("btHome.Image")));
            this.btHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btHome.ImageOffset = new System.Drawing.Point(0, -1);
            this.btHome.ImageSize = new System.Drawing.Size(28, 28);
            this.btHome.Location = new System.Drawing.Point(15, 80);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(180, 50);
            this.btHome.TabIndex = 12;
            this.btHome.Text = "Home";
            this.btHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(5, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(25, 25);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 18;
            this.guna2PictureBox1.TabStop = false;
            // 
            // HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.btCrystalReport);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btUsers);
            this.Controls.Add(this.btAddBuku);
            this.Controls.Add(this.btBorrowed);
            this.Controls.Add(this.btBooks);
            this.Controls.Add(this.btHome);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.lbHello);
            this.Controls.Add(this.pnTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeAdmin_Load);
            this.pnTitleBar.ResumeLayout(false);
            this.pnTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTitleBar;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btMinimize;
        private Guna.UI2.WinForms.Guna2Button btClose;
        private System.Windows.Forms.Label lbHello;
        private System.Windows.Forms.Panel pnMain;
        private Guna.UI2.WinForms.Guna2Button btLogout;
        private Guna.UI2.WinForms.Guna2Button btUsers;
        private Guna.UI2.WinForms.Guna2Button btAddBuku;
        private Guna.UI2.WinForms.Guna2Button btBorrowed;
        private Guna.UI2.WinForms.Guna2Button btBooks;
        private Guna.UI2.WinForms.Guna2Button btHome;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btCrystalReport;
    }
}