﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    class Conexao
    {
        string conec = "SERVER=localhost, DATABASE=tcc; UID=root; PWD=; PORT=;";
        public MySqlConnection con = null;
        public void AbrirCon()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Open();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public void FecharCon()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //declaração das variáveis

    }
}
