using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccessDatabase
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataTable student = new DataTable();
            String sql = "Select * from Student";
            String connector = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\\Documents\\Database.accdb";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connector);
            adapter.Fill(student);
            dataGridViewStudent.DataSource = student;
            dataGridViewStudent.Columns["ClassID"].Visible = false;
            dataGridViewStudent.Columns["Fullname"].HeaderText = "Họ và tên";
            comboBoxStudent.DataSource = student;
            comboBoxStudent.DisplayMember = "Fullname";
        }
    }
}
