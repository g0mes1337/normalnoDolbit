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
    
    public partial class LogIn : Form
    {
        
        public LogIn()
        {
            
            InitializeComponent();
        }

        

          public void btnLogIn_Click(object sender, EventArgs e)
        {
          
            connect DB = new connect();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DB.openConnection();
       
            MySqlCommand command = new MySqlCommand("SELECT `id_user`,`password` FROM `user_info` WHERE `login`=@login AND `password`=@password ", DB.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = inputLogin1.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = inputPassword1.Text;

            
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                User_info.id_user = String.Format("{0}", reader[0]);
                User_info.password_user = String.Format("{0}", reader[1]); 
            }

            DB.closeConnection();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                ShowUsr Main = new ShowUsr();
                Main.Show();
            }
            else
            {
                MessageBox.Show("Неверные данные");

            }
            

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
