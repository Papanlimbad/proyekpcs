using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;



namespace Bukutachi
{
    public partial class FormBooksAdminClicked : Form
    {
        int bookId;
        MySqlConnection conn;
        Form lastPage;
        HomeAdmin progadmin;
        string idpinjam;
        MySqlCommand cmd;

        String[] user = new String[8];

        string sqlpenulis;
        string sqlpublisher;
        MySqlDataAdapter da;
        DataTable dt;
        string namabuku;
        string sqllocation;
        string sqlgenre;

        public static string iniauthor="";
        public static string inipenerbit = "";

        

        public FormBooksAdminClicked(MySqlConnection conn, int id, Form lastPage, String[] user)
        {
            InitializeComponent();
            bookId = id;
            this.conn = conn;
            this.lastPage = lastPage;
            this.idpinjam = idpinjam;
            this.user = user;
            tbAuthor.Text = iniauthor;
               

            //LoadComboPenulis(sqlpenulis, "ps_name", "ps_id");
            //LoadComboPublisher(sqlpublisher, "pt_name", "pt_id");
            loadComboLocation(sqllocation, "rb_id", "rb_id");
            LoadComboGenre(sqlgenre, "ge_name", "ge_id");
            this.Refresh();
        }

        private void btEditData_Click(object sender, EventArgs e)
        {
            if (tbBookTitle.Text=="" || tbAuthor.Text=="" || tbGenre.Text==""||tbPublisher.Text==""||cbLocation.Text==""||numericPublishDate.Text=="")
            {
                MessageBox.Show("Field Harus Diisi Semua!");
            }
            else
            {
                Regex re = new Regex("^[0-9]+$");
                if (!re.IsMatch(cbLocation.Text) ||!re.IsMatch(numericPublishDate.Text))
                {
                    MessageBox.Show("Lokasi Rak Buku atau Tahun Rilis Harus di isi Angka!");
                }
                else
                {
                    string ambiltitle = tbBookTitle.Text;
                    string ambilpenerbit = tbPublisher.Text;
                    int ambiltahun = Convert.ToInt32(numericPublishDate.Text);
                    int rakbuku = Convert.ToInt32(cbLocation.Text);
                    string ambilgenrebuku = tbGenre.Text;
                    string ambilauthor = tbAuthor.Text;

                    MySqlCommand cmda = new MySqlCommand("select pt_id from penerbit where pt_name=?publisher", conn);
                    MySqlCommand cmdb = new MySqlCommand("select ge_id from genre where ge_name=?ambilgenre", conn);
                    MySqlCommand cmcc = new MySqlCommand("select ps_id from penulis where ps_name=?ambilpenulis", conn);
                    MySqlCommand cmdd = new MySqlCommand("select bu_id from buku where bu_title=?namabuku", conn);
                    cmda.Parameters.Add(new MySqlParameter("publisher",ambilpenerbit));
                    cmdb.Parameters.Add(new MySqlParameter("ambilgenre",ambilgenrebuku));
                    cmcc.Parameters.Add(new MySqlParameter("ambilpenulis", ambilauthor));
                    cmdd.Parameters.Add(new MySqlParameter("namabuku", namabuku));

                    conn.Open();
                    int idbuku = Convert.ToInt32(cmdd.ExecuteScalar());
                    int namapublisher = Convert.ToInt32(cmda.ExecuteScalar());
                    int idgenre = Convert.ToInt32(cmdb.ExecuteScalar());
                    int idauthor = Convert.ToInt32(cmcc.ExecuteScalar());
                    cmdd.ExecuteNonQuery();
                    conn.Close();


                    MySqlCommand cmd2 = new MySqlCommand("update buku set bu_title=?title, bu_pt_id=?idpenerbit, bu_publishedat=?publishdate, bu_rb_id=?rakbuku where bu_title=?cektitle",conn);
                    MySqlCommand cmd3 = new MySqlCommand("update genre_buku set gb_ge_id=?genreid where gb_bu_id=?cekbuku",conn);
                    MySqlCommand cmd4 = new MySqlCommand("update buku_penulis set bp_ps_id=?penulisid where bp_bu_id=?cekbuku2",conn);
                    MySqlCommand cmd5 = new MySqlCommand("update buku set bu_title=?bukutitle where bu_title=?cekbukutitle",conn);

                    cmd2.Parameters.Add(new MySqlParameter("cektitle", namabuku));
                    cmd2.Parameters.Add(new MySqlParameter("title", ambiltitle));
                    cmd2.Parameters.Add(new MySqlParameter("idpenerbit", namapublisher));
                    cmd2.Parameters.Add(new MySqlParameter("publishdate", ambiltahun));
                    cmd2.Parameters.Add(new MySqlParameter("rakbuku", rakbuku));

                    cmd3.Parameters.Add(new MySqlParameter("cekbuku", idbuku));
                    cmd3.Parameters.Add(new MySqlParameter("genreid", idgenre));

                    cmd4.Parameters.Add(new MySqlParameter("cekbuku2", idbuku));
                    cmd4.Parameters.Add(new MySqlParameter("penulisid", idauthor));

                    cmd5.Parameters.Add(new MySqlParameter("cekbukutitle", ambiltitle));
                    cmd5.Parameters.Add(new MySqlParameter("bukutitle", ambiltitle));

                    conn.Open();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    cmd4.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Berhasil Update Buku");
                }
            }


          // string sql = "update buku set bu_title=?title, ";
        }

        private void FormBooksAdminClicked_Load(object sender, EventArgs e)
        {         
            this.progadmin = ((HomeAdmin)(this.Parent.Parent));
            MySqlCommand cmd = new MySqlCommand(@"
                SELECT bu.bu_title AS 'Title', GROUP_CONCAT(DISTINCT ps.ps_name) AS 'Author', GROUP_CONCAT(DISTINCT ge.ge_name) AS 'Genres', bu.bu_publishedat AS 'Publish Date', pt.pt_name AS 'Publisher', bu.bu_rb_id AS 'Location', bu.bu_status AS 'Status', bu.bu_synopsis AS 'Description', bu.bu_large AS 'Image', h.hp_me_id AS 'Pinjam', me.me_name AS 'Member', h.hp_borrowedat AS 'borrowdate', h.hp_returnat AS 'returndate', dp.dp_hp_id AS 'Pinjam'
                FROM buku bu 
                JOIN penerbit pt ON bu.bu_pt_id = pt.pt_id
                JOIN buku_penulis bp ON bu.bu_id = bp.bp_bu_id
                JOIN penulis ps ON ps.ps_id = bp.bp_ps_id
                JOIN genre_buku gb ON gb.gb_bu_id = bu.bu_id
                JOIN genre ge ON gb.gb_ge_id = ge.ge_id
                LEFT JOIN dpinjam dp ON dp.dp_bu_id = bu.bu_id
                LEFT JOIN hpinjam h ON hp_id=dp_hp_id 
                LEFT JOIN MEMBER me ON me_id=hp_id
                WHERE bu.bu_id = ?ID
                GROUP BY bu.bu_title
            ", conn);

            cmd.Parameters.Add(new MySqlParameter("ID", bookId));

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            tbBookTitle.Text= dt.Rows[0]["Title"].ToString();
            tbAuthor.Text = dt.Rows[0]["Author"].ToString();
            tbGenre.Text = dt.Rows[0]["Genres"].ToString();
            cbGenre.SelectedItem = dt.Rows[0]["Genres"].ToString();
            tbPublisher.Text = dt.Rows[0]["Publisher"].ToString();
            numericPublishDate.Text = dt.Rows[0]["Publish Date"].ToString();
            cbLocation.Text = $"{dt.Rows[0]["Location"]}";
            guna2PictureBox1.Image= WebImage.resizeImage(WebImage.fromUrl(dt.Rows[0]["Image"].ToString()), guna2PictureBox1.Width, guna2PictureBox1.Height);
            
           
           
            //Form Borrow

            tbBorrowerUsername.Text = dt.Rows[0]["Member"].ToString();

            if (tbBorrowerUsername.Text != "")
            {
                DateBorrowed.Value = Convert.ToDateTime(dt.Rows[0]["borrowdate"]);
                DateReturned.Value = Convert.ToDateTime(dt.Rows[0]["returndate"]);
            }



            if (Convert.ToInt32(dt.Rows[0]["Status"]) == 0)
            {
                lbStock.Text = "Status : Lost";
                namabuku = tbBookTitle.Text;
            }
            else if (Convert.ToInt32(dt.Rows[0]["Status"]) == 1)
            {
                lbStock.Text = "Status : Avaible";
                namabuku = tbBookTitle.Text;
            }
            else if (Convert.ToInt32(dt.Rows[0]["Status"]) == 2)
            {
                lbStock.Text = "Status : Borrowed";
                namabuku = tbBookTitle.Text;
            }
        }

        private void lbBack_Click(object sender, EventArgs e)
        {
            ((HomeAdmin)(this.Parent.Parent)).loadadmin(lastPage);
            FormBooksAdmin f = new FormBooksAdmin(conn);
            f.loadDataGrid();
        }

        private void btCreateForm_Click(object sender, EventArgs e)
        {

        }

        private void DateBorrow_ValueChanged(object sender, EventArgs e)
        {

        }

      /*  private void LoadComboPenulis(string sqlpenulis, string DisplayMember, string ValueMember)
        {
            sqlpenulis = "SELECT * FROM penulis ORDER BY ps_name ASC";
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlpenulis;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                tbAuthor.DataSource = dt;
                tbAuthor.DisplayMember = DisplayMember;
                tbAuthor.ValueMember = ValueMember;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
        }*/
        private void loadComboLocation(string sqllocation, string DisplayMember, string ValueMember)
        {
            sqllocation = "SELECT * FROM rak_buku";
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqllocation;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                cbLocation.DataSource = dt;
                cbLocation.DisplayMember = DisplayMember;
                cbLocation.ValueMember = ValueMember;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void LoadComboGenre(string sqlgenre, string DisplayMember, string ValueMember)
        {
            sqlgenre = "SELECT * FROM genre";
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlgenre;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                cbGenre.DataSource = dt;
                cbGenre.DisplayMember = DisplayMember;
                cbGenre.ValueMember = ValueMember;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
       /* private void LoadComboPublisher(string sqlpublisher, string DisplayMember, string ValueMember)
        {
            sqlpublisher = "SELECT * FROM penerbit ORDER BY pt_name ASC";
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlpublisher;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                cbPublisher.DataSource = dt;
                cbPublisher.DisplayMember = DisplayMember;
                cbPublisher.ValueMember = ValueMember;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }*/

        private void pnForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbGenre.SelectedIndex;
            int count = cbGenre.Items.Count;
            string s;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    cbGenre.SetItemChecked(i, false);
                }
            }

        }

        private void cbGenre_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (int ix = 0; ix < cbGenre.Items.Count; ++ix)
                    if (e.Index != ix) cbGenre.SetItemChecked(ix, false);
        }

        private void cbGenre_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btGantiGenre_Click(object sender, EventArgs e)
        {
            string ambilgenre = cbGenre.GetItemText(cbGenre.SelectedItem);
            tbGenre.Text = ambilgenre;
        }

        private void btAuthorChange_Click(object sender, EventArgs e)
        {
            BookAdminClickedAuthor author = new BookAdminClickedAuthor(conn);
            author.ShowDialog();
            author.Dispose();
        }

        private void btPenerbit_Click(object sender, EventArgs e)
        {
            BookAdminClickedPenerbit pt = new BookAdminClickedPenerbit(conn);
            pt.ShowDialog();
            pt.Dispose();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if(inipenerbit!="" && iniauthor != "")
            {
                tbPublisher.Text = inipenerbit;
                tbAuthor.Text = iniauthor;
            }
            else if(inipenerbit=="" && iniauthor != "")
            {
                tbAuthor.Text = iniauthor;
            }
            else if(iniauthor ==""&& inipenerbit != "")
            {
                tbPublisher.Text = inipenerbit;
            }
            else
            {
                MessageBox.Show("Mohon pilih penerbit atau author yang ingin diubah");
            }
         
        }
    }
}
