using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmailClienteBLL
    {
        public void Excluir(int _id)
        {
            new EmailClienteDAL().Excluir(_id);
        }
        
    }
}
