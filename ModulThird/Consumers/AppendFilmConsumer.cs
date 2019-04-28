using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModulThird.Commands;
using ModulThird.Services;
using ModulThird.Infrastructure;
using MassTransit;


namespace ModulThird.Consumers
{
    public class AppendFilmConsumer : IConsumer<AppendFilmCommand>
    {
        private readonly IFilmAddToService _filmAddToService;

        public AppendFilmConsumer(IFilmAddToService filmAddToService)
        {
            _filmAddToService = filmAddToService;
        }

        public async Task Consume(ConsumeContext<AppendFilmCommand>context)
        {
            await _filmAddToService.SetFilm(context.Message.Film);
        }
    }
}
