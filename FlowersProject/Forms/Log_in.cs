using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowersProject
{
    public partial class Log_in : Form
    {
        DataBase dataBase = new DataBase(); 

        public Log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void log_in_Load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';
            textBox_login.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var loginUser = textBox_login.Text;
            var passUser = textBox_password.Text;
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from register where login_user ='{loginUser}' and password_user ='{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BaseForm form1 = new BaseForm();
                this.Hide();
                form1.ShowDialog();
            }
            else
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void linkLabel_reg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_in sign_In = new Sign_in();
            this.Hide();
            sign_In.ShowDialog();
        }

        private void btn_eye_MouseDown(object sender, MouseEventArgs e) => textBox_password.UseSystemPasswordChar = true;
        private void btn_eye_MouseUp(object sender, MouseEventArgs e) => textBox_password.UseSystemPasswordChar = false;


    }
}
