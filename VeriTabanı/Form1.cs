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

namespace VeriTabanı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string constring = "Data Source= (localdb)\\MSSQLLocalDB;Initial Catalog = Users; Integrated Security = True";
        SqlConnection connect = new SqlConnection(constring);
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
            {

                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string kayit = "insert into Userx (Ad,Soyad,Password,Mail) values(@Ad,@Soyad,@Password,@Mail)";
                SqlCommand komut = new SqlCommand(kayit, connect);
                komut.Parameters.AddWithValue("@Ad" , txt_Ad.Text);
                komut.Parameters.AddWithValue("@Soyad", txt_Soy.Text);
                komut.Parameters.AddWithValue("@Mail",txt_ma.Text );
                komut.Parameters.AddWithValue("@Password", txt_pw.Text);
                komut.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Kayıt Eklendi");
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Hata Meydana Geldi" + Hata.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_Soy_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
