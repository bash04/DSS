using Capa_Negocio;
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
using System.Windows.Forms.DataVisualization;

namespace Capa_Presentacion
{
    public partial class CumplimientoTCvsPPTO : Form
    {
        public CumplimientoTCvsPPTO()
        {
            InitializeComponent();
            this.radioButton1.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);

        }

        private void CumplimientoTCvsPPTO_Load(object sender, EventArgs e)
        {
          

            // Bind combobox to dictionary
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            comboSource.Add("01", "Enero");
            comboSource.Add("02", "Frebrero");
            comboSource.Add("03", "Marzo");
            comboSource.Add("04", "Abril");
            combo_meses.DataSource = new BindingSource(comboSource, null);
            combo_meses.DisplayMember = "Value";
            combo_meses.ValueMember = "Key";

            buscarMesActual();

        }

        private void cargarMesActualCombobox()
        {
            CultureInfo idioma = new CultureInfo("es-ES");

            String mes_num = DateTime.UtcNow.ToString("MM", idioma);

            combo_meses.SelectedValue = mes_num;


        }

            private void buscarMesActual()
        {
            CultureInfo idioma = new CultureInfo("es-ES");

            String mes_num = DateTime.UtcNow.ToString("MM", idioma);
            String mes_letra = DateTime.UtcNow.ToString("MMMM", idioma);
            String ano_num = DateTime.UtcNow.ToString("yyyy", idioma);
            DateTime mes_by_num = new DateTime(Convert.ToInt32(ano_num), Convert.ToInt32(mes_num), 1);
            string FechaFormateada = mes_by_num.ToString("MMMM", idioma);
            mes_letra = UppercaseFirst(mes_letra);
  
            ReporteCumplimientoTC modeloD = new ReporteCumplimientoTC();
            var datosResumidos = modeloD.resumeEstatus_xMes(Convert.ToInt32(mes_num), Convert.ToInt32(ano_num));


            combo_meses.SelectedValue = mes_num;
            lbMeta.Text = datosResumidos[0].ppto.ToString();
            lbEjecutado.Text = datosResumidos[0].ejec.ToString();
            lbLogro.Text = String.Format("{0:#0.##%}", datosResumidos[0].porciento);
            label6.Text = mes_letra;

            llenarGrafico(datosResumidos);

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
                cargarMesActualCombobox();
            else
                combo_meses.SelectedIndex = -1;
           
        }

        private void buscar_btn_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                buscarPorMes();

            }
            else if (radioButton2.Checked)
            {

                buscarUltimos3Meses();
            }
            else
            {
                buscarEneroAlaFecha();
            }

            

        }

        private void buscarEneroAlaFecha()
        {
            combo_meses.SelectedIndex = -1;

         

            ReporteCumplimientoTC modeloD = new ReporteCumplimientoTC();
            var datosResumidos = modeloD.resumeEstatusEneroAlaFecha();


            lbMeta.Text = datosResumidos[0].ppto.ToString();
            lbEjecutado.Text = datosResumidos[0].ejec.ToString();
            lbLogro.Text = String.Format("{0:#0.##%}", datosResumidos[0].porciento);
            label4.Visible = false;
            label6.Text = "Enero a la fecha";

            llenarGrafico(datosResumidos);
        }

        private void buscarUltimos3Meses()
        {
            combo_meses.SelectedIndex = -1;

            ReporteCumplimientoTC modeloD = new ReporteCumplimientoTC();
            var datosResumidos = modeloD.resumeEstatusUltimos3Meses();


            lbMeta.Text = datosResumidos[0].ppto.ToString();
            lbEjecutado.Text = datosResumidos[0].ejec.ToString();
            lbLogro.Text = String.Format("{0:#0.##%}", datosResumidos[0].porciento);
            label4.Visible = false;
            label6.Text = "En los Ultimos 3 Meses";

            llenarGrafico(datosResumidos);
        }

        private void buscarPorMes()
        {
            CultureInfo idioma = new CultureInfo("es-ES");

            String mes_num = combo_meses.SelectedValue.ToString();
            String mes_letra = combo_meses.Text.ToString();
            String ano_num = DateTime.UtcNow.ToString("yyyy", idioma);
            DateTime mes_by_num = new DateTime(Convert.ToInt32(ano_num), Convert.ToInt32(mes_num), 1);
            mes_letra = UppercaseFirst(mes_letra);


            ReporteCumplimientoTC modeloD = new ReporteCumplimientoTC();
            var datosResumidos = modeloD.resumeEstatus_xMes(Convert.ToInt32(mes_num), Convert.ToInt32(ano_num));

            label4.Visible = true;
            lbMeta.Text = datosResumidos[0].ppto.ToString();
            lbEjecutado.Text = datosResumidos[0].ejec.ToString();
            lbLogro.Text = String.Format("{0:#0.##%}", datosResumidos[0].porciento);
            label6.Text = mes_letra;

            llenarGrafico(datosResumidos);

          
        }

        private void llenarGrafico(List<ReporteCumplimientoTC.DatosResumidos> datosResumidos)
        {

            double faltante = datosResumidos[0].ppto - datosResumidos[0].ejec;
            if (faltante < 0)
                faltante = 0;
            chart1.Series["Ejecutado"].Points.Clear();
            chart1.Series["Presupuesto"].Points.Clear();
            chart1.Series["Ejecutado"].Points.Add(datosResumidos[0].ejec);
            chart1.Series["Presupuesto"].Points.Add(datosResumidos[0].ppto);
            chart1.Series["Ejecutado"].AxisLabel = "Faltante " + faltante;
            Blink();
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

        private async void Blink()
        {
            for (int i=0; i<3; i++) 
            {
                await Task.Delay(100);
                label6.BackColor = label6.BackColor == Color.Red ? Color.Yellow : Color.Red;
            }
            
        }

        private void ver_reporte_btn_Click(object sender, EventArgs e)
        {
            string valor_a_pasar_switch="-1";
            string valor_a_pasar_mes="";


            if (radioButton1.Checked)
            {
                valor_a_pasar_switch = "0";
                valor_a_pasar_mes = combo_meses.SelectedValue.ToString();



            }
            else if (radioButton2.Checked)
            {

                valor_a_pasar_switch = "1";
            }
            else
            {
                valor_a_pasar_switch = "2";
            }
            Reporte_CumplimientoTCvsPPTO form_reporte = new Reporte_CumplimientoTCvsPPTO();
            form_reporte.busqueda_inicial[0] = valor_a_pasar_switch;
            form_reporte.busqueda_inicial[1] = valor_a_pasar_mes;
            form_reporte.Show();


        }
    }
}
