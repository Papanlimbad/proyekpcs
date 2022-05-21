
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeAdmin));
            this.pnTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btClose = new Guna.UI2.WinForms.Guna2Button();
            this.lbHelloAdmin = new System.Windows.Forms.Label();
            this.pnMain = new System.Windows.Forms.Panel();
            this.btEditUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btBorrowedAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.btAddBook = new Guna.UI2.WinForms.Guna2Button();
            this.btBooksAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.btHomeAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.btLogout = new Guna.UI2.WinForms.Guna2Button();
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
            // lbHelloAdmin
            // 
            this.lbHelloAdmin.AutoSize = true;
            this.lbHelloAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHelloAdmin.ForeColor = System.Drawing.Color.White;
            this.lbHelloAdmin.Location = new System.Drawing.Point(754, 41);
            this.lbHelloAdmin.Name = "lbHelloAdmin";
            this.lbHelloAdmin.Size = new System.Drawing.Size(55, 20);
            this.lbHelloAdmin.TabIndex = 5;
            this.lbHelloAdmin.Text = "Hello,";
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.pnMain.Location = new System.Drawing.Point(212, 68);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(765, 560);
            this.pnMain.TabIndex = 6;
            // 
            // btEditUsers
            // 
            this.btEditUsers.BorderRadius = 10;
            this.btEditUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btEditUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btEditUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btEditUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btEditUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btEditUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditUsers.ForeColor = System.Drawing.Color.White;
            this.btEditUsers.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btEditUsers.Image = ((System.Drawing.Image)(resources.GetObject("btEditUsers.Image")));
            this.btEditUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btEditUsers.ImageOffset = new System.Drawing.Point(0, -1);
            this.btEditUsers.ImageSize = new System.Drawing.Size(28, 28);
            this.btEditUsers.Location = new System.Drawing.Point(15, 320);
            this.btEditUsers.Name = "btEditUsers";
            this.btEditUsers.Size = new System.Drawing.Size(180, 67);
            this.btEditUsers.TabIndex = 15;
            this.btEditUsers.Text = "Edit Users";
            this.btEditUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btEditUsers.Click += new System.EventHandler(this.btEditUsers_Click);
            // 
            // btBorrowedAdmin
            // 
            this.btBorrowedAdmin.BorderRadius = 10;
            this.btBorrowedAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btBorrowedAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btBorrowedAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btBorrowedAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btBorrowedAdmin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btBorrowedAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrowedAdmin.ForeColor = System.Drawing.Color.White;
            this.btBorrowedAdmin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btBorrowedAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btBorrowedAdmin.Image")));
            this.btBorrowedAdmin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btBorrowedAdmin.ImageOffset = new System.Drawing.Point(0, -1);
            this.btBorrowedAdmin.ImageSize = new System.Drawing.Size(28, 28);
            this.btBorrowedAdmin.Location = new System.Drawing.Point(15, 200);
            this.btBorrowedAdmin.Name = "btBorrowedAdmin";
            this.btBorrowedAdmin.Size = new System.Drawing.Size(180, 67);
            this.btBorrowedAdmin.TabIndex = 14;
            this.btBorrowedAdmin.Text = "Borrowed";
            this.btBorrowedAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btBorrowedAdmin.Click += new System.EventHandler(this.btBorrowedAdmin_Click);
            // 
            // btAddBook
            // 
            this.btAddBook.BorderRadius = 10;
            this.btAddBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAddBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAddBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAddBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAddBook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddBook.ForeColor = System.Drawing.Color.White;
            this.btAddBook.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btAddBook.Image = ((System.Drawing.Image)(resources.GetObject("btAddBook.Image")));
            this.btAddBook.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btAddBook.ImageOffset = new System.Drawing.Point(0, -1);
            this.btAddBook.ImageSize = new System.Drawing.Size(28, 28);
            this.btAddBook.Location = new System.Drawing.Point(15, 260);
            this.btAddBook.Name = "btAddBook";
            this.btAddBook.Size = new System.Drawing.Size(180, 67);
            this.btAddBook.TabIndex = 13;
            this.btAddBook.Text = "Add Book";
            this.btAddBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btAddBook.Click += new System.EventHandler(this.btAddBook_Click);
            // 
            // btBooksAdmin
            // 
            this.btBooksAdmin.BorderRadius = 10;
            this.btBooksAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btBooksAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btBooksAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btBooksAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btBooksAdmin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btBooksAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBooksAdmin.ForeColor = System.Drawing.Color.White;
            this.btBooksAdmin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btBooksAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btBooksAdmin.Image")));
            this.btBooksAdmin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btBooksAdmin.ImageOffset = new System.Drawing.Point(0, -1);
            this.btBooksAdmin.ImageSize = new System.Drawing.Size(28, 28);
            this.btBooksAdmin.Location = new System.Drawing.Point(15, 140);
            this.btBooksAdmin.Name = "btBooksAdmin";
            this.btBooksAdmin.Size = new System.Drawing.Size(180, 67);
            this.btBooksAdmin.TabIndex = 12;
            this.btBooksAdmin.Text = "Books";
            this.btBooksAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btBooksAdmin.Click += new System.EventHandler(this.btBooksAdmin_Click);
            // 
            // btHomeAdmin
            // 
            this.btHomeAdmin.BorderRadius = 10;
            this.btHomeAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btHomeAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btHomeAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btHomeAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btHomeAdmin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btHomeAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHomeAdmin.ForeColor = System.Drawing.Color.White;
            this.btHomeAdmin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btHomeAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btHomeAdmin.Image")));
            this.btHomeAdmin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btHomeAdmin.ImageOffset = new System.Drawing.Point(0, -1);
            this.btHomeAdmin.ImageSize = new System.Drawing.Size(28, 28);
            this.btHomeAdmin.Location = new System.Drawing.Point(15, 80);
            this.btHomeAdmin.Name = "btHomeAdmin";
            this.btHomeAdmin.Size = new System.Drawing.Size(180, 67);
            this.btHomeAdmin.TabIndex = 11;
            this.btHomeAdmin.Text = "Home";
            this.btHomeAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btHomeAdmin.Click += new System.EventHandler(this.btHomeAdmin_Click);
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
            this.btLogout.TabIndex = 12;
            this.btLogout.Text = "Logout";
            this.btLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btEditUsers);
            this.Controls.Add(this.btBorrowedAdmin);
            this.Controls.Add(this.btAddBook);
            this.Controls.Add(this.btBooksAdmin);
            this.Controls.Add(this.btHomeAdmin);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.lbHelloAdmin);
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
        private System.Windows.Forms.Label lbHelloAdmin;
        private System.Windows.Forms.Panel pnMain;
        private Guna.UI2.WinForms.Guna2Button btEditUsers;
        private Guna.UI2.WinForms.Guna2Button btBorrowedAdmin;
        private Guna.UI2.WinForms.Guna2Button btAddBook;
        private Guna.UI2.WinForms.Guna2Button btBooksAdmin;
        private Guna.UI2.WinForms.Guna2Button btHomeAdmin;
        private Guna.UI2.WinForms.Guna2Button btLogout;
    }
}