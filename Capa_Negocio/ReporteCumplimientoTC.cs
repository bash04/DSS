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
        public double total_ejec { get; private set; }
        public double total_ppto { get; private set; }
        public double total_dif { get; private set; }
        public List<ListadoCumplimientoTC> listadoCumplimientoTC { get; private set; }
        public List<ListadoCumplimientoTCxTipo> listadoCumplimientoTCxTipo { get; private set; }

        public List<DatosResumidos> datosResumidos { get; private set; }


        public class DatosResumidos
        {
           
            public int ejec { get; set; }
            public int ppto { get; set; }
            public double porciento { get; set; }
        }


        //METODOS


        // CUMPLIMIENTO POR OFICINAS 
        public void obtener_cumplimientoTC_x_oficinas_xMes(int mes, int ano)
        {
            //implement dates
            reportDate = DateTime.Now;

            //create cumplimiento por oficinas
            var cumplimi_vs_PPTO = new Cumplimiento_vs_PPTO();
            var result = cumplimi_vs_PPTO.obtenerEstatusCumplimientoTCporMes(mes, ano);
            listadoCumplimientoTC = new List<ListadoCumplimientoTC>();
            foreach (System.Data.DataRow rows in result.Rows)
            {
                var modelo_ejecutado = new ListadoCumplimientoTC()
                {
                    id_oficina = Convert.ToInt32(rows["id_oficina"]),
                    ejec = Convert.ToInt32(rows["ejec"]),
                    ppto = Convert.ToInt32(rows["ppto"]),
                    diferencia = Convert.ToInt32(rows["DIF"]),
                    porciento = Convert.ToDouble(rows["Porciento"]),
                    nombre_oficina = Convert.ToString(rows["OFC"]),
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

        public void obtener_cumplimientoTC_x_oficinas_3meses()
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

        public void obtener_cumplimientoTC_x_oficinas_EneroAlaFecha()
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


        // CUMPLIMIENTO POR OFICINAS x TIPO
        public void obtener_cumplimientoTC_x_oficinas_xMes_xTipo(int mes, int ano)
        {
            //implement dates
            reportDate = DateTime.Now;

            //create cumplimiento por oficinas
            var cumplimi_vs_PPTO = new Cumplimiento_vs_PPTO();
            var result = cumplimi_vs_PPTO.obtenerEstatusCumplimientoTCporMes_xTipo(mes, ano);
            listadoCumplimientoTCxTipo = new List<ListadoCumplimientoTCxTipo>();
            foreach (System.Data.DataRow rows in result.Rows)
            {
                var modelo_ejecutado = new ListadoCumplimientoTCxTipo()
                {
                    id_oficina = Convert.ToInt32(rows["id_oficina"]),
                    ejec_estandar = Convert.ToInt32(rows["CUMP_ESTANDAR"]),
                    ejec_gold = Convert.ToInt32(rows["CUMP_GOLD"]),
                    ejec_platinum = Convert.ToInt32(rows["CUMP_PLATINUM"]),
                    ejec_comercial = Convert.ToInt32(rows["CUMP_COMERCIAL"]),
                    ppto_estandar = Convert.ToInt32(rows["PPTO_ESTANDAR"]),
                    ppto_gold = Convert.ToInt32(rows["PPTO_GOLD"]),
                    ppto_platinum = Convert.ToInt32(rows["PPTO_PLATINUM"]),
                    ppto_comercial = Convert.ToInt32(rows["PPTO_COMERCIAL"]),
                   // nombre_oficina = Convert.ToString(rows["OFC"]),
                };



                listadoCumplimientoTCxTipo.Add(modelo_ejecutado);
                //calculate total net sales 

                total_ejec += Convert.ToDouble(rows[1]);
                total_ppto += Convert.ToDouble(rows[2]);

            }
            total_dif = total_ejec - total_ppto;
            //create net sales by period
            ////create temp list net sales by date

        }



        // CUMPLIMIENTO RESEUMEN POR ZONA 

        public List<DatosResumidos> resumeEstatus_xMes(int mes, int ano)
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
