using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LuckyContractMgr.Models;
using LuckyContractMgr.Models.DataManager;
using LuckyContractMgr.Models.Repository;
using Microsoft.AspNetCore.Authorization;

namespace LuckyContractMgr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        private readonly IDataRepository<Contract> _dataRepository;
        public ContractController(IDataRepository<Contract> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        // GET: api/Contract
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Contract> Contracts = _dataRepository.GetAll();
            return Ok(Contracts);
        }
        // GET: api/Contract/5
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            Contract Contract = _dataRepository.Get(id);
            if (Contract == null)
            {
                return NotFound("The Contract record couldn't be found.");
            }
            return Ok(Contract);
        }
        // POST: api/Contract
        [HttpPost, Authorize]
        public IActionResult Post([FromBody] Contract Contract)
        {
            if (Contract == null)
            {
                return BadRequest("Contract is null.");
            }
            _dataRepository.Add(Contract);
            return CreatedAtRoute(
                  "Get",
                  new { Id = Contract.Id },
                  Contract);
        }
        // PUT: api/Contract/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Contract Contract)
        {
            if (Contract == null)
            {
                return BadRequest("Contract is null.");
            }
            Contract ContractToUpdate = _dataRepository.Get(id);
            if (ContractToUpdate == null)
            {
                return NotFound("The Contract record couldn't be found.");
            }
            _dataRepository.Update(ContractToUpdate, Contract);
            return NoContent();
        }
        // DELETE: api/Contract/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Contract Contract = _dataRepository.Get(id);
            if (Contract == null)
            {
                return NotFound("The Contract record couldn't be found.");
            }
            _dataRepository.Delete(Contract);
            return NoContent();
        }
    }
}

