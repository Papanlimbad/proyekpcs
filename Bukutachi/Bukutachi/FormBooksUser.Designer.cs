
namespace Bukutachi
{
    partial class FormBooksUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBooksUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnSearch = new System.Windows.Forms.Panel();
            this.rbDesc = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbAsc = new Guna.UI2.WinForms.Guna2RadioButton();
            this.cbSortBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.cbSearchBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbSort = new System.Windows.Forms.Label();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbGenre = new System.Windows.Forms.Label();
            this.tbUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dgvBorrowedBooks = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.pnSearch;
            // 
            // pnSearch
            // 
            this.pnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.pnSearch.Controls.Add(this.rbDesc);
            this.pnSearch.Controls.Add(this.rbAsc);
            this.pnSearch.Controls.Add(this.cbSortBy);
            this.pnSearch.Controls.Add(this.label1);
            this.pnSearch.Controls.Add(this.guna2Button1);
            this.pnSearch.Controls.Add(this.cbSearchBy);
            this.pnSearch.Controls.Add(this.lbSort);
            this.pnSearch.Controls.Add(this.cbFilter);
            this.pnSearch.Controls.Add(this.lbGenre);
            this.pnSearch.Controls.Add(this.tbUsername);
            this.pnSearch.Location = new System.Drawing.Point(13, 13);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(740, 130);
            this.pnSearch.TabIndex = 0;
            // 
            // rbDesc
            // 
            this.rbDesc.AutoSize = true;
            this.rbDesc.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbDesc.CheckedState.BorderThickness = 0;
            this.rbDesc.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbDesc.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbDesc.CheckedState.InnerOffset = -4;
            this.rbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDesc.ForeColor = System.Drawing.Color.White;
            this.rbDesc.Location = new System.Drawing.Point(484, 97);
            this.rbDesc.Name = "rbDesc";
            this.rbDesc.Size = new System.Drawing.Size(114, 22);
            this.rbDesc.TabIndex = 15;
            this.rbDesc.Text = "Descending";
            this.rbDesc.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbDesc.UncheckedState.BorderThickness = 2;
            this.rbDesc.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbDesc.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbDesc.CheckedChanged += new System.EventHandler(this.rbDesc_CheckedChanged);
            // 
            // rbAsc
            // 
            this.rbAsc.AutoSize = true;
            this.rbAsc.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAsc.CheckedState.BorderThickness = 0;
            this.rbAsc.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAsc.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbAsc.CheckedState.InnerOffset = -4;
            this.rbAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAsc.ForeColor = System.Drawing.Color.White;
            this.rbAsc.Location = new System.Drawing.Point(327, 97);
            this.rbAsc.Name = "rbAsc";
            this.rbAsc.Size = new System.Drawing.Size(103, 22);
            this.rbAsc.TabIndex = 14;
            this.rbAsc.Text = "Ascending";
            this.rbAsc.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbAsc.UncheckedState.BorderThickness = 2;
            this.rbAsc.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAsc.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbAsc.CheckedChanged += new System.EventHandler(this.rbAsc_CheckedChanged);
            // 
            // cbSortBy
            // 
            this.cbSortBy.BackColor = System.Drawing.Color.Transparent;
            this.cbSortBy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbSortBy.BorderRadius = 7;
            this.cbSortBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortBy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbSortBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSortBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSortBy.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbSortBy.ForeColor = System.Drawing.Color.White;
            this.cbSortBy.ItemHeight = 25;
            this.cbSortBy.Items.AddRange(new object[] {
            "Title",
            "Author",
            "Published Date"});
            this.cbSortBy.Location = new System.Drawing.Point(90, 90);
            this.cbSortBy.Name = "cbSortBy";
            this.cbSortBy.Size = new System.Drawing.Size(219, 31);
            this.cbSortBy.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sort By";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(660, 14);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(65, 105);
            this.guna2Button1.TabIndex = 11;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // cbSearchBy
            // 
            this.cbSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.cbSearchBy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbSearchBy.BorderRadius = 7;
            this.cbSearchBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchBy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbSearchBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearchBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearchBy.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbSearchBy.ForeColor = System.Drawing.Color.White;
            this.cbSearchBy.ItemHeight = 25;
            this.cbSearchBy.Items.AddRange(new object[] {
            "Title",
            "Author",
            "Publisher",
            "-"});
            this.cbSearchBy.Location = new System.Drawing.Point(425, 52);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.Size = new System.Drawing.Size(227, 31);
            this.cbSearchBy.TabIndex = 9;
            // 
            // lbSort
            // 
            this.lbSort.AutoSize = true;
            this.lbSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSort.ForeColor = System.Drawing.Color.White;
            this.lbSort.Location = new System.Drawing.Point(324, 56);
            this.lbSort.Name = "lbSort";
            this.lbSort.Size = new System.Drawing.Size(85, 18);
            this.lbSort.TabIndex = 8;
            this.lbSort.Text = "Search By";
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbFilter.BorderRadius = 7;
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbFilter.ForeColor = System.Drawing.Color.White;
            this.cbFilter.ItemHeight = 25;
            this.cbFilter.Items.AddRange(new object[] {
            "All"});
            this.cbFilter.Location = new System.Drawing.Point(90, 51);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(219, 31);
            this.cbFilter.TabIndex = 7;
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenre.ForeColor = System.Drawing.Color.White;
            this.lbGenre.Location = new System.Drawing.Point(20, 56);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(54, 18);
            this.lbGenre.TabIndex = 6;
            this.lbGenre.Text = "Genre";
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
            this.tbUsername.Location = new System.Drawing.Point(20, 14);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.PlaceholderText = "Search Book Name Here...";
            this.tbUsername.SelectedText = "";
            this.tbUsername.Size = new System.Drawing.Size(632, 31);
            this.tbUsername.TabIndex = 5;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.dgvBorrowedBooks;
            // 
            // dgvBorrowedBooks
            // 
            this.dgvBorrowedBooks.AllowUserToAddRows = false;
            this.dgvBorrowedBooks.AllowUserToDeleteRows = false;
            this.dgvBorrowedBooks.AllowUserToResizeColumns = false;
            this.dgvBorrowedBooks.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBorrowedBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBorrowedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBorrowedBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.dgvBorrowedBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBorrowedBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBorrowedBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrowedBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBorrowedBooks.ColumnHeadersHeight = 21;
            this.dgvBorrowedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBorrowedBooks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBorrowedBooks.EnableHeadersVisualStyles = false;
            this.dgvBorrowedBooks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvBorrowedBooks.Location = new System.Drawing.Point(12, 160);
            this.dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            this.dgvBorrowedBooks.ReadOnly = true;
            this.dgvBorrowedBooks.RowHeadersVisible = false;
            this.dgvBorrowedBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBorrowedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowedBooks.Size = new System.Drawing.Size(740, 388);
            this.dgvBorrowedBooks.TabIndex = 1;
            this.dgvBorrowedBooks.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dgvBorrowedBooks.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dgvBorrowedBooks.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBorrowedBooks.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBorrowedBooks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBorrowedBooks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBorrowedBooks.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.dgvBorrowedBooks.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvBorrowedBooks.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.dgvBorrowedBooks.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBorrowedBooks.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBorrowedBooks.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBorrowedBooks.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBorrowedBooks.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvBorrowedBooks.ThemeStyle.ReadOnly = true;
            this.dgvBorrowedBooks.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.dgvBorrowedBooks.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBorrowedBooks.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBorrowedBooks.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvBorrowedBooks.ThemeStyle.RowsStyle.Height = 22;
            this.dgvBorrowedBooks.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.dgvBorrowedBooks.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // FormBooksUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(765, 560);
            this.Controls.Add(this.dgvBorrowedBooks);
            this.Controls.Add(this.pnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBooksUser";
            this.Text = "FormBooksUser";
            this.Load += new System.EventHandler(this.FormBooksUser_Load);
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel pnSearch;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2TextBox tbUsername;
        private System.Windows.Forms.Label lbGenre;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private System.Windows.Forms.Label lbSort;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearchBy;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ComboBox cbSortBy;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBorrowedBooks;
        private Guna.UI2.WinForms.Guna2RadioButton rbDesc;
        private Guna.UI2.WinForms.Guna2RadioButton rbAsc;
    }
}