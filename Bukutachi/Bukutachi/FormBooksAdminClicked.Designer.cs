
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
            this.btPenerbit = new Guna.UI2.WinForms.Guna2Button();
            this.tbPublisher = new Guna.UI2.WinForms.Guna2TextBox();
            this.btAuthorChange = new Guna.UI2.WinForms.Guna2Button();
            this.tbAuthor = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbLocation = new Guna.UI2.WinForms.Guna2ComboBox();
            this.numericPublishDate = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.tbGenre = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbBookTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbLocation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPublisher = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbBookTItle = new System.Windows.Forms.Label();
            this.btEditData = new Guna.UI2.WinForms.Guna2Button();
            this.pnForm = new System.Windows.Forms.Panel();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbTelephone = new System.Windows.Forms.Label();
            this.tbBorrowerUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbFullName = new System.Windows.Forms.Label();
            this.cbGenre = new System.Windows.Forms.CheckedListBox();
            this.btGantiGenre = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.pnBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPublishDate)).BeginInit();
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
            this.DateReturned.Location = new System.Drawing.Point(35, 155);
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
            this.DateBorrowed.Location = new System.Drawing.Point(35, 95);
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
            this.lbStock.Location = new System.Drawing.Point(605, 14);
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
            this.pnBook.Controls.Add(this.btPenerbit);
            this.pnBook.Controls.Add(this.tbPublisher);
            this.pnBook.Controls.Add(this.btAuthorChange);
            this.pnBook.Controls.Add(this.tbAuthor);
            this.pnBook.Controls.Add(this.cbLocation);
            this.pnBook.Controls.Add(this.numericPublishDate);
            this.pnBook.Controls.Add(this.tbGenre);
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
            // btPenerbit
            // 
            this.btPenerbit.BorderRadius = 5;
            this.btPenerbit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btPenerbit.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(194)))));
            this.btPenerbit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(194)))));
            this.btPenerbit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btPenerbit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(194)))));
            this.btPenerbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPenerbit.ForeColor = System.Drawing.Color.White;
            this.btPenerbit.Location = new System.Drawing.Point(412, 121);
            this.btPenerbit.Name = "btPenerbit";
            this.btPenerbit.Size = new System.Drawing.Size(99, 31);
            this.btPenerbit.TabIndex = 57;
            this.btPenerbit.Tag = "0";
            this.btPenerbit.Text = "Ganti";
            this.btPenerbit.Click += new System.EventHandler(this.btPenerbit_Click);
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
            this.tbPublisher.Location = new System.Drawing.Point(148, 122);
            this.tbPublisher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPublisher.Name = "tbPublisher";
            this.tbPublisher.PasswordChar = '\0';
            this.tbPublisher.PlaceholderText = "";
            this.tbPublisher.SelectedText = "";
            this.tbPublisher.Size = new System.Drawing.Size(257, 29);
            this.tbPublisher.TabIndex = 56;
            // 
            // btAuthorChange
            // 
            this.btAuthorChange.BorderRadius = 5;
            this.btAuthorChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAuthorChange.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(194)))));
            this.btAuthorChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(194)))));
            this.btAuthorChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAuthorChange.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(194)))));
            this.btAuthorChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAuthorChange.ForeColor = System.Drawing.Color.White;
            this.btAuthorChange.Location = new System.Drawing.Point(412, 47);
            this.btAuthorChange.Name = "btAuthorChange";
            this.btAuthorChange.Size = new System.Drawing.Size(99, 31);
            this.btAuthorChange.TabIndex = 33;
            this.btAuthorChange.Tag = "0";
            this.btAuthorChange.Text = "Ganti";
            this.btAuthorChange.Click += new System.EventHandler(this.btAuthorChange_Click);
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
            this.tbAuthor.Location = new System.Drawing.Point(148, 48);
            this.tbAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.PasswordChar = '\0';
            this.tbAuthor.PlaceholderText = "";
            this.tbAuthor.SelectedText = "";
            this.tbAuthor.Size = new System.Drawing.Size(257, 29);
            this.tbAuthor.TabIndex = 55;
            // 
            // cbLocation
            // 
            this.cbLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.cbLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.cbLocation.BorderRadius = 7;
            this.cbLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbLocation.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLocation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbLocation.ForeColor = System.Drawing.Color.White;
            this.cbLocation.ItemHeight = 30;
            this.cbLocation.Location = new System.Drawing.Point(148, 195);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(363, 36);
            this.cbLocation.TabIndex = 54;
            // 
            // numericPublishDate
            // 
            this.numericPublishDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.numericPublishDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.numericPublishDate.BorderRadius = 7;
            this.numericPublishDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericPublishDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.numericPublishDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericPublishDate.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.numericPublishDate.Location = new System.Drawing.Point(148, 158);
            this.numericPublishDate.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.numericPublishDate.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericPublishDate.Name = "numericPublishDate";
            this.numericPublishDate.Size = new System.Drawing.Size(363, 31);
            this.numericPublishDate.TabIndex = 48;
            this.numericPublishDate.UpDownButtonFillColor = System.Drawing.Color.White;
            this.numericPublishDate.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
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
            this.tbGenre.Location = new System.Drawing.Point(148, 85);
            this.tbGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.PasswordChar = '\0';
            this.tbGenre.PlaceholderText = "";
            this.tbGenre.SelectedText = "";
            this.tbGenre.Size = new System.Drawing.Size(363, 29);
            this.tbGenre.TabIndex = 47;
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
            this.lbLocation.Size = new System.Drawing.Size(115, 16);
            this.lbLocation.TabIndex = 24;
            this.lbLocation.Text = "Location           :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Publish Date    :";
            // 
            // lbPublisher
            // 
            this.lbPublisher.AutoSize = true;
            this.lbPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPublisher.ForeColor = System.Drawing.Color.White;
            this.lbPublisher.Location = new System.Drawing.Point(14, 129);
            this.lbPublisher.Name = "lbPublisher";
            this.lbPublisher.Size = new System.Drawing.Size(117, 16);
            this.lbPublisher.TabIndex = 22;
            this.lbPublisher.Text = "Publisher          :";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenre.ForeColor = System.Drawing.Color.White;
            this.lbGenre.Location = new System.Drawing.Point(14, 90);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(118, 16);
            this.lbGenre.TabIndex = 21;
            this.lbGenre.Text = "Genre                :";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor.ForeColor = System.Drawing.Color.White;
            this.lbAuthor.Location = new System.Drawing.Point(14, 51);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(120, 16);
            this.lbAuthor.TabIndex = 20;
            this.lbAuthor.Text = "Author                :";
            // 
            // lbBookTItle
            // 
            this.lbBookTItle.AutoSize = true;
            this.lbBookTItle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookTItle.ForeColor = System.Drawing.Color.White;
            this.lbBookTItle.Location = new System.Drawing.Point(14, 11);
            this.lbBookTItle.Name = "lbBookTItle";
            this.lbBookTItle.Size = new System.Drawing.Size(119, 16);
            this.lbBookTItle.TabIndex = 19;
            this.lbBookTItle.Text = "Book Title         :";
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
            this.pnForm.Controls.Add(this.lbPassword);
            this.pnForm.Controls.Add(this.lbTelephone);
            this.pnForm.Controls.Add(this.tbBorrowerUsername);
            this.pnForm.Controls.Add(this.lbFullName);
            this.pnForm.Location = new System.Drawing.Point(378, 340);
            this.pnForm.Name = "pnForm";
            this.pnForm.Size = new System.Drawing.Size(374, 199);
            this.pnForm.TabIndex = 25;
            this.pnForm.Paint += new System.Windows.Forms.PaintEventHandler(this.pnForm_Paint);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.White;
            this.lbPassword.Location = new System.Drawing.Point(35, 130);
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
            this.lbTelephone.Location = new System.Drawing.Point(32, 70);
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
            this.lbFullName.Size = new System.Drawing.Size(105, 18);
            this.lbFullName.TabIndex = 7;
            this.lbFullName.Text = "Borrowed By";
            // 
            // cbGenre
            // 
            this.cbGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(31, 340);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(324, 154);
            this.cbGenre.TabIndex = 31;
            this.cbGenre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbGenre_MouseClick);
            this.cbGenre.SelectedIndexChanged += new System.EventHandler(this.cbGenre_SelectedIndexChanged);
            // 
            // btGantiGenre
            // 
            this.btGantiGenre.BorderRadius = 5;
            this.btGantiGenre.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btGantiGenre.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(194)))));
            this.btGantiGenre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(194)))));
            this.btGantiGenre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btGantiGenre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(194)))));
            this.btGantiGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGantiGenre.ForeColor = System.Drawing.Color.White;
            this.btGantiGenre.Location = new System.Drawing.Point(31, 508);
            this.btGantiGenre.Name = "btGantiGenre";
            this.btGantiGenre.Size = new System.Drawing.Size(150, 31);
            this.btGantiGenre.TabIndex = 32;
            this.btGantiGenre.Tag = "0";
            this.btGantiGenre.Text = "Ganti Genre";
            this.btGantiGenre.Click += new System.EventHandler(this.btGantiGenre_Click);
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
            // btUpdate
            // 
            this.btUpdate.BorderRadius = 5;
            this.btUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(194)))));
            this.btUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(194)))));
            this.btUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(194)))));
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.ForeColor = System.Drawing.Color.White;
            this.btUpdate.Location = new System.Drawing.Point(31, 277);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(160, 31);
            this.btUpdate.TabIndex = 33;
            this.btUpdate.Tag = "0";
            this.btUpdate.Text = "Update";
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // FormBooksAdminClicked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(765, 560);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btGantiGenre);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.lbBack);
            this.Controls.Add(this.pnBook);
            this.Controls.Add(this.btEditData);
            this.Controls.Add(this.pnForm);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBooksAdminClicked";
            this.Text = "FormBooksAdminClicked";
            this.Load += new System.EventHandler(this.FormBooksAdminClicked_Load);
            this.pnBook.ResumeLayout(false);
            this.pnBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPublishDate)).EndInit();
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
        private Guna.UI2.WinForms.Guna2TextBox tbBookTitle;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPublisher;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbBookTItle;
        private Guna.UI2.WinForms.Guna2Button btEditData;
        private System.Windows.Forms.Panel pnForm;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbTelephone;
        private Guna.UI2.WinForms.Guna2TextBox tbBorrowerUsername;
        private System.Windows.Forms.Label lbFullName;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateBorrowed;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateReturned;
        private Guna.UI2.WinForms.Guna2TextBox tbGenre;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericPublishDate;
        private Guna.UI2.WinForms.Guna2ComboBox cbLocation;
        private System.Windows.Forms.CheckedListBox cbGenre;
        private Guna.UI2.WinForms.Guna2Button btGantiGenre;
        private Guna.UI2.WinForms.Guna2Button btAuthorChange;
        private Guna.UI2.WinForms.Guna2Button btPenerbit;
        private Guna.UI2.WinForms.Guna2TextBox tbPublisher;
        public Guna.UI2.WinForms.Guna2TextBox tbAuthor;
        private Guna.UI2.WinForms.Guna2Button btUpdate;
    }
}