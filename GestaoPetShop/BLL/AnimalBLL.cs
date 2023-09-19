using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;

namespace BLL
{
    public class AnimalBLL
    {
        public void Inserir(Animal _animal)
        {
            ValidarDados(_animal);
            new AnimalDAL().Inserir(_animal);
        }
        private void ValidarDados(Animal _animal)
        {
            if (String.IsNullOrEmpty(_animal.Nome))
                throw new Exception("Informe o nome do Animal.");

        }
        public void Alterar(Animal _animal)
        {
            new AnimalDAL().Alterar(_animal);
        }
        public void Excluir(int _id)
        {
            new AnimalDAL().Excluir(_id);
        }
        public List<Animal> BuscarTodos()
        {
            return new AnimalDAL().BuscarTodos();
        }
        public Animal BuscarPorId(int _id)
        {
            return new AnimalDAL().BuscarPorId(_id);
        }
        public List<Raca> BuscarPorEspecie(string _animal)
        {
            return new AnimalDAL().BuscarPorEspecie(_animal);
        }
        public List<Animal> BuscarPorNome(string _nome)
        {
            return new AnimalDAL().BuscarPorNome(_nome);
        }
        public List<Animal> BuscarPorRaca(string _raca)
        {
            return new AnimalDAL().BuscarPorRaca(_raca);
        }
        public bool ExisteVinculo(int _id)
        {
            AnimalBLL animalBLL = new AnimalBLL();
            return animalBLL.ExisteVinculo(_id);
        }

    }
}
