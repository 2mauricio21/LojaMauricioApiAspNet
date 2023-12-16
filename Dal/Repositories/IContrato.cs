namespace LojaMauricio.WebAPI.Dal.Repositories
{
    public interface IContrato
    {
        Task<List<Model.Contrato>> GetContratos();
        string AddContrato(Model.Contrato contrato);
        void UpdateContrato(Model.Contrato contrato);
        Task<Model.Contrato> GetContrato(string id);
        void DeleteContrato(string id);
    }
}
