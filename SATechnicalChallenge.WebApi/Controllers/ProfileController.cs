using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SATechnicalChallenge.Domain.Models;
using SATechnicalChallenge.Domain.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SATechnicalChallenge.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileService _profileService;
        private readonly ILogger<ProfileController> _logger;

        public ProfileController(IProfileService profileService, ILogger<ProfileController> logger)
        {
            _profileService = profileService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Profile>> Get()
        {            
            try
            {
                var profiles = await _profileService.GetProfiles();

                return profiles;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                throw ex;
            }
        }

        [HttpGet("{id}")]
        public async Task<Profile> Get(int id)
        {
            try
            {
                return await _profileService.GetProfile(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                throw ex;
            }
        }

        [HttpPost]
        public async Task Post([FromBody] Profile value)
        {
            try
            {
                await _profileService.AddProfile(value);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                throw ex;
            }
        }

        
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Profile value)
        {
            try
            {
                await _profileService.EditProfile(value);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            try
            {
                await _profileService.RemoveProfile(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                throw ex;
            }
        }
    }
}
