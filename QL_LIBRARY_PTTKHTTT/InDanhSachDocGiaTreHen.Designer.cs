
namespace QL_LIBRARY_PTTKHTTT
{
    partial class InDanhSachDocGiaTreHen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rpvPMDGTH = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet2 = new QL_LIBRARY_PTTKHTTT.DataSet2();
            this.PhieuMuonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PhieuMuonTableAdapter = new QL_LIBRARY_PTTKHTTT.DataSet2TableAdapters.PhieuMuonTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuMuonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 141);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(42, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "In danh sách độc giả trể hẹn trả sách";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.rpvPMDGTH);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 3;
            // 
            // rpvPMDGTH
            // 
            this.rpvPMDGTH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rpvPMDGTH.DocumentMapWidth = 8;
            reportDataSource1.Name = "DTSPM_DocGia_TreHen";
            reportDataSource1.Value = this.PhieuMuonBindingSource;
            this.rpvPMDGTH.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvPMDGTH.LocalReport.ReportEmbeddedResource = "QL_LIBRARY_PTTKHTTT.Report2.rdlc";
            this.rpvPMDGTH.Location = new System.Drawing.Point(0, 147);
            this.rpvPMDGTH.Name = "rpvPMDGTH";
            this.rpvPMDGTH.ServerReport.BearerToken = null;
            this.rpvPMDGTH.Size = new System.Drawing.Size(800, 303);
            this.rpvPMDGTH.TabIndex = 0;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PhieuMuonBindingSource
            // 
            this.PhieuMuonBindingSource.DataMember = "PhieuMuon";
            this.PhieuMuonBindingSource.DataSource = this.DataSet2;
            // 
            // PhieuMuonTableAdapter
            // 
            this.PhieuMuonTableAdapter.ClearBeforeFill = true;
            // 
            // InDanhSachDocGiaTreHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "InDanhSachDocGiaTreHen";
            this.Text = "InDanhSachDocGiaTreHen";
            this.Load += new System.EventHandler(this.InDanhSachDocGiaTreHen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuMuonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer rpvPMDGTH;
        private System.Windows.Forms.BindingSource PhieuMuonBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.PhieuMuonTableAdapter PhieuMuonTableAdapter;
    }
}