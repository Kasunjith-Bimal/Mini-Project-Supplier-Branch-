﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplierBranching
{
    public partial class PaperAdvertistmentReport : Form
    {
        public PaperAdvertistmentReport()
        {
            InitializeComponent();
        }

        private void PaperAdvertistmentReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.PaperAdd' table. You can move, or remove it, as needed.
            this.PaperAddTableAdapter.Fill(this.DataSet1.PaperAdd);

            this.reportViewer1.RefreshReport();
        }
    }
}
