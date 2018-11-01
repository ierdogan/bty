﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BtyLibrary;
using BtyEntityLibrary;

namespace BtyDesktopApp.Forms
{
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();
            var bty = new BtyOperations();
            var gvData = bty.getProducts();
            gv.DataSource = gvData;
            gv.RetrieveFields();
        }
    }
}
