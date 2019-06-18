using System;
using System.Linq;
using Application.Commands;
using Application.DataTransfer;
using Application.Exceptions;
using DataAccess;
using Domain;

namespace EfCommands
{
    public class EfRentGameCommand : BaseEfCommand,IRentGameCommand
    {
        public EfRentGameCommand(GameRentContext context) : base(context)
        {
        }

        public void Execute(RentGameDto req)
        {
            if (!Context.Games.Any(g => g.Id == req.GameId))
            {
                throw new GameDoesntExistException();
            }

            if (Context.Games.Find(req.GameId).DeletedAt.HasValue)
            {
                throw new DeletedException();
            }
            
            if (!Context.Users.Any(u => u.Id == req.UserId))
            {
                throw new UserDoesntExistException();
            }

            var UserRents = Context.Rents
                .Any(r => r.UserId == req.UserId && !r.ReturnedAt.HasValue);  
                //.Where(r => r.GameId == req.GameId && r.ReturnedAt == null).
                //.FirstOrDefault();
            Console.WriteLine("user rents");
            Console.WriteLine(UserRents);
            if (UserRents)
            {
                throw new ActiveRentException();
            }

            var game = Context.Rents
                .Where(r => r.GameId == req.GameId)
                .OrderByDescending(r => r.Id)
                .FirstOrDefault();
            
            if (game != null && !game.ReturnedAt.HasValue)
            {
                Console.WriteLine("Igrica nije vracena");
                throw new GameNotAvailableException();
            }
            Context.Rents.Add(new Rent
            {
                UserId = req.UserId,
                GameId = req.GameId
            });
            Context.SaveChanges();
        }
    }
}