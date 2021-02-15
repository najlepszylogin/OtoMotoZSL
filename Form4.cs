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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            float temp = 0.0f;
            float.TryParse(cena_.Text, out temp);
            if (temp < 0.0f)
            {
                info_.Text = "Cena nie może byc ujemna.";
                cena_.Text = "";
                return;
            }
            String marka = marka_.Text;
            String model = model_.Text;
            String silnik = silnik_.Text;

            if (marka == "")
            {
                info_.Text = "Marka nie może być pusta.";
                return;
            }

            if (model == "")
            {
                info_.Text = "Model nie może być pusty.";
                return;
            }



            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kubek\source\repos\Handlarz 4a\Handlarz 4a\Database1.mdf;Integrated Security=True");
            SqlCommand com = new SqlCommand("AddCar", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@marka", SqlDbType.VarChar).Value = marka;
            com.Parameters.AddWithValue("@model", SqlDbType.VarChar).Value = model;
            com.Parameters.AddWithValue("@silnik", SqlDbType.VarChar).Value = silnik;
            com.Parameters.AddWithValue("@cena", SqlDbType.Money).Value = temp;
            com.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Handlarz_4a.User.Id;
            con.Open();

            com.ExecuteNonQuery();

            var frm = new Form2();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var frm = new Form2();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Show();
            this.Hide();
        }
    }
}
