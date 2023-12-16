namespace LojaMauricio.WebAPI.Dal.Repositories
{
    public interface IFornecedor
    {
        Task<List<Model.Fornecedor>> GetFornecedores();
        string AddFornecedor(Model.Fornecedor fornecedor);
        void UpdateFornecedor(Model.Fornecedor fornecedor);
        Task<Model.Fornecedor> GetFornecedor(string id);
        void DeleteFornecedor(string id);
    }
}
