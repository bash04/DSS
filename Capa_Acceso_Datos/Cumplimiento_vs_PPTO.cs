 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Acceso_Datos
{
  public  class Cumplimiento_vs_PPTO : ConexionSql
    {

        // CUMPLIMIENTO POR OFICINAS 

        public DataTable obtenerEstatusCumplimientoTCporMes(int mes, int ano)
        {
            using (var conexion = obtenerConexion())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = @"consulta_cumplimiento_TC";
                    command.Parameters.AddWithValue("@mes", mes);
                    command.Parameters.AddWithValue("@anoc", ano);
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();
                    return table;
                }
            }


        }

        public DataTable obtenerEstatusCumplimientoTC_3meses()
        {
            using (var conexion = obtenerConexion())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = @"consulta_cumplimiento_TC_ultimos_3meses";
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();
                    return table;
                }
            }


        }

        public DataTable obtenerEstatusCumplimientoTC_EneroAlaFecha()
        {
            using (var conexion = obtenerConexion())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = @"consulta_cumplimiento_TC_eneroAlaFecha";
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();
                    return table;
                }
            }
        }


        // CUMPLIMIENTO RESEUMEN POR ZONA 
        
        public DataTable obtenerResumenCumplimientoTCporMes(int mes, int ano)
        {
            using (var conexion = obtenerConexion())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = @"consulta_estatusTC_por_mes";
                   command.Parameters.AddWithValue("@mes", mes);
                   command.Parameters.AddWithValue("@ano", ano);
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();
                    return table;
                }
            }


        }

        public DataTable obtenerResumenCumplimientoTC_ultimos3Meses()
        {
            using (var conexion = obtenerConexion())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = @"consulta_estatusTC_ultimos_3meses";
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();
                    return table;
                }
            }


        }

        public DataTable obtenerResumenCumplimientoTC_EneroAlaFecha()
        {
            using (var conexion = obtenerConexion())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = @"consulta_estatusTC_eneroAlaFecha";
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();
                    return table;
                }
            }


        }


        // CUMPLIMIENTO POR OFICINAS POR TIPO TARJETA

        public DataTable obtenerEstatusCumplimientoTCporMes_xTipo(int mes, int ano)
        {
            using (var conexion = obtenerConexion())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = @"consulta_cumplimiento_TC_xMes_xTipo";
                    command.Parameters.AddWithValue("@mes", mes);
                    command.Parameters.AddWithValue("@anoc", ano);
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();
                    return table;
                }
            }


        }

    }
}
