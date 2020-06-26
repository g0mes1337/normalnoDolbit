using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotaTinder
{
    public partial class Lk : Form
    {
        public Lk()
        {
            InitializeComponent();
        }
        
        

        private void Check(string role)
        {
            connect DB = new connect();


            MySqlCommand command = new MySqlCommand("UPDATE `user_info` SET `role`=@role WHERE `id_user`=@id_user ", DB.getConnection());
            command.Parameters.Add("@id_user", MySqlDbType.String).Value = User_info.id_user;
            command.Parameters.Add("@role", MySqlDbType.String).Value = role;



            DB.openConnection();

            command.Prepare();
            command.ExecuteNonQuery();
            DB.closeConnection();

        }

       

        private void Lk_Load(object sender, EventArgs e)
        {
            connect DB = new connect();


            MySqlCommand command = new MySqlCommand("SELECT `login`,`role` FROM `user_info` WHERE `id_user`=@id_user ", DB.getConnection());
            command.Parameters.Add("@id_user", MySqlDbType.String).Value = User_info.id_user;

            DB.openConnection();

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                label7.Text = reader[0].ToString();
                label8.Text = reader[1].ToString();
            }
            reader.Close();

            DB.closeConnection();
            
        }

        

        private void UpdateRole_Click(object sender, EventArgs e)
        {
            string role = "";
            if (CarryInput.Checked == true)
            {
                role = "Carry";
            }
            if(MidInput.Checked== true)
            {
                role = "Mid";
            }
            if (OfflineInput.Checked== true )
            {
                role = "Offline";
            }
            if (SupportInput.Checked== true)
            {
                role = "Support";
            }
            if (HardSupportCheck.Checked== true)
            {
                role = "Hard Support";
            }
            if (HardSupportCheck.Checked == false && SupportInput.Checked == false && OfflineInput.Checked == false && MidInput.Checked == false && CarryInput.Checked == false)
            {
                MessageBox.Show("Вы не выбрали ни одну роль");
            }
            else
            {
                Check(role);
                MessageBox.Show("Вы поменяли свою роль");
                
            }
            Lk lk = new Lk();
            this.Hide();
            lk.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "") { 
            connect DB = new connect();

            var link = textBox1.Text;

            MySqlCommand command = new MySqlCommand("UPDATE `user_info` SET `reference`=@reference WHERE `id_user`=@id_user ", DB.getConnection());
            command.Parameters.Add("@id_user", MySqlDbType.String).Value = User_info.id_user;
            command.Parameters.Add("@reference", MySqlDbType.VarChar).Value = link;



            DB.openConnection();

            command.Prepare();
            command.ExecuteNonQuery();
            DB.closeConnection();
            MessageBox.Show("Вы успешно именили SteamLink");

            }
            else
            {
                MessageBox.Show("Введите данные ");
            }
    }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text=="")
            {
                MessageBox.Show("Введите старый пароль");
            }
            else if(textBox3.Text=="" )
            {
                MessageBox.Show("Введите новый пароль");

            }
            if (User_info.password_user==textBox2.Text)
            {
                connect DB = new connect();

                string password = textBox3.Text;

                MySqlCommand command = new MySqlCommand("UPDATE `user_info` SET `password`=@password WHERE `id_user`=@id_user ", DB.getConnection());
                command.Parameters.Add("@id_user", MySqlDbType.String).Value = User_info.id_user;
                command.Parameters.Add("@password", MySqlDbType.String).Value = password;



                DB.openConnection();

                command.Prepare();
                command.ExecuteNonQuery();
                DB.closeConnection();
                MessageBox.Show("Вы успешно именили пароль");
            }
            else
            {
                MessageBox.Show("Неверный пароль");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowUsr frm = new ShowUsr();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
