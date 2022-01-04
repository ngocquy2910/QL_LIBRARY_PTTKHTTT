using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_LIBRARY_PTTKHTTT
{
    public partial class ReportPMDG : Form
    {
        public ReportPMDG()
        {
            InitializeComponent();
        }
        int PMID;

      

        public ReportPMDG (int id) : this()
        {
            PMID = id;
        }
        private void ReportPMDG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.PhieuMuon' table. You can move, or remove it, as needed.
            this.PhieuMuonTableAdapter.Fill(this.DataSet1.PhieuMuon, PMID);

            this.rpvInPmDg.RefreshReport();
            rpvInPmDg.Reset();

            rpvInPmDg.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);
            rpvInPmDg.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            rpvInPmDg.ZoomPercent = 100;

            DataSet1 dataset = new DataSet1();
            dataset.BeginInit();
            this.rpvInPmDg.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource
                ("DESIGNPMDG", dataset.Tables["PhieuMuon"]));
            this.rpvInPmDg.LocalReport.ReportPath = "../../Report1.rdlc";
            this.rpvInPmDg.Location = new System.Drawing.Point(0, 0);
            dataset.EndInit();

            string con = @"Data Source=LAPTOP-C9IT8VA3\SQLEXPRESS;Initial Catalog=db_library;Integrated Security=True";

            DataSet1TableAdapters.PhieuMuonTableAdapter ta = new DataSet1TableAdapters.PhieuMuonTableAdapter();
            ta.Connection.ConnectionString = con;
            ta.ClearBeforeFill = true;
            ta.Fill(dataset.PhieuMuon, PMID);

            this.rpvInPmDg.RefreshReport();
        }
    }
}
