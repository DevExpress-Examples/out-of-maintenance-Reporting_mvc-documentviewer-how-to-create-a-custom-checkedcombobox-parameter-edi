using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Linq;
using T262163.Models;

namespace T262163.Reports {
    public partial class ProductsReport : DevExpress.XtraReports.UI.XtraReport {
        public ProductsReport() {
            InitializeComponent();
        }

        private void ProductsReport_DataSourceDemanded(object sender, EventArgs e) {
            NorthwindEntities db = new NorthwindEntities();
            string[] categories = Convert.ToString(this.Parameters["Categories"].Value).Split(';');
            
            this.DataSource = from product in db.Products                                  
                              where categories.Contains(product.Category.CategoryName)
                              select product;
        }

    }
}
