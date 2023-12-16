using LojaMauricio.WebAPI.Dal.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace LojaMauricio.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContratoController : ControllerBase
    {
        private readonly IContrato _contrato;
        public ContratoController(IContrato contrato)
        {
            this._contrato = contrato;
        }

        [HttpGet]
        [Authorize(Roles = "employee, manager")]
        public Task<List<Model.Contrato>> Get()
        {
            return _contrato.GetContratos();
        }

        [HttpGet("{id}")]
        public Task<Model.Contrato> Get(string id)
        {
            return _contrato.GetContrato(id);
        }

        [HttpPost]
        public string Post([FromBody] Model.Contrato contrato) => _contrato.AddContrato(contrato);

        [HttpPut]
        public void Put([FromBody] Model.Contrato contrato)
        {
            _contrato.UpdateContrato(contrato);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "employee, manager")]
        public void Delete(string id)
        {
            _contrato.DeleteContrato(id);
        }

    }
}
