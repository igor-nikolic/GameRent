using System;
using System.Linq;
using Application.Commands;
using Application.DataTransfer;
using Application.Exceptions;
using DataAccess;
using Microsoft.EntityFrameworkCore.Internal;

namespace EfCommands
{
    public class EfReturnGameCommand : BaseEfCommand,IReturnGameCommand
    {
        public EfReturnGameCommand(GameRentContext context) : base(context)
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
            
            if (!Context.Rents.Any(r => r.Id == req.Id))
            {
                throw new RentNotFoundException();
            }
            var rent = Context.Rents.Find(req.Id);
            if (rent.GameId != req.GameId || rent.UserId != req.UserId)
            {
                throw new BadDataException();
            }
            if (rent.ReturnedAt.HasValue)
            {
                throw new GameReturnedException();
            }
            rent.ReturnedAt = DateTime.Now;
            Context.SaveChanges();
        }
    }
}