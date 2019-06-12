using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using SammyCloudAPI.Factories;
using SammyCloudAPI.Models;
using SammyCloudAPI.Settings;
using SammyCloudData.DAL;

namespace SammyCloudAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {

        private IUserRepository _userDAL;
        private IJwtFactory _jwtFactory;
        private JwtIssuerOptions _jwtOptions;

        public AuthController(IUserRepository userRepository, 
                              IJwtFactory jwtFactory, 
                              IOptions<JwtIssuerOptions> jwtOptions)
        {
            _userDAL = userRepository;
            _jwtFactory = jwtFactory;
            _jwtOptions = jwtOptions.Value;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Post([FromBody] Credentials credentials)
        {
            //see if credentials are valid
            var resultUser = await _userDAL.AuthorizeAsync(credentials.Username, credentials.Password);
            if (!resultUser.Success) { return Unauthorized(); }
            if (resultUser.Data == null) { return Unauthorized(); }

            //generate claims identity
            var identity = _jwtFactory.GenerateClaimsIdentity(resultUser.Data.Username, resultUser.Data.AccountID.ToString());
            if (identity == null) { return BadRequest(); }

            var response = new
            {
                id = identity.Claims.Single(c => c.Type == "id").Value,
                data = await _jwtFactory.GenerateEncodedToken(credentials.Username, identity),
                expires_in = (int)_jwtOptions.ValidFor.TotalSeconds
            };

            return new OkObjectResult(JsonConvert.SerializeObject(response));

        }
    }
}
