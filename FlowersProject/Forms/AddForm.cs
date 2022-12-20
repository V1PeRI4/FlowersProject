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
    public partial class AddForm : Form
    {

        DataBase dataBase = new DataBase();
        public AddForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            dataBase.OpenConnection();

            var name = textBox_name.Text;
            var type = textBox_type.Text;
            var coutry = textBox_country.Text;
            var provider = textBox_provider.Text;

            var addQuery = $"insert into FlowersTable (name_flowers, type, country, provider) values ('{name}', '{type}', '{coutry}', '{provider}')";
            var command = new SqlCommand(addQuery, dataBase.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Запись успешно создана!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataBase.CloseConnection();
        }


    }
}
