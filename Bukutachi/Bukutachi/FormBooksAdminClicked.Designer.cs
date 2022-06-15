
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
            this.DateReturned = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DateBorrowed = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbStock = new System.Windows.Forms.Label();
            this.lbBack = new System.Windows.Forms.Label();
            this.pnBook = new Guna.UI2.WinForms.Guna2Panel();
            this.tbGenre = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbPublisher = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbAuthor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPublishDate = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.tbBookName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbAdress = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbTelephone = new System.Windows.Forms.Label();
            this.tbBorrowerUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbFullName = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnBook.SuspendLayout();
            this.pnForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DateReturned
            // 
            this.DateReturned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.DateReturned.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.DateReturned.BorderRadius = 7;
            this.DateReturned.Checked = true;
            this.DateReturned.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.DateReturned.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateReturned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.DateReturned.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateReturned.Location = new System.Drawing.Point(403, 135);
            this.DateReturned.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateReturned.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateReturned.Name = "DateReturned";
            this.DateReturned.Size = new System.Drawing.Size(299, 31);
            this.DateReturned.TabIndex = 19;
            this.DateReturned.Value = new System.DateTime(2022, 5, 22, 20, 17, 1, 768);
            // 
            // DateBorrowed
            // 
            this.DateBorrowed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.DateBorrowed.BorderRadius = 7;
            this.DateBorrowed.Checked = true;
            this.DateBorrowed.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.DateBorrowed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateBorrowed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.DateBorrowed.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateBorrowed.Location = new System.Drawing.Point(403, 35);
            this.DateBorrowed.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateBorrowed.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateBorrowed.Name = "DateBorrowed";
            this.DateBorrowed.Size = new System.Drawing.Size(299, 31);
            this.DateBorrowed.TabIndex = 18;
            this.DateBorrowed.Value = new System.DateTime(2022, 5, 22, 20, 17, 1, 768);
            this.DateBorrowed.ValueChanged += new System.EventHandler(this.DateBorrow_ValueChanged);
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStock.ForeColor = System.Drawing.Color.White;
            this.lbStock.Location = new System.Drawing.Point(641, 14);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(77, 18);
            this.lbStock.TabIndex = 30;
            this.lbStock.Text = "Status : -";
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
            this.lbBack.Click += new System.EventHandler(this.lbBack_Click);
            // 
            // pnBook
            // 
            this.pnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.pnBook.Controls.Add(this.tbGenre);
            this.pnBook.Controls.Add(this.cbPublisher);
            this.pnBook.Controls.Add(this.cbAuthor);
            this.pnBook.Controls.Add(this.tbLocation);
            this.pnBook.Controls.Add(this.tbPublishDate);
            this.pnBook.Controls.Add(this.tbBookTitle);
            this.pnBook.Controls.Add(this.lbLocation);
            this.pnBook.Controls.Add(this.label4);
            this.pnBook.Controls.Add(this.lbPublisher);
            this.pnBook.Controls.Add(this.lbGenre);
            this.pnBook.Controls.Add(this.lbAuthor);
            this.pnBook.Controls.Add(this.lbBookTItle);
            this.pnBook.Location = new System.Drawing.Point(226, 46);
            this.pnBook.Name = "pnBook";
            this.pnBook.Size = new System.Drawing.Size(526, 250);
            this.pnBook.TabIndex = 28;
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
            this.tbGenre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbGenre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbGenre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGenre.ForeColor = System.Drawing.Color.White;
            this.tbGenre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbGenre.Location = new System.Drawing.Point(148, 85);
            this.tbGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.PasswordChar = '\0';
            this.tbGenre.PlaceholderText = "";
            this.tbGenre.SelectedText = "";
            this.tbGenre.Size = new System.Drawing.Size(363, 29);
            this.tbGenre.TabIndex = 47;
            // 
            // cbPublisher
            // 
            this.cbPublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.cbPublisher.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.cbPublisher.BorderRadius = 7;
            this.cbPublisher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPublisher.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbPublisher.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPublisher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPublisher.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbPublisher.ForeColor = System.Drawing.Color.White;
            this.cbPublisher.ItemHeight = 30;
            this.cbPublisher.Location = new System.Drawing.Point(148, 121);
            this.cbPublisher.Name = "cbPublisher";
            this.cbPublisher.Size = new System.Drawing.Size(363, 36);
            this.cbPublisher.TabIndex = 46;
            // 
            // cbAuthor
            // 
            this.cbAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.cbAuthor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.cbAuthor.BorderRadius = 7;
            this.cbAuthor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAuthor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbAuthor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAuthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAuthor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbAuthor.ForeColor = System.Drawing.Color.White;
            this.cbAuthor.ItemHeight = 30;
            this.cbAuthor.Location = new System.Drawing.Point(148, 44);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(363, 36);
            this.cbAuthor.TabIndex = 44;
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
            this.tbLocation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocation.ForeColor = System.Drawing.Color.White;
            this.tbLocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLocation.Location = new System.Drawing.Point(148, 203);
            this.tbLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.PasswordChar = '\0';
            this.tbLocation.PlaceholderText = "";
            this.tbLocation.SelectedText = "";
            this.tbLocation.Size = new System.Drawing.Size(363, 29);
            this.tbLocation.TabIndex = 31;
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
            this.tbPublishDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbPublishDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPublishDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPublishDate.ForeColor = System.Drawing.Color.White;
            this.tbPublishDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPublishDate.Location = new System.Drawing.Point(148, 164);
            this.tbPublishDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPublishDate.Name = "tbPublishDate";
            this.tbPublishDate.PasswordChar = '\0';
            this.tbPublishDate.PlaceholderText = "";
            this.tbPublishDate.SelectedText = "";
            this.tbPublishDate.Size = new System.Drawing.Size(363, 29);
            this.tbPublishDate.TabIndex = 30;
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
            this.tbBookTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbBookTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBookTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBookTitle.ForeColor = System.Drawing.Color.White;
            this.tbBookTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBookTitle.Location = new System.Drawing.Point(148, 8);
            this.tbBookTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBookTitle.Name = "tbBookTitle";
            this.tbBookTitle.PasswordChar = '\0';
            this.tbBookTitle.PlaceholderText = "";
            this.tbBookTitle.SelectedText = "";
            this.tbBookTitle.Size = new System.Drawing.Size(363, 29);
            this.tbBookTitle.TabIndex = 26;
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
            this.btEditData.Location = new System.Drawing.Point(587, 302);
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
            this.pnForm.Controls.Add(this.DateReturned);
            this.pnForm.Controls.Add(this.DateBorrowed);
            this.pnForm.Controls.Add(this.tbBookName);
            this.pnForm.Controls.Add(this.lbAdress);
            this.pnForm.Controls.Add(this.lbPassword);
            this.pnForm.Controls.Add(this.lbTelephone);
            this.pnForm.Controls.Add(this.tbBorrowerUsername);
            this.pnForm.Controls.Add(this.lbFullName);
            this.pnForm.Location = new System.Drawing.Point(12, 339);
            this.pnForm.Name = "pnForm";
            this.pnForm.Size = new System.Drawing.Size(740, 208);
            this.pnForm.TabIndex = 25;
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
            this.tbBookName.Location = new System.Drawing.Point(32, 135);
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
            this.lbAdress.Location = new System.Drawing.Point(32, 113);
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
            this.lbPassword.Location = new System.Drawing.Point(400, 113);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(116, 18);
            this.lbPassword.TabIndex = 14;
            this.lbPassword.Text = "Returned Date";
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
            this.Load += new System.EventHandler(this.FormBooksAdminClicked_Load);
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
        private Guna.UI2.WinForms.Guna2TextBox tbBookName;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbTelephone;
        private Guna.UI2.WinForms.Guna2TextBox tbBorrowerUsername;
        private System.Windows.Forms.Label lbFullName;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateBorrowed;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateReturned;
        private Guna.UI2.WinForms.Guna2TextBox tbPublishDate;
        private Guna.UI2.WinForms.Guna2ComboBox cbAuthor;
        private Guna.UI2.WinForms.Guna2ComboBox cbPublisher;
        private Guna.UI2.WinForms.Guna2TextBox tbGenre;
    }
}