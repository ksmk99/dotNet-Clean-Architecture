using Core.Entities;
using Core.Repositories.Base;
using Infrastructure.Data;
using Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class HeroRepository : Repository<Hero>, IHeroRepository
    {
        public HeroRepository(HeroContext employeeContext) : base(employeeContext) { }

        public async Task<IEnumerable<Hero>> GetEmployeeByLastName(string name)
        {
            return await _employeeContext.Heroes
                .Where(m => m.Name == name)
                .ToListAsync();
        }
    }
}
