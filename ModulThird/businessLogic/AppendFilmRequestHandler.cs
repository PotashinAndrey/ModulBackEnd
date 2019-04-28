using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using ModulThird.Services;
using ModulThird.Models;
using MassTransit;
using ModulThird.Commands;


namespace ModulThird.BusinessLogic
{
    public class AppendFilmsRequestHandler
    {
        private readonly IBus _bus;

        public AppendFilmsRequestHandler(IBus bus)
        {
            _bus = bus;
        }

        public Task<Film> Handle(Film film)
        {
            Guid id = Guid.NewGuid();
            film.Id = id;

            _bus.Send(new AppendFilmCommand()
            {
                Film = film
            });

            return Task.FromResult<Film>(film);
        }
    }
}
