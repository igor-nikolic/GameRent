using System;
using System.Linq;
using Application.Commands;
using Application.DataTransfer;
using DataAccess;
using Application.Exceptions;
using Domain;
namespace EfCommands
{
    public class EfAddGameCommand : BaseEfCommand,IAddGameCommand
    {
        public EfAddGameCommand(GameRentContext context) : base(context)
        {
        }

        public void Execute(AddGameDto req)
        {
            if (Context.Games.Any(g => g.Name == req.Name)) throw new GameExistsException();
            if (!Context.Companies.Any(c => c.Id == req.CompanyId)) throw new CompanyDoesntExistException();
            if (!Context.Categories.Any(c => c.Id == req.CategoryId)) throw new CategoryDoesntExistException();
            Context.Games.Add(new Game
                {
                    Name = req.Name,
                    Description =  req.Description,
                    CategoryId = req.CategoryId,
                    CompanyId = req.CompanyId
                });
            Context.SaveChanges();
        }
    }
}