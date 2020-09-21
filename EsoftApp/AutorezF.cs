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

namespace EsoftApp
{
    public partial class AutorezF : Form
    {
        public AutorezF()
        {
            InitializeComponent();
        }

        private void BTNLogin_Click(object sender, EventArgs e)
        {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8R0I2UI;Initial Catalog=B-7;Integrated Security=True");
                conn.Open();
                SqlCommand sqlQuery = new SqlCommand("SELECT * FROM [dbo].[Users]" +
                                                    "WHERE Login = '" + TBLogin.Text + "' AND " +
                                                    "Password = '" + TBPassword.Text + "'", conn);
                SqlDataReader sqlReader = null;
                sqlReader = sqlQuery.ExecuteReader();
                if (sqlReader.HasRows)
                {
                    sqlReader.Read();

                    if ((sqlReader.GetValue(0).ToString() == TBLogin.Text) &&
                        (sqlReader.GetValue(1).ToString() == TBPassword.Text))
                    {

                        if (sqlReader.GetValue(0).ToString() == "abdulina")
                        {
                            ListCallsF LCF = new ListCallsF();
                            MessageBox.Show("Добро пожаловать! " + TBLogin.Text);
                            this.Hide();
                            LCF.Show();
                        }
                        if (sqlReader.GetValue(0).ToString() == "bogdanova")
                        {
                            ListCallsF LCF = new ListCallsF();
                            MessageBox.Show("Добро пожаловать! " + TBLogin.Text);
                            this.Hide();
                            LCF.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Для входа в систему введите Логин и Пароль");
                }
            }

        private void AutorezF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            TBPassword.UseSystemPasswordChar = !TBPassword.UseSystemPasswordChar;
        }

        private void BTNExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
