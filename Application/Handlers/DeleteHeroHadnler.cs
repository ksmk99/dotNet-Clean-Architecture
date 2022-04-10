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
    public class DeleteHeroHandler : IRequestHandler<DeleteHeroCommand, HeroResponse>
    {
        private readonly IHeroRepository _heroRepo;
        public DeleteHeroHandler(IHeroRepository heroRepository)
        {
            _heroRepo = heroRepository;
        }

        public async Task<HeroResponse> Handle(DeleteHeroCommand request, CancellationToken cancellationToken)
        {
            var deleteHero = await _heroRepo.GetByIdAsync(request.HeroId);
            await _heroRepo.DeleteAsync(deleteHero);

            var response = HeroMapper.Mapper.Map<HeroResponse>(deleteHero);
            return response;
        }
    }
}
