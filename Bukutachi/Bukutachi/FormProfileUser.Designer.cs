
namespace Bukutachi
{
    partial class FormProfileUser
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
            this.lbLogin = new System.Windows.Forms.Label();
            this.pnProfile = new System.Windows.Forms.Panel();
            this.lbFullName = new System.Windows.Forms.Label();
            this.tbFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbTelephone = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTelephone = new System.Windows.Forms.Label();
            this.lbRegisterDate = new System.Windows.Forms.Label();
            this.tbRegisterDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tbAdress = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbAdress = new System.Windows.Forms.Label();
            this.btEditProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btChangePass = new Guna.UI2.WinForms.Guna2Button();
            this.lbBorrowedBooks = new System.Windows.Forms.Label();
            this.lbHistory = new System.Windows.Forms.Label();
            this.lbSeeMore1 = new System.Windows.Forms.Label();
            this.lbSeeMore2 = new System.Windows.Forms.Label();
            this.pnBorrowedBook = new System.Windows.Forms.Panel();
            this.pnHistory = new System.Windows.Forms.Panel();
            this.pnProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.Color.White;
            this.lbLogin.Location = new System.Drawing.Point(301, 262);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(0, 37);
            this.lbLogin.TabIndex = 7;
            // 
            // pnProfile
            // 
            this.pnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.pnProfile.Controls.Add(this.btChangePass);
            this.pnProfile.Controls.Add(this.btEditProfile);
            this.pnProfile.Controls.Add(this.tbAdress);
            this.pnProfile.Controls.Add(this.lbAdress);
            this.pnProfile.Controls.Add(this.lbRegisterDate);
            this.pnProfile.Controls.Add(this.tbRegisterDate);
            this.pnProfile.Controls.Add(this.tbUsername);
            this.pnProfile.Controls.Add(this.lbUsername);
            this.pnProfile.Controls.Add(this.lbTelephone);
            this.pnProfile.Controls.Add(this.tbTelephone);
            this.pnProfile.Controls.Add(this.tbFullName);
            this.pnProfile.Controls.Add(this.lbFullName);
            this.pnProfile.Location = new System.Drawing.Point(24, 26);
            this.pnProfile.Name = "pnProfile";
            this.pnProfile.Size = new System.Drawing.Size(705, 260);
            this.pnProfile.TabIndex = 8;
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullName.ForeColor = System.Drawing.Color.White;
            this.lbFullName.Location = new System.Drawing.Point(3, 14);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(84, 18);
            this.lbFullName.TabIndex = 7;
            this.lbFullName.Text = "Full Name";
            // 
            // tbFullName
            // 
            this.tbFullName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.tbFullName.BorderRadius = 7;
            this.tbFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFullName.DefaultText = "";
            this.tbFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFullName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFullName.ForeColor = System.Drawing.Color.White;
            this.tbFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFullName.Location = new System.Drawing.Point(4, 46);
            this.tbFullName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.PasswordChar = '\0';
            this.tbFullName.PlaceholderText = "";
            this.tbFullName.SelectedText = "";
            this.tbFullName.Size = new System.Drawing.Size(276, 31);
            this.tbFullName.TabIndex = 8;
            // 
            // tbTelephone
            // 
            this.tbTelephone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.tbTelephone.BorderRadius = 7;
            this.tbTelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTelephone.DefaultText = "";
            this.tbTelephone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTelephone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTelephone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTelephone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTelephone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbTelephone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTelephone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelephone.ForeColor = System.Drawing.Color.White;
            this.tbTelephone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTelephone.Location = new System.Drawing.Point(394, 46);
            this.tbTelephone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.PasswordChar = '\0';
            this.tbTelephone.PlaceholderText = "";
            this.tbTelephone.SelectedText = "";
            this.tbTelephone.ShortcutsEnabled = false;
            this.tbTelephone.Size = new System.Drawing.Size(306, 31);
            this.tbTelephone.TabIndex = 9;
            // 
            // lbTelephone
            // 
            this.lbTelephone.AutoSize = true;
            this.lbTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelephone.ForeColor = System.Drawing.Color.White;
            this.lbTelephone.Location = new System.Drawing.Point(391, 14);
            this.lbTelephone.Name = "lbTelephone";
            this.lbTelephone.Size = new System.Drawing.Size(150, 18);
            this.lbTelephone.TabIndex = 10;
            this.lbTelephone.Text = "Telephone Number";
            // 
            // lbRegisterDate
            // 
            this.lbRegisterDate.AutoSize = true;
            this.lbRegisterDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegisterDate.ForeColor = System.Drawing.Color.White;
            this.lbRegisterDate.Location = new System.Drawing.Point(391, 89);
            this.lbRegisterDate.Name = "lbRegisterDate";
            this.lbRegisterDate.Size = new System.Drawing.Size(111, 18);
            this.lbRegisterDate.TabIndex = 14;
            this.lbRegisterDate.Text = "Register Date";
            // 
            // tbRegisterDate
            // 
            this.tbRegisterDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.tbRegisterDate.BorderRadius = 7;
            this.tbRegisterDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRegisterDate.DefaultText = "";
            this.tbRegisterDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbRegisterDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbRegisterDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbRegisterDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbRegisterDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbRegisterDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbRegisterDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegisterDate.ForeColor = System.Drawing.Color.White;
            this.tbRegisterDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbRegisterDate.Location = new System.Drawing.Point(394, 121);
            this.tbRegisterDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRegisterDate.Name = "tbRegisterDate";
            this.tbRegisterDate.PasswordChar = '\0';
            this.tbRegisterDate.PlaceholderText = "";
            this.tbRegisterDate.SelectedText = "";
            this.tbRegisterDate.Size = new System.Drawing.Size(306, 31);
            this.tbRegisterDate.TabIndex = 13;
            // 
            // tbUsername
            // 
            this.tbUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.tbUsername.BorderRadius = 7;
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.DefaultText = "";
            this.tbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.White;
            this.tbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsername.Location = new System.Drawing.Point(4, 121);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.PlaceholderText = "";
            this.tbUsername.SelectedText = "";
            this.tbUsername.Size = new System.Drawing.Size(276, 31);
            this.tbUsername.TabIndex = 12;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(3, 89);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(85, 18);
            this.lbUsername.TabIndex = 11;
            this.lbUsername.Text = "Username";
            // 
            // tbAdress
            // 
            this.tbAdress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.tbAdress.BorderRadius = 7;
            this.tbAdress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAdress.DefaultText = "";
            this.tbAdress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAdress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAdress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAdress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAdress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbAdress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAdress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdress.ForeColor = System.Drawing.Color.White;
            this.tbAdress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAdress.Location = new System.Drawing.Point(4, 201);
            this.tbAdress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.PasswordChar = '\0';
            this.tbAdress.PlaceholderText = "";
            this.tbAdress.SelectedText = "";
            this.tbAdress.Size = new System.Drawing.Size(276, 31);
            this.tbAdress.TabIndex = 16;
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdress.ForeColor = System.Drawing.Color.White;
            this.lbAdress.Location = new System.Drawing.Point(3, 168);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(60, 18);
            this.lbAdress.TabIndex = 15;
            this.lbAdress.Text = "Adress";
            // 
            // btEditProfile
            // 
            this.btEditProfile.BorderRadius = 5;
            this.btEditProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btEditProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btEditProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btEditProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btEditProfile.FillColor = System.Drawing.Color.Black;
            this.btEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditProfile.ForeColor = System.Drawing.Color.White;
            this.btEditProfile.Location = new System.Drawing.Point(394, 201);
            this.btEditProfile.Name = "btEditProfile";
            this.btEditProfile.Size = new System.Drawing.Size(150, 31);
            this.btEditProfile.TabIndex = 17;
            this.btEditProfile.Text = "Edit Profile";
            // 
            // btChangePass
            // 
            this.btChangePass.BorderRadius = 5;
            this.btChangePass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btChangePass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btChangePass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btChangePass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btChangePass.FillColor = System.Drawing.Color.Black;
            this.btChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChangePass.ForeColor = System.Drawing.Color.White;
            this.btChangePass.Location = new System.Drawing.Point(550, 201);
            this.btChangePass.Name = "btChangePass";
            this.btChangePass.Size = new System.Drawing.Size(150, 31);
            this.btChangePass.TabIndex = 18;
            this.btChangePass.Text = "Change Pass";
            // 
            // lbBorrowedBooks
            // 
            this.lbBorrowedBooks.AutoSize = true;
            this.lbBorrowedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBorrowedBooks.ForeColor = System.Drawing.Color.White;
            this.lbBorrowedBooks.Location = new System.Drawing.Point(21, 325);
            this.lbBorrowedBooks.Name = "lbBorrowedBooks";
            this.lbBorrowedBooks.Size = new System.Drawing.Size(135, 18);
            this.lbBorrowedBooks.TabIndex = 19;
            this.lbBorrowedBooks.Text = "Borrowed Books";
            // 
            // lbHistory
            // 
            this.lbHistory.AutoSize = true;
            this.lbHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHistory.ForeColor = System.Drawing.Color.White;
            this.lbHistory.Location = new System.Drawing.Point(402, 325);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(62, 18);
            this.lbHistory.TabIndex = 20;
            this.lbHistory.Text = "History";
            // 
            // lbSeeMore1
            // 
            this.lbSeeMore1.AutoSize = true;
            this.lbSeeMore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeeMore1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(203)))), ((int)(((byte)(192)))));
            this.lbSeeMore1.Location = new System.Drawing.Point(272, 327);
            this.lbSeeMore1.Name = "lbSeeMore1";
            this.lbSeeMore1.Size = new System.Drawing.Size(76, 16);
            this.lbSeeMore1.TabIndex = 29;
            this.lbSeeMore1.Text = "See More...";
            // 
            // lbSeeMore2
            // 
            this.lbSeeMore2.AutoSize = true;
            this.lbSeeMore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeeMore2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(203)))), ((int)(((byte)(192)))));
            this.lbSeeMore2.Location = new System.Drawing.Point(653, 327);
            this.lbSeeMore2.Name = "lbSeeMore2";
            this.lbSeeMore2.Size = new System.Drawing.Size(76, 16);
            this.lbSeeMore2.TabIndex = 30;
            this.lbSeeMore2.Text = "See More...";
            // 
            // pnBorrowedBook
            // 
            this.pnBorrowedBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.pnBorrowedBook.Location = new System.Drawing.Point(24, 346);
            this.pnBorrowedBook.Name = "pnBorrowedBook";
            this.pnBorrowedBook.Size = new System.Drawing.Size(324, 210);
            this.pnBorrowedBook.TabIndex = 31;
            // 
            // pnHistory
            // 
            this.pnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.pnHistory.Location = new System.Drawing.Point(405, 346);
            this.pnHistory.Name = "pnHistory";
            this.pnHistory.Size = new System.Drawing.Size(324, 210);
            this.pnHistory.TabIndex = 32;
            // 
            // FormProfileUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(765, 560);
            this.Controls.Add(this.pnHistory);
            this.Controls.Add(this.pnBorrowedBook);
            this.Controls.Add(this.lbSeeMore2);
            this.Controls.Add(this.lbSeeMore1);
            this.Controls.Add(this.lbHistory);
            this.Controls.Add(this.lbBorrowedBooks);
            this.Controls.Add(this.pnProfile);
            this.Controls.Add(this.lbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProfileUser";
            this.Text = "FormProfileUser";
            this.pnProfile.ResumeLayout(false);
            this.pnProfile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Panel pnProfile;
        private System.Windows.Forms.Label lbFullName;
        private Guna.UI2.WinForms.Guna2TextBox tbFullName;
        private Guna.UI2.WinForms.Guna2TextBox tbAdress;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.Label lbRegisterDate;
        private Guna.UI2.WinForms.Guna2TextBox tbRegisterDate;
        private Guna.UI2.WinForms.Guna2TextBox tbUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbTelephone;
        private Guna.UI2.WinForms.Guna2TextBox tbTelephone;
        private Guna.UI2.WinForms.Guna2Button btChangePass;
        private Guna.UI2.WinForms.Guna2Button btEditProfile;
        private System.Windows.Forms.Label lbBorrowedBooks;
        private System.Windows.Forms.Label lbHistory;
        private System.Windows.Forms.Label lbSeeMore1;
        private System.Windows.Forms.Label lbSeeMore2;
        private System.Windows.Forms.Panel pnBorrowedBook;
        private System.Windows.Forms.Panel pnHistory;
    }
}