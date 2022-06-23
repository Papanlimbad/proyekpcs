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

        string inigenre;
        string sqlpenulis;
        string sqlpublisher;
        MySqlDataAdapter da;
        DataTable dt;
        string namabuku;
        string sqllocation;
        string sqlgenre;
        string tesauthor;
        string hasil;

        public static string iniauthor="";
        public static string inipenerbit = "";
        string termids;
        string text;



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
            LoadComboPenulis(sqlpenulis, "ps_name", "ps_id");
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
                    MySqlCommand cmd4 = new MySqlCommand("update buku_penulis set bp_ps_id=?penulisid where bp_bu_id=?cekbuku2",conn);
                    MySqlCommand cmd5 = new MySqlCommand("update buku set bu_title=?bukutitle where bu_title=?cekbukutitle",conn);

                    cmd2.Parameters.Add(new MySqlParameter("cektitle", namabuku));
                    cmd2.Parameters.Add(new MySqlParameter("title", ambiltitle));
                    cmd2.Parameters.Add(new MySqlParameter("idpenerbit", namapublisher));
                    cmd2.Parameters.Add(new MySqlParameter("publishdate", ambiltahun));
                    cmd2.Parameters.Add(new MySqlParameter("rakbuku", rakbuku));

                    cmd4.Parameters.Add(new MySqlParameter("cekbuku2", idbuku));
                    cmd4.Parameters.Add(new MySqlParameter("penulisid", idauthor));

                    cmd5.Parameters.Add(new MySqlParameter("cekbukutitle", ambiltitle));
                    cmd5.Parameters.Add(new MySqlParameter("bukutitle", ambiltitle));

                    conn.Open();
                    cmd2.ExecuteNonQuery();

                    if (tbAuthor.Text!=ambilauthor) {
                        cmd4.ExecuteNonQuery();
                    }
                    conn.Close();

                    //ambil genre
                    List<string> genreToInsert = new List<string>(tbGenre.Text.Split(','));

                    conn.Open();
                    for (int i = 0; i < genreToInsert.Count; i++)
                    {                     

                        MySqlCommand cmdz = new MySqlCommand("insert into genre_buku(gb_bu_id, gb_ge_id) values(?genrebuku, (SELECT ge_id from genre where ge_name=?genre));", conn);
                        cmdz.Parameters.Add(new MySqlParameter("genrebuku", idbuku));
                        cmdz.Parameters.Add(new MySqlParameter("genre", genreToInsert[i]));

                        cmdz.ExecuteNonQuery();
                    }
                    conn.Close();

                    //ambil author

                    conn.Open();
                    List<string> authorToInsert = new List<string>(tbAuthor.Text.Split(','));

                    for (int i = 0; i < authorToInsert.Count; i++)
                    {
                        MySqlCommand cmdy = new MySqlCommand("insert into buku_penulis(bp_ps_id, bp_bu_id) values((SELECT ps_id from penulis WHERE ps_name = ?penulisid), ?bukuid);", conn);
                        cmdy.Parameters.Add(new MySqlParameter("penulisid", authorToInsert[i]));
                        cmdy.Parameters.Add(new MySqlParameter("bukuid", idbuku));

                        cmdy.ExecuteNonQuery();
                    }
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
            tbPublisher.Text = dt.Rows[0]["Publisher"].ToString();
            numericPublishDate.Text = dt.Rows[0]["Publish Date"].ToString();
            cbLocation.Text = $"{dt.Rows[0]["Location"]}";
            guna2PictureBox1.Image= WebImage.resizeImage(WebImage.fromUrl(dt.Rows[0]["Image"].ToString()), guna2PictureBox1.Width, guna2PictureBox1.Height);
            
           
           
            //Form Borrow




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

                listAuthor.DataSource = dt;
                listAuthor.DisplayMember = DisplayMember;
                listAuthor.ValueMember = ValueMember;
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

                listGenre.DataSource = dt;
                listGenre.DisplayMember = DisplayMember;
                listGenre.ValueMember = ValueMember;
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





        private void cbGenre_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btGantiGenre_Click(object sender, EventArgs e)
        {
            if (tbGenre.Text.Length > 0)
            {
                tbGenre.Text += ",";
            }
            tbGenre.Text += inigenre;
        }


        private void btPenerbit_Click(object sender, EventArgs e)
        {
            BookAdminClickedPenerbit pt = new BookAdminClickedPenerbit(conn);
            pt.ShowDialog();
            tbPublisher.Text = inipenerbit;
            pt.Dispose();
        }

      

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void listBox2_MouseClick(object sender, MouseEventArgs e)
        {

        }



        private void btGantiAuthor_Click(object sender, EventArgs e)
        {
    
                if (tbAuthor.Text.Length > 0)
                {
                    tbAuthor.Text += ",";
                }
                tbAuthor.Text += text;
            
        }

        private void listAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listAuthor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           // text = listAuthor.GetItemText(listAuthor.SelectedItem);
            //MessageBox.Show(text);
         /*   if (!tbAuthor.Text.Contains(tbAuthor.Text))
            {
                if (tbAuthor.Text.Length > 0)
                {
                    tbAuthor.Text += ",";
                }
                tbAuthor.Text +=text;
            }*/
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tbAuthor.Text = "";
        }

        private void listAuthor_MouseClick(object sender, MouseEventArgs e)
        {
            text = listAuthor.GetItemText(listAuthor.SelectedItem);
        }

        private void listGenre_MouseClick(object sender, MouseEventArgs e)
        {
            inigenre = listGenre.GetItemText(listGenre.SelectedItem);

        }

        private void btReset2_Click(object sender, EventArgs e)
        {
            tbGenre.Text = "";
        }

        private void btReset_Click_1(object sender, EventArgs e)
        {
            MySqlCommand cmdd = new MySqlCommand("select bu_id from buku where bu_title=?namabuku", conn);
            cmdd.Parameters.Add(new MySqlParameter("namabuku", namabuku));

            conn.Open();
            int idbuku = Convert.ToInt32(cmdd.ExecuteScalar());
            cmdd.ExecuteScalar();
            conn.Close();


            conn.Open();
            List<string> genreToInsert = new List<string>(tbGenre.Text.Split(','));
            for (int i = 0; i < genreToInsert.Count; i++)
            {

                MySqlCommand cmdz = new MySqlCommand("DELETE FROM genre_buku WHERE gb_bu_id=?genrebuku;", conn);
                cmdz.Parameters.Add(new MySqlParameter("genrebuku", idbuku));
             //   cmdz.Parameters.Add(new MySqlParameter("genre", genreToInsert[i]));

                cmdz.ExecuteNonQuery();
            }
            conn.Close();
            tbGenre.Text = "";
        }

        private void btReset2_Click_1(object sender, EventArgs e)
        {
            MySqlCommand cmdd = new MySqlCommand("select bu_id from buku where bu_title=?namabuku", conn);
            cmdd.Parameters.Add(new MySqlParameter("namabuku", namabuku));

            conn.Open();
            int idbuku = Convert.ToInt32(cmdd.ExecuteScalar());
            cmdd.ExecuteScalar();
            conn.Close();


            conn.Open();
            List<string> genreToInsert = new List<string>(tbGenre.Text.Split(','));
            for (int i = 0; i < genreToInsert.Count; i++)
            {

                MySqlCommand cmdz = new MySqlCommand("DELETE FROM buku_penulis WHERE bp_bu_id=?bukuauthor", conn);
                cmdz.Parameters.Add(new MySqlParameter("bukuauthor", idbuku));
                //   cmdz.Parameters.Add(new MySqlParameter("genre", genreToInsert[i]));

                cmdz.ExecuteNonQuery();
            }
            conn.Close();
            tbAuthor.Text = "";
        }
    }
}
