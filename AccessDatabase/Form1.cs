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
            String sql = "SELECT * FROM Student";
            String connection = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\\CSharp\\Lab1_SE130301\\SE1401-PRN292\\AccessDatabase\\Database.accdb";

            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connection);
            adapter.Fill(student);
            dataGridViewStudent.DataSource = student;
            dataGridViewStudent.Columns["ClassID"].Visible = false;
            dataGridViewStudent.Columns["Fullname"].HeaderText = "Ho va Ten";

            
            cbbStudent.DataSource = student;
            cbbStudent.DisplayMember = "Fullname";
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
