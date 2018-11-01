using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BtyIntegrations;
using BtyIntegrations.com.n11CategoryService.api;

namespace BtyDesktopApp
{
    public partial class n11IntegrationForm : Form
    {
        public n11IntegrationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n11Service n11 = new n11Service();
            //n11.getCityList();
            var tlc= n11.GetTopLevelCategories();
            pgc1.DataSource = tlc;
            pgc1.RetrieveFields();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n11Service n11 = new n11Service();
            List<SubCategoryData>  sbc = n11.GetSubCategories(Convert.ToInt64(edsc.Text));
            //foreach (SubCategory sc in sbc.)
            var sct = (from p in sbc select p.subCategoryList).ToList();
            pgc1.DataSource = sct;
            pgc1.RetrieveFields();

        }
    }
}
