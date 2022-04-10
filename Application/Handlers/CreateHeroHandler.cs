using Application.Commands;
using Application.Mappers;
using Application.Responses;
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
    public class CreateHeroHandler : IRequestHandler<CreateHeroCommand, HeroResponse>
    {
        private readonly IHeroRepository _heroRepo;
        public CreateHeroHandler(IHeroRepository heroRepository)
        {
            _heroRepo = heroRepository;
        }

        public async Task<HeroResponse> Handle(CreateHeroCommand request, CancellationToken cancellationToken)
        {
            var heroEntitiy = HeroMapper.Mapper.Map<Hero>(request);
            if (heroEntitiy is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newHero = await _heroRepo.AddAsync(heroEntitiy);
            var response = HeroMapper.Mapper.Map<HeroResponse>(newHero);
            return response;
        }
    }
}
