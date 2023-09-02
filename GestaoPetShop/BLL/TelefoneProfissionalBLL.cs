using System;
using DAL;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TelefoneProfissionalBLL
    {
        public void Alterar(TelefoneProfissional _telefoneProfissional)
        {
            new TelefoneProfissionalDAL().Alterar(_telefoneProfissional);

        }
        public void Inserir (TelefoneProfissional _telefoneProfissional)
        {
            new TelefoneProfissionalDAL().Inserir(_telefoneProfissional);

        }
        public void Excluir (int _id)
        {
            new TelefoneProfissionalDAL().Excluir(_id);
        }
    }
}
