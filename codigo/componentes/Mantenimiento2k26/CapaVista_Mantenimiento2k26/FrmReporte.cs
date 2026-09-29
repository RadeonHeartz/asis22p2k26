using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_Mantenimiento2k26;

namespace CapaVista_Mantenimiento2k26
{
    public partial class FrmReporte : Form
    {
        private ClsModeloFacultad Facultad = new ClsModeloFacultad();
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            ReportDataSource reportdatasource = new ReportDataSource("ReporteFacultades", Facultad.GetAll());
            reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista_Mantenimiento2k26.Reportes.ReporteFacultades.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportdatasource);
            this.reportViewer1.RefreshReport();
        }
    }
}
