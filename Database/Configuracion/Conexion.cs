﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Database.Configuracion
{
    public class Conexion
    {
        private readonly string ConnectionString = @"server=DESKTOP-ELMP60R\MSSQLSERVER001;database=BDSEGURIDAD;user=fernando;password=123456";
        /// <summary>
        /// Propiedad que devuelve un tipo de dato
        /// </summary>
        public IDbConnection GetConnectionSeguridad 
        {
            get { return GetConnection(ConnectionString); }
        }

        private IDbConnection GetConnection(string connectionString)
        {
            var connection = new SqlConnection();

            try
            {
                if (connection is null)
                    return null;

                connection.ConnectionString = connectionString;
                connection.Open();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

            return connection;
        }
    }
}
