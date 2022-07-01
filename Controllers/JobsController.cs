using AutoMapper;
using KariyerClone.Data;
using KariyerClone.Models;
using KariyerClone.Models.Dtos;
using KariyerClone.Repositories;
using KariyerClone.RequestHelpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace KariyerClone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class JobsController : ControllerBase
    {

        private readonly IJobRepository _jobRepository;
        private readonly IMapper _mapper;

        public JobsController(IJobRepository jobRepository, IMapper mapper)
        {
            _jobRepository = jobRepository;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<List<JobDto>>> GetJobs([FromQuery]JobParams jobParams)
        {
            var jobs = await _jobRepository.GetAllWithParams(jobParams);

            var jobsMapped = _mapper.Map<List<JobDto>>(jobs);

            Response.AddPaginationHeader(jobs.MetaData);


            return Ok(jobsMapped);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<JobDetailsDto>> GetJobById(int id)
        {
            var job = await _jobRepository.GetJobByIdAsync(id);

            if(job == null)
            {
                return NotFound();
            }

            var jobMapped = _mapper.Map<JobDetailsDto>(job);

            return Ok(jobMapped);

        }

        [HttpGet("filters")]
        public async Task<IActionResult> GetFilters()
        {
            var filters =  await _jobRepository.GetFilters();
            return Ok(filters);

        }
    }
}
