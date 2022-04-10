using Application.Responses;
using MediatR;
using System;

namespace Application.Commands
{
    public class CreateHeroCommand : IRequest<HeroResponse>
    {
        public Int64 HeroId { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Power { get; set; }
    }
}
