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
            if (Context.Games.Any(g => g.CompanyId != req.CompanyId)) throw new CompanyDoesntExistException();
            if (Context.Games.Any(g => g.CategoryId != req.CategoryId)) throw new CategoryDoesntExistException();
            Context.Games.Add(new Game
                {
                    Name = req.Name,
                    Description =  req.Description,
                    Size = req.Size,
                    CategoryId = req.CategoryId,
                    CompanyId = req.CompanyId
                });
            Context.SaveChanges();
        }
    }
}