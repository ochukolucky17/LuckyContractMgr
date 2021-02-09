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

namespace LuckyLoginModelMgr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginModelController : ControllerBase
    {
        private readonly IDataRepository<LoginModel> _dataRepository;
        public LoginModelController(IDataRepository<LoginModel> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        // GET: api/LoginModel
        [HttpGet,Authorize]
        public IActionResult Get()
        {
            IEnumerable<LoginModel> LoginModels = _dataRepository.GetAll();
            return Ok(LoginModels);
        }
        // GET: api/LoginModel/5
        [HttpGet("{id}"), Authorize]
        public IActionResult Get(long id)
        {
            LoginModel LoginModel = _dataRepository.Get(id);
            if (LoginModel == null)
            {
                return NotFound("The LoginModel record couldn't be found.");
            }
            return Ok(LoginModel);
        }
        // POST: api/LoginModel
        [HttpPost]
        public IActionResult Post([FromBody] LoginModel LoginModel)
        {
            if (LoginModel == null)
            {
                return BadRequest("LoginModel is null.");
            }
            _dataRepository.Add(LoginModel);
            return CreatedAtRoute(
                  "Get",
                  new { Id = LoginModel.Id },
                  LoginModel);
        }
        // PUT: api/LoginModel/5
        [HttpPut("{id}"), Authorize]
        public IActionResult Put(long id, [FromBody] LoginModel LoginModel)
        {
            if (LoginModel == null)
            {
                return BadRequest("LoginModel is null.");
            }
            LoginModel LoginModelToUpdate = _dataRepository.Get(id);
            if (LoginModelToUpdate == null)
            {
                return NotFound("The LoginModel record couldn't be found.");
            }
            _dataRepository.Update(LoginModelToUpdate, LoginModel);
            return NoContent();
        }
        // DELETE: api/LoginModel/5
        [HttpDelete("{id}"), Authorize]
        public IActionResult Delete(long id)
        {
            LoginModel LoginModel = _dataRepository.Get(id);
            if (LoginModel == null)
            {
                return NotFound("The LoginModel record couldn't be found.");
            }
            _dataRepository.Delete(LoginModel);
            return NoContent();
        }
    }
}

