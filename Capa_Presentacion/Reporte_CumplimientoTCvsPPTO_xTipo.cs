using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
using Microsoft.Reporting.WinForms;

namespace Capa_Presentacion
{
    public partial class Reporte_CumplimientoTCvsPPTO_xTipo : Form
    {
        public Reporte_CumplimientoTCvsPPTO_xTipo()
        {
            InitializeComponent();
        }

        private void Reporte_CumplimientoTCvsPPTO_xTipo_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FF(1,2021);
        }

        private void FF(int mes, int ano)
        {

            ReporteCumplimientoTC reportModel = new ReporteCumplimientoTC();
            reportModel.obtener_cumplimientoTC_x_oficinas_xMes_xTipo(mes, ano);

            reporteCumplimientoTCBindingSource.DataSource = reportModel;
            listadoCumplimientoTCxTipoBindingSource.DataSource = reportModel.listadoCumplimientoTCxTipo;
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dataset_reporte_cumplimiento", reporteCumplimientoTCBindingSource));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dataset_listado_cumplimiento_xTipo", listadoCumplimientoTCxTipoBindingSource));

            string fecha_mes = "eneroo";
            ReportParameter parameter = new ReportParameter("fecha_mes", fecha_mes);
            reportViewer1.LocalReport.SetParameters(parameter);
            //reportViewer1.LocalReport.Refresh();


            this.reportViewer1.RefreshReport();

        }
    }
}
