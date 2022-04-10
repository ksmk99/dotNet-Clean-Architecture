using Application.Responses;
using MediatR;
using System;

namespace Application.Commands
{
    public class DeleteHeroCommand : IRequest<HeroResponse>
    {
        public Int64 HeroId { get; set; }
    }
}
