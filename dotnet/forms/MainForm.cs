using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using service;
using exam_donet_and_php.forms;
namespace exam_donet_and_php
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void closeWindow()
        {
            Form[] form = this.MdiChildren;

            foreach (Form item in form)
            {
                item.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeWindow();

            ProductForm productForm = new ProductForm();

            productForm.WindowState = FormWindowState.Maximized;
            productForm.MdiParent = this;
            productForm.Show();
        }

        private void categoriesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            closeWindow();

            CategoriesForm categoriesForm = new CategoriesForm();

            categoriesForm.WindowState = FormWindowState.Maximized;
            categoriesForm.MdiParent = this;
            categoriesForm.Show();
        }
    }
}
