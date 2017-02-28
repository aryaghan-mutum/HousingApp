using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Data.SqlClient;

namespace HousingAndDiningApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int Attempt = 0;
        public static System.Timers.Timer aTimer;

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            NumberOfAttempts();
        }

        #region Login
        // lock the user out after three invalid attempts for 2 hours.
        public void NumberOfAttempts()
        {
            //fetching the connection string
            SqlConnection con = new SqlConnection(@"Data Source=enterprise.cba.ksu.edu;Initial Catalog=Group3;User ID=group3;Password=Grp3313s");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) FROM [LogInTable] where Username= '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'", con);      //logic
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1" && Attempt < 3)
            {
                this.Hide();
                MainMenu mm = new MainMenu();
                mm.Show();


                string connectionString = @"Data Source=enterprise.cba.ksu.edu;Initial Catalog=Group3;User ID=group3;Password=Grp3313s";
                string quertString = ("INSERT INTO enterprise.GROUP3.dbo.StoredData  (Login_ID, Username, Date/Time_of_Login, Login_successful) VALUES(@Login_ID, @Username, @Date/Time_of_Login, @Login_successful");

                using (SqlConnection con2 = new SqlConnection(connectionString))
                {
                    con2.Open();
                    SqlCommand cmd = new SqlCommand(quertString, con2);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Login_ID", 1);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Date/Time_of_Login", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Login_successful", 'Y');
                    //  cmd.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Username and Password incorrect, please re-enter");
                Attempt = Attempt + 1;
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();

                string strquery = string.Empty;
                if (Attempt == 3)
                {
                    LoginBtn.Enabled = false;
                    MessageBox.Show("Due to too many invalid attempts you are locked out for 2 hours");
                    timer1.Start();

                    aTimer = new System.Timers.Timer();
                    aTimer.Interval = 5000;
                    aTimer.Start();
                    Attempt = 0;
                }
                string usrStore = txtUsername.Text;
            }
        }
        #endregion

        #region Exit
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
        #endregion

        #region Timer
        int lockOutTime = 1200;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lockOutTime = lockOutTime - 1;
            if (lockOutTime <= 0)
            {
                LoginBtn.Enabled = true;
                timer1.Stop();
                lockOutTime = 1200;
            }
        }
        #endregion


        #region Username Text Box
        private void txtUsername_TextChanged(object sender, EventArgs e)   //KeyPressEventArgs
        {
          //  e.Handled = !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

    }
}
