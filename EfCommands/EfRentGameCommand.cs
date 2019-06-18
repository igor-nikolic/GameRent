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

            if (!Context.Users.Any(u => u.Id == req.UserId))
            {
                throw new UserDoesntExistException();
            }

            var game = Context.Rents
                .Where(r => r.GameId == req.GameId)
                .OrderByDescending(r => r.Id)
                .FirstOrDefault();
            
            if (game != null && game.ReturnedAt == null)
            {
                Console.WriteLine("Igrica nije vracena");
                throw new GameNotAvailableException();
            }
            Console.WriteLine("Igrica moze da se rentira!");
            Context.Rents.Add(new Rent
            {
                UserId = req.UserId,
                GameId = req.GameId
            });
            Context.SaveChanges();
        }
    }
}