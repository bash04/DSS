using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Acceso_Datos;

namespace Capa_Negocio
{
    public class ReporteCumplimientoTC
    {        //Attributes-Properties
        public DateTime reportDate { get; private set; }
        public DateTime startDate { get; private set; }
        public DateTime endDate { get; private set; }
        public List<ListadoCumplimientoTC> listadoCumplimientoTC { get; private set; }
        public double total_ejec { get; private set; }
        public double total_ppto { get; private set; }
        public double total_dif { get; private set; }

        public List<DatosResumidos> datosResumidos { get; private set; }


        public class DatosResumidos
        {
           
            public int ejec { get; set; }
            public int ppto { get; set; }
            public double porciento { get; set; }
        }


        //Methods
        public void obtener_cumplimientoTC_por_oficinas(int mes, int ano)
        {
            //implement dates
            reportDate = DateTime.Now;

            //create cumplimiento por oficinas
            var cumplimi_vs_PPTO = new Cumplimiento_vs_PPTO();
            var result = cumplimi_vs_PPTO.obtenerEstatusCumplimientoTC(mes, ano);
            listadoCumplimientoTC = new List<ListadoCumplimientoTC>();
            foreach (System.Data.DataRow rows in result.Rows)
            {
                var modelo_ejecutado = new ListadoCumplimientoTC()
                {
                    id_oficina = Convert.ToInt32(rows[0]),
                    ejec = Convert.ToInt32(rows[1]),
                    ppto = Convert.ToInt32(rows[2]),
                    diferencia = Convert.ToInt32(rows[3]),
                    porciento = Convert.ToDouble(rows[4]),
                    nombre_oficina = Convert.ToString(rows[5]),
                };
                listadoCumplimientoTC.Add(modelo_ejecutado);
                //calculate total net sales

                total_ejec += Convert.ToDouble(rows[1]);
                total_ppto += Convert.ToDouble(rows[2]);

            }
            total_dif = total_ejec - total_ppto;
            //create net sales by period
            ////create temp list net sales by date

        }


        public void obtener_cumplimientoTC_por_oficinas_3meses()
        {
            //implement dates
            reportDate = DateTime.Now;

            //create cumplimiento por oficinas
            var cumplimi_vs_PPTO = new Cumplimiento_vs_PPTO();
            var result = cumplimi_vs_PPTO.obtenerEstatusCumplimientoTC_3meses();
            listadoCumplimientoTC = new List<ListadoCumplimientoTC>();
            foreach (System.Data.DataRow rows in result.Rows)
            {
                var modelo_ejecutado = new ListadoCumplimientoTC()
                {
                    id_oficina = Convert.ToInt32(rows[0]),
                    ejec = Convert.ToInt32(rows[1]),
                    ppto = Convert.ToInt32(rows[2]),
                    diferencia = Convert.ToInt32(rows[3]),
                    porciento = Convert.ToDouble(rows[4]),
                    nombre_oficina = Convert.ToString(rows[5]),
                };
                listadoCumplimientoTC.Add(modelo_ejecutado);
                //calculate total net sales

                total_ejec += Convert.ToDouble(rows[1]);
                total_ppto += Convert.ToDouble(rows[2]);

            }
            total_dif = total_ejec - total_ppto;
            //create net sales by period
            ////create temp list net sales by date

        }

        public void obtener_cumplimientoTC_por_oficinas_EneroAlaFecha()
        {
            //implement dates
            reportDate = DateTime.Now;

            //create cumplimiento por oficinas
            var cumplimi_vs_PPTO = new Cumplimiento_vs_PPTO();
            var result = cumplimi_vs_PPTO.obtenerEstatusCumplimientoTC_EneroAlaFecha();
            listadoCumplimientoTC = new List<ListadoCumplimientoTC>();
            foreach (System.Data.DataRow rows in result.Rows)
            {
                var modelo_ejecutado = new ListadoCumplimientoTC()
                {
                    id_oficina = Convert.ToInt32(rows[0]),
                    ejec = Convert.ToInt32(rows[1]),
                    ppto = Convert.ToInt32(rows[2]),
                    diferencia = Convert.ToInt32(rows[3]),
                    porciento = Convert.ToDouble(rows[4]),
                    nombre_oficina = Convert.ToString(rows[5]),
                };
                listadoCumplimientoTC.Add(modelo_ejecutado);
                //calculate total net sales

                total_ejec += Convert.ToDouble(rows[1]);
                total_ppto += Convert.ToDouble(rows[2]);

            }
            total_dif = total_ejec - total_ppto;
            //create net sales by period
            ////create temp list net sales by date
        }

        public List<DatosResumidos> resumeEstatusPorMes(int mes, int ano)
        {
            List<Double> listOfStrings = new List<Double>();
            var cumplimi_vs_PPTO = new Cumplimiento_vs_PPTO();
            var result = cumplimi_vs_PPTO.obtenerResumenCumplimientoTCporMes(mes,ano);

            datosResumidos = new List<DatosResumidos>();
            foreach (System.Data.DataRow rows in result.Rows)
            {
                var modelo_ejecutado = new DatosResumidos()
                {
                    ejec = Convert.ToInt32(rows[0]),
                    ppto = Convert.ToInt32(rows[1]),
                    porciento = Convert.ToDouble(rows[2])
                };

                datosResumidos.Add(modelo_ejecutado);

            }


            return datosResumidos;
            
        
        }

        public List<DatosResumidos> resumeEstatusUltimos3Meses()
        {
            List<Double> listOfStrings = new List<Double>();
            var cumplimi_vs_PPTO = new Cumplimiento_vs_PPTO();
            var result = cumplimi_vs_PPTO.obtenerResumenCumplimientoTC_ultimos3Meses();

            datosResumidos = new List<DatosResumidos>();
            foreach (System.Data.DataRow rows in result.Rows)
            {
                var modelo_ejecutado = new DatosResumidos()
                {
                    ejec = Convert.ToInt32(rows[0]),
                    ppto = Convert.ToInt32(rows[1]),
                    porciento = Convert.ToDouble(rows[2])
                };

                datosResumidos.Add(modelo_ejecutado);

            }


            return datosResumidos;


        }

        public List<DatosResumidos> resumeEstatusEneroAlaFecha()
        {
            List<Double> listOfStrings = new List<Double>();
            var cumplimi_vs_PPTO = new Cumplimiento_vs_PPTO();
            var result = cumplimi_vs_PPTO.obtenerResumenCumplimientoTC_EneroAlaFecha();

            datosResumidos = new List<DatosResumidos>();
            foreach (System.Data.DataRow rows in result.Rows)
            {
                var modelo_ejecutado = new DatosResumidos()
                {
                    ejec = Convert.ToInt32(rows[0]),
                    ppto = Convert.ToInt32(rows[1]),
                    porciento = Convert.ToDouble(rows[2])
                };

                datosResumidos.Add(modelo_ejecutado);

            }


            return datosResumidos;


        }
        


    }
}
