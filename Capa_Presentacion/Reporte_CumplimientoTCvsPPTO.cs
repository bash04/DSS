using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
using Microsoft.Reporting.WinForms;

namespace Capa_Presentacion
{
    public partial class Reporte_CumplimientoTCvsPPTO : Form
    {

        public string[] busqueda_inicial = new string[2];


        public Reporte_CumplimientoTCvsPPTO()
        {
            InitializeComponent();
        }


       


        private void obtener_cumplimientoTC_por_oficinas(int mes, int ano)
        {

            ReporteCumplimientoTC reportModel = new ReporteCumplimientoTC();
            reportModel.obtener_cumplimientoTC_por_oficinas(mes, ano);

            reporteCumplimientoTCBindingSource.DataSource = reportModel;
            listadoCumplimientoTCBindingSource.DataSource = reportModel.listadoCumplimientoTC;
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dataset_reporte_cumplimiento", reporteCumplimientoTCBindingSource));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dataset_listado_cumplimiento", listadoCumplimientoTCBindingSource));
     
            string fecha_mes = combo_meses.Text;
            ReportParameter parameter = new ReportParameter("fecha_mes", fecha_mes);
            reportViewer1.LocalReport.SetParameters(parameter);
           // reportViewer1.LocalReport.Refresh();


            this.reportViewer1.RefreshReport();

        }

        private void obtener_cumplimientoTC_por_oficinas_3meses()
        {
            combo_meses.SelectedIndex = -1;

            ReporteCumplimientoTC reportModel = new ReporteCumplimientoTC();
            reportModel.obtener_cumplimientoTC_por_oficinas_3meses();

            reporteCumplimientoTCBindingSource.DataSource = reportModel;
            listadoCumplimientoTCBindingSource.DataSource = reportModel.listadoCumplimientoTC;
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dataset_reporte_cumplimiento", reporteCumplimientoTCBindingSource));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dataset_listado_cumplimiento", listadoCumplimientoTCBindingSource));

            string fecha_mes = "Ultimos 3 Meses";
            ReportParameter parameter = new ReportParameter("fecha_mes", fecha_mes);
            reportViewer1.LocalReport.SetParameters(parameter);
            // reportViewer1.LocalReport.Refresh();


            this.reportViewer1.RefreshReport();

        }

        private void obtener_cumplimientoTC_por_oficinas_EneroAlaFecha()
        {
            combo_meses.SelectedIndex = -1;

            ReporteCumplimientoTC reportModel = new ReporteCumplimientoTC();
            reportModel.obtener_cumplimientoTC_por_oficinas_EneroAlaFecha();

            reporteCumplimientoTCBindingSource.DataSource = reportModel;
            listadoCumplimientoTCBindingSource.DataSource = reportModel.listadoCumplimientoTC;
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dataset_reporte_cumplimiento", reporteCumplimientoTCBindingSource));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dataset_listado_cumplimiento", listadoCumplimientoTCBindingSource));

            string fecha_mes = "De Enero a la fecha";
            ReportParameter parameter = new ReportParameter("fecha_mes", fecha_mes);
            reportViewer1.LocalReport.SetParameters(parameter);
            // reportViewer1.LocalReport.Refresh();


            this.reportViewer1.RefreshReport();
        }

        private void Reporte_CumplimientoTCvsPPTO_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            comboSource.Add("01", "Enero");
            comboSource.Add("02", "Frebrero");
            comboSource.Add("03", "Marzo");
            comboSource.Add("04", "Abril");
            combo_meses.DataSource = new BindingSource(comboSource, null);
            combo_meses.DisplayMember = "Value";
            combo_meses.ValueMember = "Key";


            switch(busqueda_inicial[0])
            {
                case "0":
                    busqueda_por_defecto(busqueda_inicial[1].ToString());

                    break;

                case "1":
                    obtener_cumplimientoTC_por_oficinas_3meses();

                    break;

                case "2":
                    obtener_cumplimientoTC_por_oficinas_EneroAlaFecha();

                    break;

            }

        }

      

        private void mostrar_Click(object sender, EventArgs e)
        {


            CultureInfo idioma = new CultureInfo("es-ES");

            String mes_num = combo_meses.SelectedValue.ToString();
            String mes_letra = combo_meses.Text.ToString();
            String ano_num = DateTime.UtcNow.ToString("yyyy", idioma);
            DateTime mes_by_num = new DateTime(Convert.ToInt32(ano_num), Convert.ToInt32(mes_num), 1);
            mes_letra = UppercaseFirst(mes_letra);

            
            obtener_cumplimientoTC_por_oficinas(Convert.ToInt32(mes_num), Convert.ToInt32(ano_num));


        }

        private void busqueda_por_defecto(string mes)
        {
            combo_meses.SelectedValue = busqueda_inicial[1];

            CultureInfo idioma = new CultureInfo("es-ES");
            String mes_num = mes;
            String ano_num = DateTime.UtcNow.ToString("yyyy", idioma);
            obtener_cumplimientoTC_por_oficinas(Convert.ToInt32(mes_num), Convert.ToInt32(ano_num));


        }

        static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
