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
using System.ComponentModel.Design;

namespace FlowersProject
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class BaseForm : Form
    {
        
        DataBase dataBase = new DataBase();

        public BaseForm()
        {
            InitializeComponent();
        }
        
        private void BaseForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDatagrid(dataGridView_main);
        }

        private void CreateColumns()
        {
            dataGridView_main.Columns.Add("id", "id");
            dataGridView_main.Columns.Add("name_flowers", "Название");
            dataGridView_main.Columns.Add("type", "Тип цветка");
            dataGridView_main.Columns.Add("country", "Страна происхождения");
            dataGridView_main.Columns.Add("provider", "Поставщик");
            dataGridView_main.Columns.Add("isNew", String.Empty);
        }

        private void ClearText()
        {
            textBox_Id.Text = "";
            textBox_Name.Text = "";
            textBox_Type.Text = "";
            textBox_Country.Text = "";
            textBox_Provider.Text = "";

        }

        public void ReadSingleRow(DataGridView dataGrid, IDataRecord record) => 
            dataGridView_main.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4));

        /*  record.GetString(0), */
        public void RefreshDatagrid(DataGridView dataGrid)
        {
            dataGridView_main.Rows.Clear();

            string queryString = $"select * from FlowersTable";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

            dataBase.OpenConnection();
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
                ReadSingleRow(dataGrid, reader);

            reader.Close();
             
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRows = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_main.Rows[selectedRows];

                textBox_Id.Text = row.Cells[0].Value.ToString();
                textBox_Name.Text = row.Cells[1].Value.ToString();
                textBox_Type.Text = row.Cells[2].Value.ToString();
                textBox_Country.Text = row.Cells[3].Value.ToString();
                textBox_Provider.Text = row.Cells[4].Value.ToString();
                
            }
        }

        private void Search(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            string searchString = $"select * from FlowersTable where concat (id, name_flowers, type, country, provider) like '%" + textBox_search.Text + "%' ";

            SqlCommand command = new SqlCommand(searchString, dataBase.GetConnection());

            dataBase.OpenConnection();

            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dataGrid, read);
            }

            read.Close();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView_main);
        }

        public void deleteRow()
        {
            int index = dataGridView_main.CurrentCell.RowIndex;

            dataGridView_main.Rows[index].Visible = false;

            if (dataGridView_main.Rows[index].Cells[0].Value.ToString() == string.Empty)
                dataGridView_main.Rows[index].Cells[0].Value = RowState.Deleted;
        }

        public void Update()
        {
            dataBase.OpenConnection();

            for(int index = 0; index < dataGridView_main.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView_main.Rows[index].Cells[0].Value;

                if (rowState == RowState.Existed)
                    continue;
                if(rowState == RowState.Deleted)
                {
                    var Id = Convert.ToInt32(dataGridView_main.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from FlowersTable where id = {Id}";

                    var command = new SqlCommand(deleteQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                }

                if(rowState == RowState.Modified)
                {
                    var id = dataGridView_main.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView_main.Rows[index].Cells[1].Value.ToString();
                    var type = dataGridView_main.Rows[index].Cells[2].Value.ToString();
                    var country = dataGridView_main.Rows[index].Cells[3].Value.ToString();
                    var provider = dataGridView_main.Rows[index].Cells[4].Value.ToString();

                    var changeQuery = $"update FlowersTable set name_flowers = '{name}', type = '{type}', country = '{country}', provider = '{provider}' where id = '{id}'";

                    var command = new SqlCommand(changeQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                }
            }

            dataBase.CloseConnection();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView_main.CurrentCell.RowIndex;

            var id = textBox_Id.Text;
            var name = textBox_Name.Text;
            var type = textBox_Type.Text;
            var country = textBox_Country.Text;
            var provider = textBox_Provider.Text;

            if (dataGridView_main.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView_main.Rows[selectedRowIndex].SetValues(id, name, type, country, provider);
                dataGridView_main.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
            }

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void pictureBox_refresh_Click(object sender, EventArgs e) => RefreshDatagrid(dataGridView_main);

        private void button_Delete_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearText();
        }

        private void button_Save_Click(object sender, EventArgs e) => Update();

        private void button_Change_Click(object sender, EventArgs e)
        {
            Change();
            ClearText();
        }

        private void pictureBox_eraser_Click(object sender, EventArgs e) => ClearText();
    }
}
