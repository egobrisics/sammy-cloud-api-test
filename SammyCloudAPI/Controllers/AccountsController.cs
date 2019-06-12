using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SammyCloudData.DAL;
using SammyCloudData.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SammyCloudAPI.Controllers
{
    [Route("api/[controller]")]
    public class AccountsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAccountRepository _accountRepository;


        public AccountsController(IMapper mapper,
                                  IAccountRepository accountRepository)
        {
            _mapper = mapper;
            _accountRepository = accountRepository;
        }

        // GET: api/<controller>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _accountRepository.Get();
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            AccountDto account = _mapper.Map<AccountDto>(result.Data);
            return Json(account);
        }

        // GET api/<controller>/5
        [HttpPost("get")]
        public async Task<IActionResult> Get([FromBody()]int id)
        {
            var result = await _accountRepository.Get(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            AccountDto[] accounts = _mapper.Map<AccountDto[]>(result.Data);
            return Json(accounts);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
