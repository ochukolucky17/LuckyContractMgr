using LuckyContractMgr.Models;
using LuckyContractMgr.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LuckyContractMgr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IDataRepository<LoginModel> _dataRepository;
        public AuthController(IDataRepository<LoginModel> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        // GET api/values
        [HttpPost, Route("login")]
        public IActionResult Login([FromBody] LoginViewModel user)
        {
            if (user == null)
            {
                return BadRequest("Invalid client request");
            }
            LoginModel LoginModel = _dataRepository.GetByUsernamePassword(user.UserName, user.Password);
            if (LoginModel == null)
            {
                return Unauthorized();
            }
            else
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var tokeOptions = new JwtSecurityToken(
                    issuer: "http://localhost:5000",
                    audience: "http://localhost:5000",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: signinCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return Ok(new { Token = tokenString });
                
            }
        }
    }
}
