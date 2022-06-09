
namespace Bukutachi
{
    partial class FormBorrowedAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBorrowedAdmin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.btSearch = new Guna.UI2.WinForms.Guna2Button();
            this.lbFrom = new System.Windows.Forms.Label();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbSearchBy = new System.Windows.Forms.Label();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dtFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbTo = new System.Windows.Forms.Label();
            this.dtTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvBorrow = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btReset = new Guna.UI2.WinForms.Guna2Button();
            this.pnSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSearch
            // 
            this.pnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.pnSearch.Controls.Add(this.cbStatus);
            this.pnSearch.Controls.Add(this.lbStatus);
            this.pnSearch.Controls.Add(this.dtTo);
            this.pnSearch.Controls.Add(this.lbTo);
            this.pnSearch.Controls.Add(this.dtFrom);
            this.pnSearch.Controls.Add(this.btSearch);
            this.pnSearch.Controls.Add(this.lbFrom);
            this.pnSearch.Controls.Add(this.cbFilter);
            this.pnSearch.Controls.Add(this.lbSearchBy);
            this.pnSearch.Controls.Add(this.tbSearch);
            this.pnSearch.Location = new System.Drawing.Point(13, 13);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(740, 89);
            this.pnSearch.TabIndex = 3;
            // 
            // btSearch
            // 
            this.btSearch.BorderRadius = 10;
            this.btSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btSearch.ForeColor = System.Drawing.Color.White;
            this.btSearch.Image = ((System.Drawing.Image)(resources.GetObject("btSearch.Image")));
            this.btSearch.ImageSize = new System.Drawing.Size(40, 40);
            this.btSearch.Location = new System.Drawing.Point(660, 14);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(65, 65);
            this.btSearch.TabIndex = 11;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrom.ForeColor = System.Drawing.Color.White;
            this.lbFrom.Location = new System.Drawing.Point(24, 56);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(48, 18);
            this.lbFrom.TabIndex = 8;
            this.lbFrom.Text = "From";
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
            "Member\'s Name",
            "Book\'s Title"});
            this.cbFilter.Location = new System.Drawing.Point(494, 14);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(158, 31);
            this.cbFilter.TabIndex = 7;
            // 
            // lbSearchBy
            // 
            this.lbSearchBy.AutoSize = true;
            this.lbSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchBy.ForeColor = System.Drawing.Color.White;
            this.lbSearchBy.Location = new System.Drawing.Point(400, 19);
            this.lbSearchBy.Name = "lbSearchBy";
            this.lbSearchBy.Size = new System.Drawing.Size(85, 18);
            this.lbSearchBy.TabIndex = 6;
            this.lbSearchBy.Text = "Search By";
            // 
            // tbSearch
            // 
            this.tbSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.tbSearch.BorderRadius = 7;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultText = "";
            this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.White;
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.Location = new System.Drawing.Point(20, 14);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderText = "Search...";
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(373, 31);
            this.tbSearch.TabIndex = 5;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.dgvBorrow;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.pnSearch;
            // 
            // dtFrom
            // 
            this.dtFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.dtFrom.BorderRadius = 7;
            this.dtFrom.BorderThickness = 1;
            this.dtFrom.Checked = true;
            this.dtFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dtFrom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dtFrom.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtFrom.ForeColor = System.Drawing.Color.White;
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtFrom.Location = new System.Drawing.Point(75, 51);
            this.dtFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(141, 31);
            this.dtFrom.TabIndex = 47;
            this.dtFrom.Value = new System.DateTime(2022, 6, 4, 19, 40, 49, 536);
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTo.ForeColor = System.Drawing.Color.White;
            this.lbTo.Location = new System.Drawing.Point(220, 56);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(28, 18);
            this.lbTo.TabIndex = 48;
            this.lbTo.Text = "To";
            // 
            // dtTo
            // 
            this.dtTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.dtTo.BorderRadius = 7;
            this.dtTo.BorderThickness = 1;
            this.dtTo.Checked = true;
            this.dtTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dtTo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dtTo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtTo.ForeColor = System.Drawing.Color.White;
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtTo.Location = new System.Drawing.Point(252, 52);
            this.dtTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(141, 31);
            this.dtTo.TabIndex = 49;
            this.dtTo.Value = new System.DateTime(2022, 6, 4, 19, 40, 49, 536);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.White;
            this.lbStatus.Location = new System.Drawing.Point(400, 56);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(56, 18);
            this.lbStatus.TabIndex = 50;
            this.lbStatus.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbStatus.BorderRadius = 7;
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbStatus.ForeColor = System.Drawing.Color.White;
            this.cbStatus.ItemHeight = 25;
            this.cbStatus.Items.AddRange(new object[] {
            "Standby",
            "Borrowing",
            "Complete"});
            this.cbStatus.Location = new System.Drawing.Point(462, 51);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(190, 31);
            this.cbStatus.TabIndex = 51;
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.AllowUserToAddRows = false;
            this.dgvBorrow.AllowUserToDeleteRows = false;
            this.dgvBorrow.AllowUserToResizeColumns = false;
            this.dgvBorrow.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBorrow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBorrow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBorrow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.dgvBorrow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBorrow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBorrow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBorrow.ColumnHeadersHeight = 21;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBorrow.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvBorrow.EnableHeadersVisualStyles = false;
            this.dgvBorrow.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvBorrow.Location = new System.Drawing.Point(13, 114);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.ReadOnly = true;
            this.dgvBorrow.RowHeadersVisible = false;
            this.dgvBorrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrow.Size = new System.Drawing.Size(740, 393);
            this.dgvBorrow.TabIndex = 37;
            this.dgvBorrow.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dgvBorrow.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dgvBorrow.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBorrow.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBorrow.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBorrow.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBorrow.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.dgvBorrow.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvBorrow.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.dgvBorrow.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBorrow.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBorrow.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBorrow.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBorrow.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvBorrow.ThemeStyle.ReadOnly = true;
            this.dgvBorrow.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.dgvBorrow.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBorrow.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBorrow.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvBorrow.ThemeStyle.RowsStyle.Height = 22;
            this.dgvBorrow.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.dgvBorrow.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // btReset
            // 
            this.btReset.BorderRadius = 5;
            this.btReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btReset.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(194)))));
            this.btReset.Location = new System.Drawing.Point(633, 513);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(120, 35);
            this.btReset.TabIndex = 39;
            this.btReset.Text = "Reset";
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // FormBorrowedAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(765, 560);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.dgvBorrow);
            this.Controls.Add(this.pnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBorrowedAdmin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormBorrowedAdmin_Load);
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnSearch;
        private Guna.UI2.WinForms.Guna2Button btSearch;
        private System.Windows.Forms.Label lbFrom;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private System.Windows.Forms.Label lbSearchBy;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtTo;
        private System.Windows.Forms.Label lbTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtFrom;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
        private System.Windows.Forms.Label lbStatus;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBorrow;
        private Guna.UI2.WinForms.Guna2Button btReset;
    }
}