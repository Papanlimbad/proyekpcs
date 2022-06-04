
namespace Bukutachi
{
    partial class FormAddAuthor
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
            this.pnTitleBar = new System.Windows.Forms.Panel();
            this.btClose = new Guna.UI2.WinForms.Guna2Button();
            this.lbAUTHOR = new System.Windows.Forms.Label();
            this.btBack = new Guna.UI2.WinForms.Guna2Button();
            this.btSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.tbTelp = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTelp = new System.Windows.Forms.Label();
            this.tbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbAuthorName = new System.Windows.Forms.Label();
            this.pnTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTitleBar
            // 
            this.pnTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnTitleBar.Controls.Add(this.btClose);
            this.pnTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnTitleBar.Name = "pnTitleBar";
            this.pnTitleBar.Size = new System.Drawing.Size(444, 35);
            this.pnTitleBar.TabIndex = 2;
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
            this.btClose.Location = new System.Drawing.Point(502, 7);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(20, 20);
            this.btClose.TabIndex = 0;
            this.btClose.Text = "X";
            // 
            // lbAUTHOR
            // 
            this.lbAUTHOR.AutoSize = true;
            this.lbAUTHOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAUTHOR.ForeColor = System.Drawing.Color.White;
            this.lbAUTHOR.Location = new System.Drawing.Point(146, 51);
            this.lbAUTHOR.Name = "lbAUTHOR";
            this.lbAUTHOR.Size = new System.Drawing.Size(158, 37);
            this.lbAUTHOR.TabIndex = 3;
            this.lbAUTHOR.Text = "AUTHOR";
            // 
            // btBack
            // 
            this.btBack.BorderRadius = 5;
            this.btBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btBack.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(194)))));
            this.btBack.Location = new System.Drawing.Point(72, 238);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(120, 35);
            this.btBack.TabIndex = 14;
            this.btBack.Text = "Back";
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btSubmit
            // 
            this.btSubmit.BorderRadius = 5;
            this.btSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(194)))));
            this.btSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubmit.ForeColor = System.Drawing.Color.White;
            this.btSubmit.Location = new System.Drawing.Point(269, 238);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(120, 35);
            this.btSubmit.TabIndex = 13;
            this.btSubmit.Text = "Submit";
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // tbTelp
            // 
            this.tbTelp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.tbTelp.BorderRadius = 7;
            this.tbTelp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTelp.DefaultText = "";
            this.tbTelp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTelp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTelp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTelp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTelp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.tbTelp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTelp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbTelp.ForeColor = System.Drawing.Color.White;
            this.tbTelp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTelp.Location = new System.Drawing.Point(138, 183);
            this.tbTelp.Name = "tbTelp";
            this.tbTelp.PasswordChar = '●';
            this.tbTelp.PlaceholderText = "";
            this.tbTelp.SelectedText = "";
            this.tbTelp.Size = new System.Drawing.Size(294, 26);
            this.tbTelp.TabIndex = 12;
            this.tbTelp.UseSystemPasswordChar = true;
            // 
            // lbTelp
            // 
            this.lbTelp.AutoSize = true;
            this.lbTelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelp.ForeColor = System.Drawing.Color.White;
            this.lbTelp.Location = new System.Drawing.Point(6, 186);
            this.lbTelp.Name = "lbTelp";
            this.lbTelp.Size = new System.Drawing.Size(130, 20);
            this.lbTelp.TabIndex = 11;
            this.lbTelp.Text = "Author Telp   :";
            // 
            // tbName
            // 
            this.tbName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.tbName.BorderRadius = 7;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.DefaultText = "";
            this.tbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.tbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.Location = new System.Drawing.Point(138, 125);
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.PlaceholderText = "";
            this.tbName.SelectedText = "";
            this.tbName.Size = new System.Drawing.Size(294, 26);
            this.tbName.TabIndex = 10;
            this.tbName.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // lbAuthorName
            // 
            this.lbAuthorName.AutoSize = true;
            this.lbAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthorName.ForeColor = System.Drawing.Color.White;
            this.lbAuthorName.Location = new System.Drawing.Point(6, 125);
            this.lbAuthorName.Name = "lbAuthorName";
            this.lbAuthorName.Size = new System.Drawing.Size(136, 20);
            this.lbAuthorName.TabIndex = 9;
            this.lbAuthorName.Text = "Author Name : ";
            // 
            // FormAddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(444, 297);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.tbTelp);
            this.Controls.Add(this.lbTelp);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbAuthorName);
            this.Controls.Add(this.lbAUTHOR);
            this.Controls.Add(this.pnTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddAuthor";
            this.Text = "Form1";
            this.pnTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTitleBar;
        private Guna.UI2.WinForms.Guna2Button btClose;
        private System.Windows.Forms.Label lbAUTHOR;
        private Guna.UI2.WinForms.Guna2Button btBack;
        private Guna.UI2.WinForms.Guna2Button btSubmit;
        private Guna.UI2.WinForms.Guna2TextBox tbTelp;
        private System.Windows.Forms.Label lbTelp;
        private Guna.UI2.WinForms.Guna2TextBox tbName;
        private System.Windows.Forms.Label lbAuthorName;
    }
}