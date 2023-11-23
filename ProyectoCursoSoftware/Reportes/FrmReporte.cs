using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCursoSoftware.Reportes
{
    public partial class FrmReporte : Form
    {
        private Conexion con;
        private int n;
        public FrmReporte(Conexion Con, int N)
        {
            this.con = Con;
            this.n = N;
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            if(n== 1) 
            {
                DataSet1 ds = new DataSet1();
                SqlDataAdapter das = new SqlDataAdapter("MostrarVentas", con.connect);
                das.Fill(ds, "MostrarVentas");
                reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoCursoSoftware.Reportes.ReporteVenta.rdlc";
                ReportDataSource dataSource = new ReportDataSource("DataSet1", ds.Tables[0]);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(dataSource);
                reportViewer1.RefreshReport();
            } else if(n == 2)
            {
                DataSet1 ds = new DataSet1();
                SqlDataAdapter das = new SqlDataAdapter("MostrarCompra", con.connect);
                das.Fill(ds, "MostrarCompra");
                reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoCursoSoftware.Reportes.ReporteCompra.rdlc";
                ReportDataSource dataSource = new ReportDataSource("DataSet1", ds.Tables[1]);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(dataSource);
                reportViewer1.RefreshReport();
            }
            
        }
    }
}
