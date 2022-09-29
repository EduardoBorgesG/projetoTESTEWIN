using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql;

namespace projetoTESTEWIN
{
    internal class Conec
    {
        //conexão banco de dados local
        string conexao = ("SERVER=localhost; DATABASE=testeDev; UID=root; PWD=senha; PORT=;");
        public MySqlConnection con = null;

        public void AbrirCon()
        {
            try
            {
                con = new MySqlConnection(conexao);
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
                con = new MySqlConnection(conexao);
                con.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
