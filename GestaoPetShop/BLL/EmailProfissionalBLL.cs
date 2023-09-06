using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmailProfissionalBLL
    {
        public void Inserir(EmailProfissional _emailProfissional)
        {
            new EmailProfissionalDAL().Inserir(_emailProfissional);
        }//Givas
        public void Alterar(EmailProfissional _emailProfissional)
        {
            new EmailProfissionalDAL().Alterar(_emailProfissional);
        }//Givas
        public void Excluir(int _id)
        {
            new EmailProfissionalDAL().Excluir(_id);
        }//Givas
    }

}
