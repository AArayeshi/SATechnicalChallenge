using Newtonsoft.Json;
using SATechnicalChallenge.Domain.Models;
using SATechnicalChallenge.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATechnicalChallenge.Infrastructure.Repositories
{
    public class ProfileJsonRepository : IProfileRepository
    {
        private readonly string _dataFilePath;

        public ProfileJsonRepository(string dataFilePath)
        {
            _dataFilePath = dataFilePath;
        }
        public Task<IEnumerable<Profile>> SelectAll()
        {
            return Task.Run(() =>
            {
                var json = System.IO.File.ReadAllText(_dataFilePath);

                return JsonConvert.DeserializeObject<IEnumerable<Profile>>(json);

            });
        }        

        public Task<Profile> Insert(Profile obj)
        {
            throw new NotImplementedException();
        }

        public Task<Profile> Select(int Id)
        {
            throw new NotImplementedException();
        }        

        public Task<Profile> Update(Profile obj)
        {
            throw new NotImplementedException();
        }

        public Task<Profile> Delete(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
