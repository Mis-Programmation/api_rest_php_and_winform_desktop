using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model;
using service;
namespace exam_donet_and_php.forms
{
    public partial class ProductForm : Form
    {

        DataTable table = new DataTable();
        ProduitService produitService = new ProduitService();
        public ProductForm()
        {
            InitializeComponent();
            dgvProduct.DataSource = table;

            dgvInitializer();
        }


        private void dgvInitializer()
        {
            table.Columns.Add("libelle");
            table.Columns.Add("designation");
            table.Columns.Add("pu");
            table.Columns.Add("category");
            table.Columns.Add("date de Peremption");
            var productsApiData = produitService.GetAll();

            foreach (Product item in productsApiData)
            {
                
                table.Rows.Add(
                    item.libelle,
                    item.designation, 
                    item.pu,
                    item.category.libelle,
                    item.datePeremption
                );
                
            }
        }
    }
}
