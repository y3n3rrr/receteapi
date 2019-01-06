using EReceteAPI.Database;
using EReceteAPI.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class UserRepository : GenericRepository<Users>, IUserRepository
    {
        public UserRepository(EReceteDBContext dbContext)
            : base(dbContext)
        {
        }

        public async Task<Users> GetCoolestCategory()
        {
            return await GetAll()
                .OrderByDescending(c => c.TckimlikNo)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Users>> GetAllByAsync()
        {
            return await GetAll().ToListAsync();
        }
    }
}
