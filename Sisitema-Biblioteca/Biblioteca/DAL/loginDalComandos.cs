using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAL
{
    class loginDalComandos
    {
        public bool tem = false;
        public String mensagem = "";//tudo ok!
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin (String login, String senha)
        {
            //comando para verificar se tem no banco
            cmd.CommandText = "select * fron npmeDaTabela where email = @login and senha = @senha ";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (SqlException)
            {

                this.mensagem = "Erro com banco de Dados!";

            }
            return tem;
        }

         public String cadadastrar(String email, String senha, String confSenha)
        {
           //comando para inserir no banco
            return mensagem;
        }
    }
}
