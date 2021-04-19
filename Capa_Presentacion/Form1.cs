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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void cumplimientoTCvsPPTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm_cumplimientoTCvsPPTO = new CumplimientoTCvsPPTO();
            frm_cumplimientoTCvsPPTO.Show();

        }

        private void cumplimientoTCvsPPTOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm_reporte_cumplimientoTCvsPPTO = new Reporte_CumplimientoTCvsPPTO();
            frm_reporte_cumplimientoTCvsPPTO.Show();

        }

        private void cumplimientoTCvsPPTOxTIPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm_reporte_cumplimientoTCvsPPTOxTipo = new Reporte_CumplimientoTCvsPPTO_xTipo();
            frm_reporte_cumplimientoTCvsPPTOxTipo.Show();

        }
    }
}
