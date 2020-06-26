using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotaTinder
{
    public partial class SignUp : Form
    {

        public SignUp()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn LogIn = new LogIn();
            LogIn.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if ((inputLogin.Text == "") || (InputLink.Text=="")|| (InputPassword.Text==""))
            {
                MessageBox.Show("Введите данные");
                return;
            }

            if (radioButton1.Checked==false && radioButton2.Checked==false && radioButton3.Checked==false && radioButton4.Checked==false && radioButton5.Checked==false  )
            {
                MessageBox.Show("Выберите роль");
                return;
            }

            if (UserCheck()==true)
            {
                return;
            }


                var role=""; 

            if (radioButton1.Checked)
            {
                role = "Carry";
            }
            if (radioButton2.Checked)
            {
                role = "Mid";
            }
            if (radioButton3.Checked)
            {
                role = "Offline";
            }
            if (radioButton4.Checked)
            {
                role = "Support";
            }
            if (radioButton5.Checked)
            {
                role = "Hard Support";
            }



            connect DB = new connect();

            

            MySqlCommand command = new MySqlCommand("INSERT INTO `user_info`(`login`, `password`,`reference`,`role`) VALUES (@login,@password,@reference,@role)",DB.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = inputLogin.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = InputPassword.Text;
            command.Parameters.Add("@reference", MySqlDbType.VarChar).Value = InputLink.Text;
            command.Parameters.AddWithValue("@role", role);


            DB.openConnection();

            if (command.ExecuteNonQuery()==1)
            {
                MessageBox.Show("Аккаунт успешно создан");
            }
            else
            {
                MessageBox.Show("Аккаунт не создан");

            }

            DB.closeConnection();


        }

        public Boolean UserCheck()
        {
            connect DB = new connect();


            DB.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT `reference` FROM `user_info` WHERE `reference`=@reference", DB.getConnection());
            command.Parameters.Add("@reference", MySqlDbType.VarChar).Value = InputLink.Text;
            
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count>0)
            {
                MessageBox.Show("Пользователь существует");
                return true;
            }
            else
            {
                return false;
            }

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
