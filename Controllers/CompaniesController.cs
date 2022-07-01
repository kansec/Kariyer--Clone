using AutoMapper;
using KariyerClone.Models.Dtos;
using KariyerClone.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace KariyerClone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;
        public CompaniesController(ICompanyRepository companyRepository,IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;

        }

        [HttpGet]
        public async Task<ActionResult<List<CompanyDto>>> GetAll()
        {

            var result = await _companyRepository.GetAllAysnc();

            var companies = _mapper.Map<List<CompanyDto>>(result);

            return Ok(companies);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CompanyDto>> GetById(int id)
        {
            var result = await _companyRepository.GetByIdAsync(id);

            if(result == null)
            {
                return NotFound();
            }

            var company = _mapper.Map<CompanyDto>(result);

            return Ok(company);
        }


    }
}
