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
    public partial class ShowUsr : Form
    {
        public ShowUsr()
        {
            InitializeComponent();
        }


        private void ShowUsr_Load(object sender, EventArgs e)
        {
            
            connect DB = new connect();


            MySqlCommand command = new MySqlCommand("SELECT `login`,`role`,`reference` FROM `user_info` WHERE `id_user`!=@id_user ", DB.getConnection());
            command.Parameters.Add("@id_user", MySqlDbType.String).Value = User_info.id_user;

            DB.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();

            }
            reader.Close();
            
            DB.closeConnection();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
                

            }
            
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void CheckSupport_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            connect DB = new connect();

            var role = "Support";
            
            MySqlCommand command = new MySqlCommand("SELECT `login`,`role`,`reference` FROM `user_info` WHERE `id_user`!=@id_user AND role=@role", DB.getConnection());
            command.Parameters.Add("@id_user", MySqlDbType.String).Value = User_info.id_user;
            command.Parameters.Add("@role", MySqlDbType.VarChar).Value = role;



            DB.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }
            reader.Close();

            DB.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void CheckOffline_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            connect DB = new connect();

            var role = "Offline";

            MySqlCommand command = new MySqlCommand("SELECT `login`,`role`,`reference` FROM `user_info` WHERE `id_user`!=@id_user AND role=@role", DB.getConnection());
            command.Parameters.Add("@id_user", MySqlDbType.String).Value = User_info.id_user;
            command.Parameters.Add("@role", MySqlDbType.VarChar).Value = role;



            DB.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }
            reader.Close();

            DB.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void CheckMid_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            connect DB = new connect();

            var role = "Mid";

            MySqlCommand command = new MySqlCommand("SELECT `login`,`role`,`reference` FROM `user_info` WHERE `id_user`!=@id_user AND role=@role", DB.getConnection());
            command.Parameters.Add("@id_user", MySqlDbType.String).Value = User_info.id_user;
            command.Parameters.Add("@role", MySqlDbType.VarChar).Value = role;



            DB.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }
            reader.Close();

            DB.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void CheckCarry_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            connect DB = new connect();

            var role = "Carry";

            MySqlCommand command = new MySqlCommand("SELECT `login`,`role`,`reference` FROM `user_info` WHERE `id_user`!=@id_user AND role=@role", DB.getConnection());
            command.Parameters.Add("@id_user", MySqlDbType.String).Value = User_info.id_user;
            command.Parameters.Add("@role", MySqlDbType.VarChar).Value = role;



            DB.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }
            reader.Close();

            DB.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void checkHardSupport_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            connect DB = new connect();

            var role = "Hard Support";

            MySqlCommand command = new MySqlCommand("SELECT `login`,`role`,`reference` FROM `user_info` WHERE `id_user`!=@id_user AND role=@role", DB.getConnection());
            command.Parameters.Add("@id_user", MySqlDbType.String).Value = User_info.id_user;
            command.Parameters.Add("@role", MySqlDbType.VarChar).Value = role;



            DB.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }
            reader.Close();

            DB.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void CheckAll_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            connect DB = new connect();


            MySqlCommand command = new MySqlCommand("SELECT `login`,`role`,`reference` FROM `user_info` WHERE `id_user`!=@id_user", DB.getConnection());
            command.Parameters.Add("@id_user", MySqlDbType.String).Value = User_info.id_user;



            DB.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }
            reader.Close();

            DB.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex !=
           dataGridView1.Columns["UserLinkOut"].Index) return;
            
            var Link = dataGridView1.SelectedCells[0].Value;
            System.Diagnostics.Process.Start("www.steamcommunity.com/id/"+Link.ToString());


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lk lk = new Lk();
            lk.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
