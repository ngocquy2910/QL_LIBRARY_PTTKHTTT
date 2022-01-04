
namespace QL_LIBRARY_PTTKHTTT
{
    partial class ReportPMDG
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
            this.PhieuMuonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rpvInPmDg = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PhieuMuonTableAdapter = new QL_LIBRARY_PTTKHTTT.DataSet1TableAdapters.PhieuMuonTableAdapter();
            this.DataSet1 = new QL_LIBRARY_PTTKHTTT.DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuMuonBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // PhieuMuonBindingSource
            // 
            this.PhieuMuonBindingSource.DataMember = "PhieuMuon";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 141);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(42, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "In phiếu mượn độc giả";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.rpvInPmDg);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 362);
            this.panel2.TabIndex = 1;
            // 
            // rpvInPmDg
            // 
            this.rpvInPmDg.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DESIGNPMDG";
            reportDataSource1.Value = this.PhieuMuonBindingSource;
            this.rpvInPmDg.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvInPmDg.LocalReport.ReportEmbeddedResource = "QL_LIBRARY_PTTKHTTT.Report1.rdlc";
            this.rpvInPmDg.Location = new System.Drawing.Point(0, 0);
            this.rpvInPmDg.Name = "rpvInPmDg";
            this.rpvInPmDg.ServerReport.BearerToken = null;
            this.rpvInPmDg.Size = new System.Drawing.Size(834, 362);
            this.rpvInPmDg.TabIndex = 0;
            // 
            // PhieuMuonTableAdapter
            // 
            this.PhieuMuonTableAdapter.ClearBeforeFill = true;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportPMDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 503);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReportPMDG";
            this.Text = "ReportPMDG";
            this.Load += new System.EventHandler(this.ReportPMDG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PhieuMuonBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer rpvInPmDg;
        private System.Windows.Forms.BindingSource PhieuMuonBindingSource;
        private DataSet1TableAdapters.PhieuMuonTableAdapter PhieuMuonTableAdapter;
        private DataSet1 DataSet1;
    }
}