using SATechnicalChallenge.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SATechnicalChallenge.Domain.Services
{
    public interface IProfileService
    {
        Task<IEnumerable<Profile>> GetProfiles();
        Task<Profile> AddProfile(Profile profile);
        Task<Profile> GetProfile(int id);
        Task<Profile> EditProfile(Profile profile);
        Task<Profile> RemoveProfile(int id);
    }
}
