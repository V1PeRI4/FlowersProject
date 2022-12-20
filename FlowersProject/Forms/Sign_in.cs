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

namespace FlowersProject
{
    public partial class Sign_in : Form
    {
        DataBase dataBase = new DataBase();

        public Sign_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void Sign_in_Load(object sender, EventArgs e)
        {
            textBox_passwordReg.PasswordChar = '*';
        }


        private void btn_eye_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            

            var loginUser = textBox_loginReg.Text;
            var passUser = textBox_passwordReg.Text;

            string querystring = $"insert into register(login_user, password_user) values('{loginUser}', '{passUser}')";

            SqlCommand sqlCommand = new SqlCommand(querystring, dataBase.GetConnection());

            dataBase.OpenConnection();

            if(sqlCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("аккаунт успешно создан!", "Успех!");
                Log_in log_In = new Log_in();
                this.Hide();
                log_In.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }
            dataBase.CloseConnection();
        }

        private bool CheckUser()
        {
            var loginUser = textBox_loginReg.Text;
            var passUser = textBox_passwordReg.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else return false;
        }

    }
}
