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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            info_.ForeColor = Color.Red;
            info_.Text = "";

            String username = username_.Text;
            String password1 = password_.Text;
            String password2 = password2_.Text;

            if (username == "")
                return;

            if(password1 != password2)
            {
                info_.Text = "Hasła nie są identyczne.";
                password_.Text = "";
                password2_.Text = "";
                return;
            }

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kubek\source\repos\Handlarz 4a\Handlarz 4a\Database1.mdf;Integrated Security=True");
            SqlCommand com = new SqlCommand("GetUsername", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@username", SqlDbType.VarChar).Value = username;
            con.Open();

            SqlDataReader dr = com.ExecuteReader();

            if(dr.Read())
            {
                info_.Text = "Użytkownik już istnieje.";
                return;
            }
            else
            {

                dr.Close();
                com = new SqlCommand("AddUser", con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@username", SqlDbType.VarChar).Value = username;
                com.Parameters.AddWithValue("@password", SqlDbType.NVarChar).Value = password1;
                com.Parameters.AddWithValue("@money", SqlDbType.Money).Value = 0.0f;

                com.ExecuteReader();



                info_.ForeColor = Color.Green;
                info_.Text = "Dodano użytkownika " + username +".";
            }
            con.Close();

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            info_.ForeColor = Color.Red;
            info_.Text = "";
            String username = username_.Text;
            String password1 = password_.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kubek\source\repos\Handlarz 4a\Handlarz 4a\Database1.mdf;Integrated Security=True");
            SqlCommand com = new SqlCommand("Login", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@username", SqlDbType.VarChar).Value = username;
            com.Parameters.AddWithValue("@password", SqlDbType.NVarChar).Value = password1;
            con.Open();

            SqlDataReader dr = com.ExecuteReader();
            if(dr.Read())
            {
                info_.ForeColor = Color.Green;
                info_.Text = "Zalogowano.";

                SqlCommand com1 = new SqlCommand("GetData", con);
                com1.CommandType = CommandType.StoredProcedure;
                com1.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = dr.GetValue(0);
                dr.Close();
                dr = com1.ExecuteReader();
                if(dr.Read())
                {
                    int temp = 0;
                    int.TryParse(dr["Id"].ToString(), out temp);
                    Handlarz_4a.User.Id = temp;

                    Handlarz_4a.User.username = dr["username"].ToString();
                    float temp1 = 0.0f;
                    float.TryParse(dr["money"].ToString(), out temp1);
                    Handlarz_4a.User.cash = temp1;

                    var frm = new Form2();
                    frm.Location = this.Location;
                    frm.StartPosition = FormStartPosition.Manual;
                    frm.Show();
                    this.Hide();


                }

            }
            else
            {
                info_.Text = "Niepoprawny login/hasło.";
            }




        }
    }
}
