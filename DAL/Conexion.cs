﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Conexion
    {
        private SqlConnection con;
        private SqlCommand cmd;

        public Conexion()
        {
            con = new SqlConnection("Data Source=APACHEW-PC\\SQLEXPRESS;Initial Catalog=ProyectoDB;Integrated Security=True");
            cmd = new SqlCommand();
        }

        public bool Ejecutar(String comando)
        {
            bool retorno = false;

            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
            return retorno;
        }

        public DataTable getDatos(String CmdSql)
        {
            SqlDataAdapter adapter;
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = CmdSql;

                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                con.Close();
            }
            return dt;
        }

    }
}
