using System.Linq;
using Application.Commands;
using Application.DataTransfer;
using DataAccess;
using Application.Exceptions;
using Domain;
using System;

namespace EfCommands
{
    public class EfAddCategoryCommand : BaseEfCommand, IAddCategoryCommand
    {
        public EfAddCategoryCommand(GameRentContext context) : base(context)
        {
        }
        public void Execute(CategoryDto req)
        {
            if (Context.Categories.Any(c => c.Name == req.Name)) throw new CategoryExistsException();
            
            Context.Categories.Add(new Category
            {  
                Name = req.Name
            });
            Context.SaveChanges();
        }

        
    }
}