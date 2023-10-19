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
            new UsuarioBLL().ValidarPermissao(12);
            ValidarDados(_animal);
            new AnimalDAL().Inserir(_animal);
        }
        private void ValidarDados(Animal _animal)
        {
            if (String.IsNullOrEmpty(_animal.Nome))
                throw new Exception("Informe o nome do Animal.");

            if (_animal.IdCliente == 0)
                throw new Exception("Informe o Cliente");

            if (_animal.IdRaca == 0)
                throw new Exception("Informe a Raça");

            if (String.IsNullOrEmpty(_animal.Agressivo))
                throw new Exception("Informe se é agressivo");

            if(_animal.Id == 0)
            {
                if (_animal.Ativo == false)
                    throw new Exception("Marque o ativo");
            }
            else
            {
                Animal animal = new AnimalBLL().BuscarPorId(_animal.Id);
                if(_animal.Ativo != animal.Ativo)
                    new UsuarioBLL().ValidarPermissao(37);
            }

            if (String.IsNullOrEmpty(_animal.Cor))
                throw new Exception("Informe a cor do animal");


        }
        public void Alterar(Animal _animal)
        {
            new UsuarioBLL().ValidarPermissao(21);
            ValidarDados(_animal);
            new AnimalDAL().Alterar(_animal);
        }
        public void Excluir(int _id)
        {
            new UsuarioBLL().ValidarPermissao(30);
            new AnimalDAL().Excluir(_id);
        }
        public List<Animal> BuscarTodos()
        {
            new UsuarioBLL().ValidarPermissao(3);
            return new AnimalDAL().BuscarTodos();
        }
        public Animal BuscarPorId(int _id)
        {
            new UsuarioBLL().ValidarPermissao(3);
            return new AnimalDAL().BuscarPorId(_id);
        }
        public List<Raca> BuscarPorEspecie(string _animal)
        {
            new UsuarioBLL().ValidarPermissao(3);
            return new AnimalDAL().BuscarPorEspecie(_animal);
        }
        public List<Animal> BuscarPorNome(string _nome)
        {
            new UsuarioBLL().ValidarPermissao(3);
            return new AnimalDAL().BuscarPorNome(_nome);
        }
        public List<Animal> BuscarPorRaca(string _raca)
        {
            new UsuarioBLL().ValidarPermissao(3);
            return new AnimalDAL().BuscarPorRaca(_raca);
        }
        public bool ExisteVinculo(int _id)
        {
            AnimalBLL animalBLL = new AnimalBLL();
            return animalBLL.ExisteVinculo(_id);
        }

    }
}
