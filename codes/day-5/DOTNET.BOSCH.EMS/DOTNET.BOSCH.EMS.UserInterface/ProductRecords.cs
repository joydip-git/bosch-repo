using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOTNET.BOSCH.EMS.BusinessEntities;
using DOTNET.BOSCH.EMS.BusinessLayer.Contract;
using DOTNET.BOSCH.EMS.BusinessLayer.Implementation;
using DOTNET.BOSCH.EMS.CustomExceptions.BusinessExceptions;
using DOTNET.BOSCH.EMS.IOC;

namespace DOTNET.BOSCH.EMS.UserInterface
{
    public partial class ProductRecords : Form
    {
        IProductBusinessObject productBusinessObject;
        IBusinessObject<Category> categoryBusinessObject;

        public ProductRecords()
        {
            productBusinessObject = Factory.Create().Resolve<IProductBusinessObject, ProductBusinessObject>();
            categoryBusinessObject = Factory.Create().Resolve<IBusinessObject<Category>, CategoryBusinessObject>();

            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                var products = productBusinessObject.FetchAll() as List<Product>;
                dgvProducts.AutoGenerateColumns = false;
                dgvProducts.DataSource = products;
            }
            catch (BusinessObjectException ex)
            {
                MessageBox.Show(ex.ActualException.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ProductRecords_Load(object sender, EventArgs e)
        {
            var categoris = categoryBusinessObject.FetchAll() as List<Category>;
            //comboCategories.Items.Insert(0, "--select--");
            comboCategories.DataSource = categoris;
            //categoris.ForEach(c => comboCategories.Items.Add(c));
            //comboCategories.Items.Insert(0, "--select--");
            comboCategories.DisplayMember = "Name";
        }

        private void comboCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboCategories.SelectedValue.ToString());
            var categoryObj = comboCategories.SelectedValue as Category;
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.DataSource = productBusinessObject.FetchProductsByCategoryId(categoryObj.Id);
        }
    }
}
