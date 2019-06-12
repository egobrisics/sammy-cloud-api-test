using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SammyCloudAPI.Factories;
using SammyCloudData.DAL;
using SammyCloudData.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SammyCloudAPI.Controllers
{
    [Route("api/[controller]")]
    public class PatientsController : Controller
    {

        private readonly IMapper _mapper;
        private readonly IPatientRepository _patientRepository;
        private readonly IJwtFactory _jwtFactory;

        public PatientsController(IMapper mapper,
                                  IPatientRepository patientRepository,
                                  IJwtFactory jwtFactory)
        {
            _mapper = mapper;
            _patientRepository = patientRepository;
            _jwtFactory = jwtFactory;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromHeader] string authorization, int id)
        {
            var resultToken = _jwtFactory.ValidateToken(authorization);
            if (!resultToken.Success || !int.TryParse(resultToken.Data, out int accountId))
            {
                return Unauthorized();
            }

            var result = await _patientRepository.Get(id, accountId);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            PatientDto patient = _mapper.Map<PatientDto>(result.Data);
            return Json(patient);
        }

    }
}
