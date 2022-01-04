using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_LIBRARY_PTTKHTTT
{
    public partial class InDanhSachDocGiaTreHen : Form
    {
        public InDanhSachDocGiaTreHen()
        {
            InitializeComponent();
        }

        private void InDanhSachDocGiaTreHen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.PhieuMuon' table. You can move, or remove it, as needed.
            this.PhieuMuonTableAdapter.Fill(this.DataSet2.PhieuMuon);

            this.rpvPMDGTH.RefreshReport();
            rpvPMDGTH.Reset();

            rpvPMDGTH.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);
            rpvPMDGTH.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            rpvPMDGTH.ZoomPercent = 100;

            DataSet2 dataset = new DataSet2();
            dataset.BeginInit();
            this.rpvPMDGTH.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource
                ("DTSPM_DocGia_TreHen", dataset.Tables["PhieuMuon"]));
            this.rpvPMDGTH.LocalReport.ReportPath = "../../Report2.rdlc";
            this.rpvPMDGTH.Location = new System.Drawing.Point(0, 0);
            dataset.EndInit();

            string con = @"Data Source=LAPTOP-C9IT8VA3\SQLEXPRESS;Initial Catalog=db_library;Integrated Security=True";

            DataSet2TableAdapters.PhieuMuonTableAdapter ta = new DataSet2TableAdapters.PhieuMuonTableAdapter();
            ta.Connection.ConnectionString = con;
            ta.ClearBeforeFill = true;
            ta.Fill(dataset.PhieuMuon);

            this.rpvPMDGTH.RefreshReport();
        }
    }
}
