using Biblioteca.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";

        public bool acessar(String login, String senha)
        {

            loginDalComandos loginDal = new loginDalComandos();
            tem = loginDal.verificarLogin(login, senha);
            if (!loginDal.mensagem.Equals(""))
            {
                this.mensagem = loginDal.mensagem;
            }
            return tem;
           
        }
        public String cadastrar(String email, String senha, String confSenha)
        {
            return mensagem;
        }
         
     
    }
}
