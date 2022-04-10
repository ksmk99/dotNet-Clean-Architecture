using Application.Queries;
using Core.Entities;
using Core.Repositories.Base;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers
{
    public class GetAllHeroesHandler : IRequestHandler<GetAllHeroQuery, List<Hero>>
    {
        private readonly IHeroRepository _heroPero;
        public GetAllHeroesHandler(IHeroRepository animeRepository)
        {
            _heroPero = animeRepository;
        }

        public Task<List<Hero>> Handle(GetAllHeroQuery request, CancellationToken cancellationToken)
        {
            return _heroPero.GetAllAsync();
        }
    }
}
