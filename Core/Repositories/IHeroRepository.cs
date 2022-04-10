using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Base
{
    public interface IHeroRepository : IRepository<Core.Entities.Hero>
    {
        Task<IEnumerable<Core.Entities.Hero>> GetEmployeeByLastName(string lastname);
    }
}
