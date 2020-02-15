using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using ITCompanyExt.BLL;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ITCompanyExt.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            //this.DepartmentData_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            //this.DepartmentData_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            //this.DepartmentData_dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            //this.DepartmentData_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //this.DepartmentData_dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            //this.DepartmentData_dataGridView.Location = new System.Drawing.Point(3, 3);
            //this.DepartmentData_dataGridView.Margin = new System.Windows.Forms.Padding(4);
            //this.DepartmentData_dataGridView.Name = "DepartmentData_dataGridView";
            //this.DepartmentData_dataGridView.ReadOnly = true;
            //this.DepartmentData_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            //this.DepartmentData_dataGridView.RowTemplate.Height = 24;
            //this.DepartmentData_dataGridView.Size = new System.Drawing.Size(730, 102);
            //this.DepartmentData_dataGridView.TabIndex = 0;
            //this.DepartmentData_dataGridView.SelectionChanged += new System.EventHandler(this.DepartmentData_dataGridView_SelectionChanged);



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            initializeTreeView();
        }

        private void treeView1_NodeMouseClick_1(object sender, TreeNodeMouseClickEventArgs e)
        {
            initializeTreeView();
            //if (e.Node.Level == 0)
            //{
            //Console.WriteLine(e.Node.Name);


            //    Console.WriteLine(e.Node.Name);
            //List<Employee> emps = employees.FindAll(emp => emp.Department == e.Node.Name);

            //this.dataGridView1.DataSource = (from dep in departments.FindAll(d => d.Name == e.Node.Name)
            //                                               select new
            //                                               {
            //                                                   ID = dep.Id,
            //                                                   Name = dep.Name,
            //                                                   LeaderOfDepartment = dep.LeaderOfDepartment,
            //                                                   PeopleCount = emps.Count
            //                                               }).ToList();

            // }
        }

        

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
