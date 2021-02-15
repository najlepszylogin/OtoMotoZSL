using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Handlarz_4a
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            name_.Text += Handlarz_4a.User.username + "!";
            cash_.Text = Handlarz_4a.User.cash.ToString();

            
            this.showMyCarsTableAdapter.Fill(this.database1DataSet.showMyCars, Handlarz_4a.User.Id);
            FillDataGridMyCars();
            FillDataGridAll();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            User.Reset();
            var frm = new Form1();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Show();
            this.Hide();


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var frm = new Form3();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'database1DataSet1.showAllCars' . Możesz go przenieść lub usunąć.
            this.showAllCarsTableAdapter.Fill(this.database1DataSet1.showAllCars);

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var frm = new Form4();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Show();
            this.Hide();
        }


        private void FillDataGridMyCars()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kubek\source\repos\Handlarz 4a\Handlarz 4a\Database1.mdf;Integrated Security=True");
            SqlCommand com = new SqlCommand("showMyCars", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Handlarz_4a.User.Id;

            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable dt = new DataTable("cars");
            sda.Fill(dt);

            BindingSource bS = new BindingSource();
            bS.DataSource = dt;
            moje_pojazdy_.DataSource = bS;

        }

        private void FillDataGridAll()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kubek\source\repos\Handlarz 4a\Handlarz 4a\Database1.mdf;Integrated Security=True");
            SqlCommand com = new SqlCommand("showAllCars", con);
            com.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable dt = new DataTable("cars");
            sda.Fill(dt);

            BindingSource bS = new BindingSource();
            bS.DataSource = dt;
            wszystkie_pojazdy_.DataSource = bS;
        }
    }
}
