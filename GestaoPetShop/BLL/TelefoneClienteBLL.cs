using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TelefoneClienteBLL
    {
        public void Excluir(int _id)
        {
            new TelefoneClienteDAL().Excluir(_id);
        }
    }
}
