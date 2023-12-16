namespace LojaMauricio.WebAPI.Dal.Repositories
{
    public interface IProduto
    {
        Task<List<Model.Produto>> GetProdutos();
        string AddProduto(Model.Produto produto);
        void UpdateProduto(Model.Produto produto);
        Task<Model.Produto> GetProduto(string id);
        void DeleteProduto(string id);
    }
}
