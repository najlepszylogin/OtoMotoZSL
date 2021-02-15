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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var frm = new Form2();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            float temp = 0.0f;
            float.TryParse(cash_.Text, out temp);
            if(temp < 0.0f)
            {
                cash_.Text = "";
                return;
            }
            String password = password_.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kubek\source\repos\Handlarz 4a\Handlarz 4a\Database1.mdf;Integrated Security=True");
            SqlCommand com = new SqlCommand("Login", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@username", SqlDbType.VarChar).Value = Handlarz_4a.User.username;
            com.Parameters.AddWithValue("@password", SqlDbType.NVarChar).Value = password;
            con.Open();

            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                com = new SqlCommand("AddCash", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Handlarz_4a.User.Id;
                com.Parameters.AddWithValue("@cash", SqlDbType.Money).Value = temp;
                dr.Close();

                dr = com.ExecuteReader();

                if(dr.Read())
                {
                    float temp2 = 0.0f;
                    float.TryParse(dr.GetValue(0).ToString(), out temp2);
                    Handlarz_4a.User.cash = temp2;

                    var frm = new Form2();
                    frm.Location = this.Location;
                    frm.StartPosition = FormStartPosition.Manual;
                    frm.Show();

                    this.Hide();
                }
                else return;

            }else
            {
                info_.Text = "Niepoprawne hasło.";
                password_.Text = "";
                return;
            }
        }
    }
}
