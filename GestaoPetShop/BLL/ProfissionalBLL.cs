namespace BLL
{
    internal class ProfissionalBLL
    {
        public void Inserir(Profissional _profissional)
        {
            new ProfissionalDAL().Inserir(_profissional);
        }
        public List<Profissional> BuscarTodos()
        {
            return new ProfissionalDAL().BuscarTodos();
        }
        public List<Profissional> BuscarPorNome(string _nome)
        {
            return new ProfissionalDAL().BuscarPorNome(_nome);
        }
        public void Alterar(Profissional _cliente)
        {
            new ProfissionalDAL().Alterar(_cliente);
        }
        public void Excluir(int _id)
        {
            new ProfissionalDAL().Excluir(_id);
        }
    }
}
