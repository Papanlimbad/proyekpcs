using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Bukutachi
{
    public partial class FormBooksUser : Form
    {
        MySqlConnection conn;
        String[] user = new string[8];
        public FormBooksUser(MySqlConnection conn, String[] user)
        {
            InitializeComponent();
            this.conn = conn;
            this.user = user;
            rbAsc.Checked = Enabled;
            cbFilter.SelectedIndex = 0;
            cbSearchBy.SelectedIndex = 0;
            cbSortBy.SelectedIndex = 0;
            //loadProFunc();
            loadDataGrid();
            loadcombobox();
        }
        private void loadProFunc()
        {
            //kalau ini ga dipake tetep bisa kerja di db user kah?

            String kueri = @"DELIMITER $$
            CREATE OR REPLACE FUNCTION GENRE(
             title VARCHAR(200)
            )RETURNS VARCHAR(200)
            BEGIN
             DECLARE hasil VARCHAR(1000) DEFAULT '';	
             DECLARE genre VARCHAR(20);	 		
             DECLARE ctr INT DEFAULT 0;		
             DECLARE done INT DEFAULT 0;			

            DECLARE curs CURSOR FOR 
            SELECT ge.ge_name AS 'Genre'
            FROM buku bu
            INNER JOIN genre_buku gb ON gb.gb_bu_id = bu.bu_id
            INNER JOIN genre ge ON ge.ge_id = gb.gb_ge_id
            WHERE bu.bu_title = title
            ORDER BY 1;

             DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;
             OPEN curs;
             printinganu : LOOP
               FETCH curs INTO genre; #ambil 1 row
               SET ctr = ctr + 1;
               IF done = 1 THEN
                LEAVE printinganu;
               END IF;
               IF ctr < 2 THEN
	               SET hasil = 	genre;
               ELSE
	               SET hasil = 	CONCAT(hasil,', ',genre);
               END IF;
              END LOOP;
             CLOSE curs;
             RETURN hasil;
            END$$
            DELIMITER ;

            DELIMITER $$
            CREATE OR REPLACE FUNCTION AUTHOR(
             title VARCHAR(200)
            )RETURNS VARCHAR(200)
            BEGIN
             DECLARE hasil VARCHAR(1000) DEFAULT '';	
             DECLARE author VARCHAR(20);	 		
             DECLARE ctr INT DEFAULT 0;		
             DECLARE done INT DEFAULT 0;			

            DECLARE curs CURSOR FOR 
            SELECT ps.ps_name AS 'Author'
            FROM buku bu
            INNER JOIN buku_penulis bp ON bu.bu_id = bp.bp_bu_id
            INNER JOIN penulis ps ON ps.ps_id = bp.bp_ps_id
            WHERE bu.bu_title = title
            ORDER BY 1;

             DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;
             OPEN curs;
             printinganu : LOOP
               FETCH curs INTO author; #ambil 1 row
               SET ctr = ctr + 1;
               IF done = 1 THEN
                LEAVE printinganu;
               END IF;
               IF ctr < 2 THEN
	               SET hasil = 	author;
               ELSE
	               SET hasil = 	CONCAT(hasil,', ',author);
               END IF;
              END LOOP;
             CLOSE curs;
             RETURN hasil;
            END$$
            DELIMITER ;
            ";


            MySqlCommand cmd = new MySqlCommand(kueri, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void loadDataGrid()
        {
            String kueri = @"SELECT bu.bu_id,
            bu.bu_title AS 'Title',
            GROUP_CONCAT(DISTINCT ge.ge_name) AS 'Genre',
            GROUP_CONCAT(DISTINCT ps.ps_name) AS 'Author',
            pt.pt_name AS 'Publisher',
            bu.bu_publishedat AS 'Published Year'
            FROM buku bu
            JOIN penerbit pt ON bu.bu_pt_id = pt.pt_id
            JOIN buku_penulis bp ON bu.bu_id = bp.bp_bu_id
            JOIN penulis ps ON ps.ps_id = bp.bp_ps_id
            JOIN genre_buku gb ON gb.gb_bu_id = bu.bu_id
            JOIN genre ge ON gb.gb_ge_id = ge.ge_id

            ";
            //search
            if(!cbSearchBy.Text.Equals("-"))
            {
                if (cbSearchBy.Text.Equals("Title"))
                {
                    kueri += "WHERE bu.bu_title LIKE '%"+tbUsername.Text+"%'";
                } else if (cbSearchBy.Text.Equals("Author")) {
                    kueri += "WHERE ps.ps_name LIKE '%" + tbUsername.Text + "%'";
                } else if (cbSearchBy.Text.Equals("Publisher")) {
                    kueri += "WHERE pt.pt_name LIKE '%" + tbUsername.Text + "%'";
                }
            }

            //genre
            if (!cbFilter.Text.Equals("All"))
            {
                kueri += " AND ge.ge_name = '"+cbFilter.Text+"'";
            }
            kueri += "            GROUP BY bu.bu_title";

            //tipe sort
            if (cbSortBy.Text.Equals("Title"))
            {
                kueri += " ORDER BY 1";
            } else if (cbSortBy.Text.Equals("Author")){
                kueri += " ORDER BY 3";
            } else if (cbSortBy.Text.Equals("Published Date")){
                kueri += " ORDER BY 5";
            }
            //asc desc
            if (rbAsc.Checked==true)
            {
                kueri += " ASC;";
            }
            else
            {
                kueri += " DESC;";
            }

            MySqlCommand cmd = new MySqlCommand(kueri, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet dsBorrowed = new DataSet();
            da.Fill(dsBorrowed);
            dgvBorrowedBooks.DataSource = dsBorrowed.Tables[0].DefaultView;
            dgvBorrowedBooks.Columns[0].Visible = false;
        }
        private void loadcombobox()
        {
            string query = "SELECT ge_name AS \"Jenis\" FROM genre";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            conn.Open();
            cmd.ExecuteReader();
            conn.Close();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dtGenre = new DataTable();
            
            da.Fill(dtGenre);
            DataRow rowbaru;
            rowbaru = dtGenre.NewRow();
            rowbaru["Jenis"] = "All";
            dtGenre.Rows.InsertAt(rowbaru,0);
            cbFilter.DisplayMember = "Jenis";
            cbFilter.DataSource = dtGenre.DefaultView;
            cbFilter.SelectedIndex = 0;
        }


        private void FormBooksUser_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvBorrowedBooks.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

 

        private void rbAsc_CheckedChanged(object sender, EventArgs e)
        {
            //rbDesc.Checked = false;
            //rbAsc.Checked = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loadDataGrid();
        }

        private void rbDesc_CheckedChanged(object sender, EventArgs e)
        {
            //rbAsc.Checked = false;
            //rbDesc.Checked = true;
        }

        private void dgvBorrowedBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ((HomeUser)(this.Parent.Parent)).loadForm(new FormBooksUserClicked(conn,Convert.ToInt32( dgvBorrowedBooks.Rows[e.RowIndex].Cells[0].Value ), this));
        }
    }
}
