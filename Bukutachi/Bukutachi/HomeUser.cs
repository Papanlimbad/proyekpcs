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
    public partial class HomeUser : Form
    {
        Point posDrag;
        MySqlConnection conn;
        String[] user = new string[8];
        DataSet homeImage;
        List<Int32> cart;


        public HomeUser(MySqlConnection conn, DataSet user)
        {
            InitializeComponent();
            this.conn = conn;
            this.user[0] = user.Tables[0].Rows[0][0].ToString(); // me_id
            this.user[1] = user.Tables[0].Rows[0][1].ToString(); // me_name
            this.user[2] = user.Tables[0].Rows[0][2].ToString(); // me_username
            this.user[3] = user.Tables[0].Rows[0][3].ToString(); // me_password
            this.user[4] = user.Tables[0].Rows[0][4].ToString(); // me_telephone
            this.user[5] = user.Tables[0].Rows[0][5].ToString(); // me_address
            this.user[6] = user.Tables[0].Rows[0][6].ToString(); // me_registeredat
            this.user[7] = user.Tables[0].Rows[0][7].ToString(); //me_status

            homeImage = new DataSet();
            cart = new List<int>();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(MousePosition.X - posDrag.X, MousePosition.Y - posDrag.Y);
            }
        }

        private void pnTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            posDrag = new Point(e.X, e.Y);
        }

        private void HomeUser_Load(object sender, EventArgs e)
        {
            lbHello.Text = "Hello, " + user[1];
            lbHello.Location = new Point(this.Size.Width - lbHello.Size.Width - 20, 41);

            btHome.FillColor = Color.FromArgb(86, 100, 194);
            loadForm(new FormHomeUser(conn, user, homeImage));

            if (!newTransaction()) {
                loadBorrowed();
            }
        }

        public void loadForm(object form)
        {
            if (this.pnMain.Controls.Count > 0)
            {
                this.pnMain.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(f);
            this.pnMain.Tag = f;
            f.Show();

            lbHello.Text = "Hello, " + user[1];
            lbHello.Location = new Point(this.Size.Width - lbHello.Size.Width - 20, 41);
        }

        private void clearButtonFill()
        {
            btHome.FillColor = Color.FromArgb(42, 33, 33);
            btBooks.FillColor = Color.FromArgb(42, 33, 33);
            btHistory.FillColor = Color.FromArgb(42, 33, 33);
            btBorrowed.FillColor = Color.FromArgb(42, 33, 33);
            btProfile.FillColor = Color.FromArgb(42, 33, 33);
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            clearButtonFill();
            btHome.FillColor = Color.FromArgb(86, 100, 194);
            loadForm(new FormHomeUser(conn,user, homeImage));
        }

        private void btBooks_Click(object sender, EventArgs e)
        {
            clearButtonFill();
            btBooks.FillColor = Color.FromArgb(86, 100, 194);
            loadForm(new FormBooksUser(conn,user));
        }

        private void btHistory_Click(object sender, EventArgs e)
        {
            clearButtonFill();
            btHistory.FillColor = Color.FromArgb(86, 100, 194);
            loadForm(new FormHistoryUser(conn,user));
        }

        private void btBorrowed_Click(object sender, EventArgs e)
        {
            clearButtonFill();
            btBorrowed.FillColor = Color.FromArgb(86, 100, 194);
            loadForm(new FormBorrowedUser(conn, cart));
        }

        private void btProfile_Click(object sender, EventArgs e)
        {
            clearButtonFill();
            btProfile.FillColor = Color.FromArgb(86, 100, 194);
            FormProfileUser fpu = new FormProfileUser(conn, user);
            fpu.lbSeeMore1.Click += new EventHandler(lbClick);
            fpu.lbSeeMore2.Click += new EventHandler(lbClick);
            loadForm(fpu);
        }

        public void updateHomeImage(DataSet homeImage) {
            this.homeImage = homeImage;
        }

        public void addBookToCart(int id) {
            if(cart.Count < 3) {
                cart.Add(id);
            }
        }

        public void removeBookFromCart(int id) {
            if (cart.Contains(id)) {
                cart.Remove(id);
            }
        }

        public bool isInCart(int id) {
            return cart.Contains(id);
        }

        private void lbClick(object sender, EventArgs e)
        {
            Label temp = (Label)sender;
            if (temp.Tag.Equals("3"))
            {
                btBorrowed_Click(sender, e);
            }
            else if (temp.Tag.Equals("4"))
            {
                btHistory_Click(sender, e);
            }
        }

        private void btLogout_Click(object sender, EventArgs e) {
            if(cart.Count > 0) {
                if (newTransaction()) {
                    Console.WriteLine("Making new Transaction");
                    makeNewTransaction();
                }
                else {
                    Console.WriteLine("Updating Transaction");
                    if (cart.Count == 0) {
                        cancelTransaction();
                    }
                    else {
                        updateBorrowed();
                    }
                }
            }
            this.Dispose();
        }


        #region Borrowed System

        private bool newTransaction() {
            MySqlCommand cmd = new MySqlCommand(@"
                SELECT hp_id from hpinjam WHERE hp_me_id = ?membid AND hp_status = 0
            ", conn);
            cmd.Parameters.Add(new MySqlParameter("membid", user[0]));

            conn.Open();
            int x = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            if(x == 0) {
                return true;
            }
            return false;
        }

        private void makeNewTransaction() {
            conn.Open();
            using(MySqlTransaction tr = conn.BeginTransaction()) {
                try {
                    MySqlCommand cmd = new MySqlCommand(@"
                        INSERT INTO hpinjam(hp_borrowedat, hp_status, hp_me_id, hp_pe_id) VALUES(CURRENT_DATE(), 0, ?membid, 0)
                    ", conn);
                    cmd.Parameters.Add(new MySqlParameter("membid", user[0]));

                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Header Added");

                    cmd = new MySqlCommand(@"SELECT hp_id from hpinjam WHERE hp_me_id = ?membid AND hp_status = 0 ORDER BY hp_id DESC LIMIT 1;", conn);
                    cmd.Parameters.Add(new MySqlParameter("membid", user[0]));

                    int hpid = Convert.ToInt32(cmd.ExecuteScalar());

                    for (int i = 0; i < cart.Count; i++) {
                        Console.WriteLine($"Adding Book {cart[i]} to Transaction {hpid}...");
                        cmd = new MySqlCommand(@"
                            INSERT INTO dpinjam VALUES(default, ?bookid, ?hpid)
                        ", conn);
                        cmd.Parameters.Add(new MySqlParameter("bookid", cart[i]));
                        cmd.Parameters.Add(new MySqlParameter("hpid", hpid));

                        cmd.ExecuteNonQuery();
                    }

                    tr.Commit();
                }
                catch (MySqlException ex){
                    MessageBox.Show(ex.Message);
                    tr.Rollback();
                }
            }
            conn.Close();
        }

        private void updateBorrowed() {
            int hpid = getLastTransactionId();
            conn.Open();
            MySqlCommand cmd;
            using (MySqlTransaction tr = conn.BeginTransaction()) {
                try {
                    cmd = new MySqlCommand(@"SELECT dp_id as 'transId', dp_bu_id as 'bookId' FROM dpinjam WHERE dp_hp_id=?hpid ORDER BY dp_bu_id", conn);
                    cmd.Parameters.Add(new MySqlParameter("hpid", hpid));

                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    cart.Sort();

                    Dictionary<int, int> detailUpdt= new Dictionary<int, int>();
                    for (int i = 0; i < dt.Rows.Count; i++) {
                        detailUpdt.Add(Convert.ToInt32(dt.Rows[i]["bookId"]), -1);
                    }

                    for (int i = 0; i < cart.Count; i++) {
                        if (detailUpdt.ContainsKey(cart[i])) {
                            detailUpdt[cart[i]] = 0;
                        }
                        else {
                            detailUpdt.Add(cart[i], 1);
                        }
                    }

                    foreach (int key in detailUpdt.Keys) {
                        Console.WriteLine($"Book {key} => {detailUpdt[key]}");
                        if(detailUpdt[key] == -1) {
                            cmd = new MySqlCommand(@"DELETE FROM dpinjam WHERE dp_bu_id = ?bid AND dp_hp_id=?hpid", conn);
                            cmd.Parameters.Add(new MySqlParameter("bid", key));
                            cmd.Parameters.Add(new MySqlParameter("hpid", hpid));
                        }
                        else if(detailUpdt[key] == 1) {
                            cmd = new MySqlCommand(@"INSERT INTO dpinjam VALUES (default, ?bid, ?hpid)", conn);
                            cmd.Parameters.Add(new MySqlParameter("bid", key));
                            cmd.Parameters.Add(new MySqlParameter("hpid", hpid));
                        }
                        cmd.ExecuteNonQuery();
                    }

                    tr.Commit();
                }
                catch (MySqlException ex){
                    MessageBox.Show(ex.Message);
                    tr.Rollback();
                }
            }
            conn.Close();
        }

        private void cancelTransaction() {
            int hpid = getLastTransactionId();
            conn.Open();
            MySqlCommand cmd;
            using (MySqlTransaction tr = conn.BeginTransaction()) {
                try {
                    cmd = new MySqlCommand(@"DELETE FROM dpinjam WHERE dp_hp_id=?hpid", conn);
                    cmd.Parameters.Add(new MySqlParameter("hpid", hpid));
                    cmd.ExecuteNonQuery();

                    cmd = new MySqlCommand(@"DELETE FROM hpinjam WHERE hp_id=?hpid", conn);
                    cmd.Parameters.Add(new MySqlParameter("hpid", hpid));
                    cmd.ExecuteNonQuery();

                    tr.Commit();
                }
                catch (MySqlException ex) {
                    MessageBox.Show(ex.Message);
                    tr.Rollback();
                }
            }
            conn.Close();
        }

        private void loadBorrowed() {
            MySqlCommand cmd = new MySqlCommand(@"
                SELECT dp_bu_id as 'id' from dpinjam WHERE dp_hp_id IN 
                (SELECT hp_id FROM hpinjam WHERE hp_me_id = ?membid AND hp_status <> 2)
            ", conn);

            cmd.Parameters.Add(new MySqlParameter("membid", user[0]));

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            cart = new List<int>();
            for (int i = 0; i < dt.Rows.Count; i++) {
                cart.Add(Convert.ToInt32(dt.Rows[i]["id"]));
            }
        }

        private int getLastTransactionId() {
            MySqlCommand cmd = new MySqlCommand(@"SELECT hp_id from hpinjam WHERE hp_me_id = ?membid AND hp_status <> 2 ORDER BY hp_id DESC LIMIT 1;", conn);
            cmd.Parameters.Add(new MySqlParameter("membid", user[0]));
            bool connAlreadyOpen = false;
            if (conn.State == ConnectionState.Open) {
                connAlreadyOpen = true;
                conn.Close();
            }
            conn.Open();
            int x = Convert.ToInt32(cmd.ExecuteScalar());
            if (!connAlreadyOpen) {
                conn.Close();
            }

            return x;
        }

        #endregion 
    }
}
