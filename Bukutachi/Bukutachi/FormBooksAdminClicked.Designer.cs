﻿
namespace Bukutachi
{
    partial class FormBooksAdminClicked
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
            Guna.UI2.WinForms.Guna2DateTimePicker DateReturned;
            Guna.UI2.WinForms.Guna2DateTimePicker DateBorrowed;
            this.lbStock = new System.Windows.Forms.Label();
            this.lbBack = new System.Windows.Forms.Label();
            this.pnBook = new Guna.UI2.WinForms.Guna2Panel();
            this.tbLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPublishDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPublisher = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbGenre = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbAuthor = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbBookTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbLocation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPublisher = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbBookTItle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btEditData = new Guna.UI2.WinForms.Guna2Button();
            this.pnForm = new System.Windows.Forms.Panel();
            this.btCreateForm = new Guna.UI2.WinForms.Guna2Button();
            this.tbBookName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbAdress = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbAdminUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbTelephone = new System.Windows.Forms.Label();
            this.tbBorrowerUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbFullName = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            DateReturned = new Guna.UI2.WinForms.Guna2DateTimePicker();
            DateBorrowed = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pnBook.SuspendLayout();
            this.pnForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DateReturned
            // 
            DateReturned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            DateReturned.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            DateReturned.BorderRadius = 7;
            DateReturned.Checked = true;
            DateReturned.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            DateReturned.Font = new System.Drawing.Font("Segoe UI", 9F);
            DateReturned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            DateReturned.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            DateReturned.Location = new System.Drawing.Point(403, 100);
            DateReturned.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            DateReturned.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            DateReturned.Name = "DateReturned";
            DateReturned.Size = new System.Drawing.Size(299, 31);
            DateReturned.TabIndex = 19;
            DateReturned.Value = new System.DateTime(2022, 5, 22, 20, 17, 1, 768);
            // 
            // DateBorrowed
            // 
            DateBorrowed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            DateBorrowed.BorderRadius = 7;
            DateBorrowed.Checked = true;
            DateBorrowed.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            DateBorrowed.Font = new System.Drawing.Font("Segoe UI", 9F);
            DateBorrowed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            DateBorrowed.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            DateBorrowed.Location = new System.Drawing.Point(403, 35);
            DateBorrowed.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            DateBorrowed.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            DateBorrowed.Name = "DateBorrowed";
            DateBorrowed.Size = new System.Drawing.Size(299, 31);
            DateBorrowed.TabIndex = 18;
            DateBorrowed.Value = new System.DateTime(2022, 5, 22, 20, 17, 1, 768);
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStock.ForeColor = System.Drawing.Color.White;
            this.lbStock.Location = new System.Drawing.Point(641, 14);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(73, 18);
            this.lbStock.TabIndex = 30;
            this.lbStock.Text = "Stock : -";
            // 
            // lbBack
            // 
            this.lbBack.AutoSize = true;
            this.lbBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBack.ForeColor = System.Drawing.Color.White;
            this.lbBack.Location = new System.Drawing.Point(41, 16);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(131, 16);
            this.lbBack.TabIndex = 29;
            this.lbBack.Text = "< Back To Search";
            // 
            // pnBook
            // 
            this.pnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.pnBook.Controls.Add(this.tbLocation);
            this.pnBook.Controls.Add(this.tbPublishDate);
            this.pnBook.Controls.Add(this.tbPublisher);
            this.pnBook.Controls.Add(this.tbGenre);
            this.pnBook.Controls.Add(this.tbAuthor);
            this.pnBook.Controls.Add(this.tbBookTitle);
            this.pnBook.Controls.Add(this.lbLocation);
            this.pnBook.Controls.Add(this.label4);
            this.pnBook.Controls.Add(this.lbPublisher);
            this.pnBook.Controls.Add(this.lbGenre);
            this.pnBook.Controls.Add(this.lbAuthor);
            this.pnBook.Controls.Add(this.lbBookTItle);
            this.pnBook.Location = new System.Drawing.Point(226, 46);
            this.pnBook.Name = "pnBook";
            this.pnBook.Size = new System.Drawing.Size(526, 244);
            this.pnBook.TabIndex = 28;
            // 
            // tbLocation
            // 
            this.tbLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.tbLocation.BorderRadius = 7;
            this.tbLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLocation.DefaultText = "";
            this.tbLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLocation.Enabled = false;
            this.tbLocation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocation.ForeColor = System.Drawing.Color.White;
            this.tbLocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLocation.Location = new System.Drawing.Point(148, 203);
            this.tbLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.PasswordChar = '●';
            this.tbLocation.PlaceholderText = "";
            this.tbLocation.SelectedText = "";
            this.tbLocation.Size = new System.Drawing.Size(363, 29);
            this.tbLocation.TabIndex = 31;
            this.tbLocation.UseSystemPasswordChar = true;
            // 
            // tbPublishDate
            // 
            this.tbPublishDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.tbPublishDate.BorderRadius = 7;
            this.tbPublishDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPublishDate.DefaultText = "";
            this.tbPublishDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbPublishDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbPublishDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPublishDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPublishDate.Enabled = false;
            this.tbPublishDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbPublishDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPublishDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPublishDate.ForeColor = System.Drawing.Color.White;
            this.tbPublishDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPublishDate.Location = new System.Drawing.Point(148, 164);
            this.tbPublishDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPublishDate.Name = "tbPublishDate";
            this.tbPublishDate.PasswordChar = '●';
            this.tbPublishDate.PlaceholderText = "";
            this.tbPublishDate.SelectedText = "";
            this.tbPublishDate.Size = new System.Drawing.Size(363, 29);
            this.tbPublishDate.TabIndex = 30;
            this.tbPublishDate.UseSystemPasswordChar = true;
            // 
            // tbPublisher
            // 
            this.tbPublisher.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.tbPublisher.BorderRadius = 7;
            this.tbPublisher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPublisher.DefaultText = "";
            this.tbPublisher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbPublisher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbPublisher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPublisher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPublisher.Enabled = false;
            this.tbPublisher.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbPublisher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPublisher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPublisher.ForeColor = System.Drawing.Color.White;
            this.tbPublisher.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPublisher.Location = new System.Drawing.Point(148, 125);
            this.tbPublisher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPublisher.Name = "tbPublisher";
            this.tbPublisher.PasswordChar = '●';
            this.tbPublisher.PlaceholderText = "";
            this.tbPublisher.SelectedText = "";
            this.tbPublisher.Size = new System.Drawing.Size(363, 29);
            this.tbPublisher.TabIndex = 29;
            this.tbPublisher.UseSystemPasswordChar = true;
            // 
            // tbGenre
            // 
            this.tbGenre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.tbGenre.BorderRadius = 7;
            this.tbGenre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbGenre.DefaultText = "";
            this.tbGenre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbGenre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbGenre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbGenre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbGenre.Enabled = false;
            this.tbGenre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbGenre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbGenre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGenre.ForeColor = System.Drawing.Color.White;
            this.tbGenre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbGenre.Location = new System.Drawing.Point(148, 86);
            this.tbGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.PasswordChar = '●';
            this.tbGenre.PlaceholderText = "";
            this.tbGenre.SelectedText = "";
            this.tbGenre.Size = new System.Drawing.Size(363, 29);
            this.tbGenre.TabIndex = 28;
            this.tbGenre.UseSystemPasswordChar = true;
            // 
            // tbAuthor
            // 
            this.tbAuthor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.tbAuthor.BorderRadius = 7;
            this.tbAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAuthor.DefaultText = "";
            this.tbAuthor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbAuthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbAuthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAuthor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAuthor.Enabled = false;
            this.tbAuthor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbAuthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAuthor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAuthor.ForeColor = System.Drawing.Color.White;
            this.tbAuthor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAuthor.Location = new System.Drawing.Point(148, 47);
            this.tbAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.PasswordChar = '●';
            this.tbAuthor.PlaceholderText = "";
            this.tbAuthor.SelectedText = "";
            this.tbAuthor.Size = new System.Drawing.Size(363, 29);
            this.tbAuthor.TabIndex = 27;
            this.tbAuthor.UseSystemPasswordChar = true;
            // 
            // tbBookTitle
            // 
            this.tbBookTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.tbBookTitle.BorderRadius = 7;
            this.tbBookTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBookTitle.DefaultText = "";
            this.tbBookTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbBookTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbBookTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBookTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBookTitle.Enabled = false;
            this.tbBookTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbBookTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBookTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBookTitle.ForeColor = System.Drawing.Color.White;
            this.tbBookTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBookTitle.Location = new System.Drawing.Point(148, 8);
            this.tbBookTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBookTitle.Name = "tbBookTitle";
            this.tbBookTitle.PasswordChar = '●';
            this.tbBookTitle.PlaceholderText = "";
            this.tbBookTitle.SelectedText = "";
            this.tbBookTitle.Size = new System.Drawing.Size(363, 29);
            this.tbBookTitle.TabIndex = 26;
            this.tbBookTitle.UseSystemPasswordChar = true;
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocation.ForeColor = System.Drawing.Color.White;
            this.lbLocation.Location = new System.Drawing.Point(14, 209);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(75, 16);
            this.lbLocation.TabIndex = 24;
            this.lbLocation.Text = "Location :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Publish Date :";
            // 
            // lbPublisher
            // 
            this.lbPublisher.AutoSize = true;
            this.lbPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPublisher.ForeColor = System.Drawing.Color.White;
            this.lbPublisher.Location = new System.Drawing.Point(14, 129);
            this.lbPublisher.Name = "lbPublisher";
            this.lbPublisher.Size = new System.Drawing.Size(81, 16);
            this.lbPublisher.TabIndex = 22;
            this.lbPublisher.Text = "Publisher :";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenre.ForeColor = System.Drawing.Color.White;
            this.lbGenre.Location = new System.Drawing.Point(14, 90);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(58, 16);
            this.lbGenre.TabIndex = 21;
            this.lbGenre.Text = "Genre :";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor.ForeColor = System.Drawing.Color.White;
            this.lbAuthor.Location = new System.Drawing.Point(14, 51);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(60, 16);
            this.lbAuthor.TabIndex = 20;
            this.lbAuthor.Text = "Author :";
            // 
            // lbBookTItle
            // 
            this.lbBookTItle.AutoSize = true;
            this.lbBookTItle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookTItle.ForeColor = System.Drawing.Color.White;
            this.lbBookTItle.Location = new System.Drawing.Point(14, 11);
            this.lbBookTItle.Name = "lbBookTItle";
            this.lbBookTItle.Size = new System.Drawing.Size(87, 16);
            this.lbBookTItle.TabIndex = 19;
            this.lbBookTItle.Text = "Book Title :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Form Borrow";
            // 
            // btEditData
            // 
            this.btEditData.BorderRadius = 5;
            this.btEditData.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btEditData.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(194)))));
            this.btEditData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(194)))));
            this.btEditData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btEditData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(194)))));
            this.btEditData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditData.ForeColor = System.Drawing.Color.White;
            this.btEditData.Location = new System.Drawing.Point(564, 296);
            this.btEditData.Name = "btEditData";
            this.btEditData.Size = new System.Drawing.Size(150, 31);
            this.btEditData.TabIndex = 27;
            this.btEditData.Tag = "0";
            this.btEditData.Text = "Edit Data";
            this.btEditData.Click += new System.EventHandler(this.btEditData_Click);
            // 
            // pnForm
            // 
            this.pnForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.pnForm.Controls.Add(DateReturned);
            this.pnForm.Controls.Add(DateBorrowed);
            this.pnForm.Controls.Add(this.btCreateForm);
            this.pnForm.Controls.Add(this.tbBookName);
            this.pnForm.Controls.Add(this.lbAdress);
            this.pnForm.Controls.Add(this.lbPassword);
            this.pnForm.Controls.Add(this.tbAdminUsername);
            this.pnForm.Controls.Add(this.lbUsername);
            this.pnForm.Controls.Add(this.lbTelephone);
            this.pnForm.Controls.Add(this.tbBorrowerUsername);
            this.pnForm.Controls.Add(this.lbFullName);
            this.pnForm.Location = new System.Drawing.Point(12, 339);
            this.pnForm.Name = "pnForm";
            this.pnForm.Size = new System.Drawing.Size(740, 208);
            this.pnForm.TabIndex = 25;
            // 
            // btCreateForm
            // 
            this.btCreateForm.BorderRadius = 5;
            this.btCreateForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCreateForm.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(194)))));
            this.btCreateForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(194)))));
            this.btCreateForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCreateForm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(194)))));
            this.btCreateForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateForm.ForeColor = System.Drawing.Color.White;
            this.btCreateForm.Location = new System.Drawing.Point(552, 165);
            this.btCreateForm.Name = "btCreateForm";
            this.btCreateForm.Size = new System.Drawing.Size(150, 31);
            this.btCreateForm.TabIndex = 17;
            this.btCreateForm.Tag = "0";
            this.btCreateForm.Text = "Create Form";
            // 
            // tbBookName
            // 
            this.tbBookName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.tbBookName.BorderRadius = 7;
            this.tbBookName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBookName.DefaultText = "";
            this.tbBookName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbBookName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbBookName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBookName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBookName.Enabled = false;
            this.tbBookName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbBookName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBookName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBookName.ForeColor = System.Drawing.Color.White;
            this.tbBookName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBookName.Location = new System.Drawing.Point(32, 165);
            this.tbBookName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.PasswordChar = '\0';
            this.tbBookName.PlaceholderText = "";
            this.tbBookName.SelectedText = "";
            this.tbBookName.Size = new System.Drawing.Size(302, 31);
            this.tbBookName.TabIndex = 16;
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdress.ForeColor = System.Drawing.Color.White;
            this.lbAdress.Location = new System.Drawing.Point(32, 140);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(97, 18);
            this.lbAdress.TabIndex = 15;
            this.lbAdress.Text = "Book Name";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.White;
            this.lbPassword.Location = new System.Drawing.Point(400, 75);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(116, 18);
            this.lbPassword.TabIndex = 14;
            this.lbPassword.Text = "Returned Date";
            // 
            // tbAdminUsername
            // 
            this.tbAdminUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.tbAdminUsername.BorderRadius = 7;
            this.tbAdminUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAdminUsername.DefaultText = "";
            this.tbAdminUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbAdminUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbAdminUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAdminUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAdminUsername.Enabled = false;
            this.tbAdminUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbAdminUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAdminUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdminUsername.ForeColor = System.Drawing.Color.White;
            this.tbAdminUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAdminUsername.Location = new System.Drawing.Point(32, 100);
            this.tbAdminUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAdminUsername.Name = "tbAdminUsername";
            this.tbAdminUsername.PasswordChar = '\0';
            this.tbAdminUsername.PlaceholderText = "";
            this.tbAdminUsername.SelectedText = "";
            this.tbAdminUsername.Size = new System.Drawing.Size(302, 31);
            this.tbAdminUsername.TabIndex = 12;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(32, 75);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(136, 18);
            this.lbUsername.TabIndex = 11;
            this.lbUsername.Text = "Admin Username";
            // 
            // lbTelephone
            // 
            this.lbTelephone.AutoSize = true;
            this.lbTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelephone.ForeColor = System.Drawing.Color.White;
            this.lbTelephone.Location = new System.Drawing.Point(400, 10);
            this.lbTelephone.Name = "lbTelephone";
            this.lbTelephone.Size = new System.Drawing.Size(121, 18);
            this.lbTelephone.TabIndex = 10;
            this.lbTelephone.Text = "Borrowed Date";
            // 
            // tbBorrowerUsername
            // 
            this.tbBorrowerUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.tbBorrowerUsername.BorderRadius = 7;
            this.tbBorrowerUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBorrowerUsername.DefaultText = "";
            this.tbBorrowerUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbBorrowerUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbBorrowerUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBorrowerUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBorrowerUsername.Enabled = false;
            this.tbBorrowerUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbBorrowerUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBorrowerUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBorrowerUsername.ForeColor = System.Drawing.Color.White;
            this.tbBorrowerUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBorrowerUsername.Location = new System.Drawing.Point(35, 35);
            this.tbBorrowerUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBorrowerUsername.Name = "tbBorrowerUsername";
            this.tbBorrowerUsername.PasswordChar = '\0';
            this.tbBorrowerUsername.PlaceholderText = "";
            this.tbBorrowerUsername.SelectedText = "";
            this.tbBorrowerUsername.Size = new System.Drawing.Size(302, 31);
            this.tbBorrowerUsername.TabIndex = 8;
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullName.ForeColor = System.Drawing.Color.White;
            this.lbFullName.Location = new System.Drawing.Point(32, 10);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(160, 18);
            this.lbFullName.TabIndex = 7;
            this.lbFullName.Text = "Borrower Username";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(31, 43);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(160, 228);
            this.guna2PictureBox1.TabIndex = 24;
            this.guna2PictureBox1.TabStop = false;
            // 
            // FormBooksAdminClicked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(765, 560);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.lbBack);
            this.Controls.Add(this.pnBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEditData);
            this.Controls.Add(this.pnForm);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBooksAdminClicked";
            this.Text = "FormBooksAdminClicked";
            this.pnBook.ResumeLayout(false);
            this.pnBook.PerformLayout();
            this.pnForm.ResumeLayout(false);
            this.pnForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.Label lbBack;
        private Guna.UI2.WinForms.Guna2Panel pnBook;
        private Guna.UI2.WinForms.Guna2TextBox tbLocation;
        private Guna.UI2.WinForms.Guna2TextBox tbPublishDate;
        private Guna.UI2.WinForms.Guna2TextBox tbPublisher;
        private Guna.UI2.WinForms.Guna2TextBox tbGenre;
        private Guna.UI2.WinForms.Guna2TextBox tbAuthor;
        private Guna.UI2.WinForms.Guna2TextBox tbBookTitle;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPublisher;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbBookTItle;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btEditData;
        private System.Windows.Forms.Panel pnForm;
        private Guna.UI2.WinForms.Guna2Button btCreateForm;
        private Guna.UI2.WinForms.Guna2TextBox tbBookName;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.Label lbPassword;
        private Guna.UI2.WinForms.Guna2TextBox tbAdminUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbTelephone;
        private Guna.UI2.WinForms.Guna2TextBox tbBorrowerUsername;
        private System.Windows.Forms.Label lbFullName;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}