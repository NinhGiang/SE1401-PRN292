using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AcccessDatabase
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private DataTable getTable(String sql)
        {
            DataTable table = new DataTable();
            String connector = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\\Downloads\\Database.accdb";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connector);
            adapter.Fill(table);
            return table;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            DataTable class_table = getTable("Select * from Lop");
            comboBoxClass.DataSource = class_table;
            comboBoxClass.DisplayMember = "Name";
        }

        private void buttonAccess_Click(object sender, EventArgs e)
        {
            DataTable class_table = (DataTable)comboBoxClass.DataSource;
            int selected_index = comboBoxClass.SelectedIndex;
            DataRow selected_row = class_table.Rows[selected_index];
            DataTable student_table = getTable("Select * from HOC_SINH Where Ma_lop = " + selected_row["ID"]);
            dataGridViewStudent.DataSource = student_table;
            dataGridViewStudent.Columns["Ma_lop"].Visible = false; 
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAccess_Click(sender, e);
        }
    }
}
