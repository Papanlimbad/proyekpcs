
namespace Bukutachi
{
    partial class FormEditUsersAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditUsersAdmin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnSearch = new System.Windows.Forms.Panel();
            this.btSearch = new Guna.UI2.WinForms.Guna2Button();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbSearchBy = new System.Windows.Forms.Label();
            this.tbUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dgvUser = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btAdd = new Guna.UI2.WinForms.Guna2Button();
            this.rbDesc = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbAsc = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btReset = new Guna.UI2.WinForms.Guna2Button();
            this.pnSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
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
            this.pnSearch.Controls.Add(this.btSearch);
            this.pnSearch.Controls.Add(this.cbFilter);
            this.pnSearch.Controls.Add(this.lbSearchBy);
            this.pnSearch.Controls.Add(this.tbUsername);
            this.pnSearch.Location = new System.Drawing.Point(13, 13);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(740, 89);
            this.pnSearch.TabIndex = 5;
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
            "Name",
            "Username"});
            this.cbFilter.Location = new System.Drawing.Point(112, 52);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(259, 31);
            this.cbFilter.TabIndex = 7;
            // 
            // lbSearchBy
            // 
            this.lbSearchBy.AutoSize = true;
            this.lbSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchBy.ForeColor = System.Drawing.Color.White;
            this.lbSearchBy.Location = new System.Drawing.Point(17, 57);
            this.lbSearchBy.Name = "lbSearchBy";
            this.lbSearchBy.Size = new System.Drawing.Size(85, 18);
            this.lbSearchBy.TabIndex = 6;
            this.lbSearchBy.Text = "Search By";
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
            this.tbUsername.PlaceholderText = "Search username here...";
            this.tbUsername.SelectedText = "";
            this.tbUsername.Size = new System.Drawing.Size(632, 31);
            this.tbUsername.TabIndex = 5;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.dgvUser;
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AllowUserToResizeColumns = false;
            this.dgvUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUser.ColumnHeadersHeight = 21;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUser.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUser.EnableHeadersVisualStyles = false;
            this.dgvUser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvUser.Location = new System.Drawing.Point(12, 114);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(740, 393);
            this.dgvUser.TabIndex = 36;
            this.dgvUser.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dgvUser.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dgvUser.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUser.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUser.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUser.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUser.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.dgvUser.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvUser.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.dgvUser.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUser.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUser.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUser.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUser.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvUser.ThemeStyle.ReadOnly = true;
            this.dgvUser.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.dgvUser.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUser.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUser.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvUser.ThemeStyle.RowsStyle.Height = 22;
            this.dgvUser.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.dgvUser.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUser.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUser_CellMouseDoubleClick);
            // 
            // btAdd
            // 
            this.btAdd.BorderRadius = 5;
            this.btAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(194)))));
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Location = new System.Drawing.Point(634, 513);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(118, 35);
            this.btAdd.TabIndex = 37;
            this.btAdd.Text = "Add User";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
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
            this.rbDesc.Location = new System.Drawing.Point(513, 57);
            this.rbDesc.Name = "rbDesc";
            this.rbDesc.Size = new System.Drawing.Size(114, 22);
            this.rbDesc.TabIndex = 39;
            this.rbDesc.Text = "Descending";
            this.rbDesc.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbDesc.UncheckedState.BorderThickness = 2;
            this.rbDesc.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbDesc.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbAsc
            // 
            this.rbAsc.AutoSize = true;
            this.rbAsc.Checked = true;
            this.rbAsc.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAsc.CheckedState.BorderThickness = 0;
            this.rbAsc.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAsc.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbAsc.CheckedState.InnerOffset = -4;
            this.rbAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAsc.ForeColor = System.Drawing.Color.White;
            this.rbAsc.Location = new System.Drawing.Point(391, 57);
            this.rbAsc.Name = "rbAsc";
            this.rbAsc.Size = new System.Drawing.Size(103, 22);
            this.rbAsc.TabIndex = 38;
            this.rbAsc.TabStop = true;
            this.rbAsc.Text = "Ascending";
            this.rbAsc.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbAsc.UncheckedState.BorderThickness = 2;
            this.rbAsc.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAsc.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
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
            this.btReset.Location = new System.Drawing.Point(497, 513);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(120, 35);
            this.btReset.TabIndex = 38;
            this.btReset.Text = "Reset";
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // FormEditUsersAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(765, 560);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.pnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditUsersAdmin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormEditUsersAdmin_Load);
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Panel pnSearch;
        private Guna.UI2.WinForms.Guna2Button btSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private System.Windows.Forms.Label lbSearchBy;
        private Guna.UI2.WinForms.Guna2TextBox tbUsername;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUser;
        private Guna.UI2.WinForms.Guna2Button btAdd;
        private Guna.UI2.WinForms.Guna2RadioButton rbDesc;
        private Guna.UI2.WinForms.Guna2RadioButton rbAsc;
        private Guna.UI2.WinForms.Guna2Button btReset;
    }
}