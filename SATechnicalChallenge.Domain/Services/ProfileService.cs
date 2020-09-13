using SATechnicalChallenge.Domain.Models;
using SATechnicalChallenge.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SATechnicalChallenge.Domain.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IProfileRepository _profileRepository;

        public ProfileService(IProfileRepository profileRepository)
        {
            _profileRepository = profileRepository;
        }
        
        public Task<IEnumerable<Profile>> GetProfiles()
        {
           return _profileRepository.SelectAll();
        }

        public Task<Profile> AddProfile(Profile profile)
        {
            return _profileRepository.Insert(profile);
        }

        public Task<Profile> GetProfile(int id)
        {
            return _profileRepository.Select(id);
        }

        public Task<Profile> EditProfile(Profile profile)
        {
            return _profileRepository.Update(profile);
        }

        public Task<Profile> RemoveProfile(int id)
        {
            return _profileRepository.Delete(id);
        }
    }
}
