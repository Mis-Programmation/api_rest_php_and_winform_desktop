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
using model;

namespace exam_donet_and_php.forms
{
    public partial class CategoriesForm : Form
    {
        CategoriesService categoriesService = new CategoriesService();
        DataTable table = new DataTable();

        public CategoriesForm()
        {

            InitializeComponent();

            dgvCategories.DataSource = table;
            dgvManager();
        }


        private void dgvManager()
        {
            table.Columns.Add("libelle");
            table.Columns.Add("date de creation");
            var categoriesApiData = categoriesService.GetAll();

            foreach (Categories item in categoriesApiData)
            {
                table.Rows.Add(item.libelle, item.createdAt);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            String libelle = tbxLibelle.Text.Trim();
            if (libelle.Equals(""))
            {
                MessageBox.Show("Le champs est obligatoire");
                return;
            }
            var categories = categoriesService.Add(new Categories { libelle = libelle });

            this.table.Rows.Add(categories.libelle, categories.createdAt);

            tbxLibelle.Text = String.Empty;
        }

    }
}
