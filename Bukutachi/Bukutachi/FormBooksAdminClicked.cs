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

        public FormBooksAdminClicked(MySqlConnection conn, int id, Form lastPage, String[] user)
        {
            InitializeComponent();
            bookId = id;
            this.conn = conn;
            this.lastPage = lastPage;
            this.idpinjam = idpinjam;
            this.user = user;


            LoadComboPenulis(sqlpenulis, "ps_name", "ps_id");
            LoadComboPublisher(sqlpublisher, "pt_name", "pt_id");
        }

        private void btEditData_Click(object sender, EventArgs e)
        {
            if (tbBookTitle.Text=="" || cbAuthor.Text=="" || tbGenre.Text==""||cbPublisher.Text==""||tbLocation.Text==""||tbPublishDate.Text=="")
            {
                MessageBox.Show("Field Harus Diisi Semua!");
            }
            else
            {
                Regex re = new Regex("^[0-9]+$");
                if (!re.IsMatch(tbLocation.Text) ||!re.IsMatch(tbPublishDate.Text))
                {
                    MessageBox.Show("Lokasi Rak Buku atau Tahun Rilis Harus di isi Angka!");
                }
                else
                {
                    string ambiltitle = tbBookTitle.Text;
                    string ambilpenerbit = cbPublisher.Text;
                    int ambiltahun = Convert.ToInt32(tbPublishDate.Text);
                    int rakbuku = Convert.ToInt32(tbLocation.Text);
                    string ambilgenrebuku = tbGenre.Text;
                    string ambilauthor = cbAuthor.Text;

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
                SELECT bu.bu_title AS 'Title', GROUP_CONCAT(DISTINCT ps.ps_name) AS 'Author', GROUP_CONCAT(DISTINCT ge.ge_name) AS 'Genres', bu.bu_publishedat AS 'Publish Date', pt.pt_name AS 'Publisher', bu.bu_rb_id AS 'Location', bu.bu_status AS 'Status', bu.bu_synopsis AS 'Description', bu.bu_large AS 'Image', h.hp_me_id AS 'Pinjam', me.me_name AS 'Member', h.hp_borrowedat AS 'borrowdate', h.hp_returnat AS 'returndate'
                FROM buku bu 
                JOIN penerbit pt ON bu.bu_pt_id = pt.pt_id
                JOIN buku_penulis bp ON bu.bu_id = bp.bp_bu_id
                JOIN penulis ps ON ps.ps_id = bp.bp_ps_id
                JOIN genre_buku gb ON gb.gb_bu_id = bu.bu_id
                JOIN genre ge ON gb.gb_ge_id = ge.ge_id
                LEFT JOIN hpinjam h ON hp_id=bu_id 
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
            cbAuthor.Text = dt.Rows[0]["Author"].ToString();
            tbGenre.Text = dt.Rows[0]["Genres"].ToString();
            cbPublisher.Text = dt.Rows[0]["Publisher"].ToString();
            tbPublishDate.Text = dt.Rows[0]["Publish Date"].ToString();
            tbLocation.Text = $"{dt.Rows[0]["Location"]}";
            guna2PictureBox1.Image= WebImage.resizeImage(WebImage.fromUrl(dt.Rows[0]["Image"].ToString()), guna2PictureBox1.Width, guna2PictureBox1.Height);
            
           
           
            //Form Borrow

            tbBookName.Text= dt.Rows[0]["Title"].ToString();
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
        }

        private void btCreateForm_Click(object sender, EventArgs e)
        {

        }

        private void DateBorrow_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LoadComboPenulis(string sqlpenulis, string DisplayMember, string ValueMember)
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

                cbAuthor.DataSource = dt;
                cbAuthor.DisplayMember = DisplayMember;
                cbAuthor.ValueMember = ValueMember;
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

       

        private void LoadComboPublisher(string sqlpublisher, string DisplayMember, string ValueMember)
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
        }
    }
}
