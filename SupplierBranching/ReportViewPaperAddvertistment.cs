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
    public partial class ReportViewPaperAddvertistment : Form
    {
        public ReportViewPaperAddvertistment()
        {
            InitializeComponent();
        }

        private void ReportViewPaperAddvertistment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PaperAddvertistementReportGenerate.PaperAdd' table. You can move, or remove it, as needed.
            this.PaperAddTableAdapter.Fill(this.PaperAddvertistementReportGenerate.PaperAdd);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportView obj = new ReportView();
            obj.Show();
            this.Hide();
        }
    }
}
