using LojaMauricio.WebAPI.Dal.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace LojaMauricio.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedor _fornecedor;
        public FornecedorController(IFornecedor fornecedor)
        {
            this._fornecedor = fornecedor;
        }

        [HttpGet]
        public Task<List<Model.Fornecedor>> Get()
        {
            return _fornecedor.GetFornecedores();
        }

        [HttpGet("{id}")]
        public Task<Model.Fornecedor> Get(string id)
        {
            return _fornecedor.GetFornecedor(id);
        }

        [HttpPost]
        public string Post([FromBody] Model.Fornecedor fornecedor) => _fornecedor.AddFornecedor(fornecedor);

        [HttpPut]
        public void Put([FromBody] Model.Fornecedor fornecedor)
        {
            _fornecedor.UpdateFornecedor(fornecedor);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "employee, manager")]
        public void Delete(string id)
        {
            _fornecedor.DeleteFornecedor(id);
        }
    }
}
