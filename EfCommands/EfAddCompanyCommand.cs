using System.Linq;
using Application.Commands;
using Application.DataTransfer;
using DataAccess;
using Application.Exceptions;
using Domain;
namespace EfCommands
{
    public class EfAddCompanyCommand : BaseEfCommand,IAddCompanyCommand
    {
        public EfAddCompanyCommand(GameRentContext context) : base(context)
        {
        }
        
        public void Execute(CompanyDto req)
        {
            if (Context.Companies.Any(c => c.Name == req.Name))
            {
                throw new CompanyExistsException();
            }

            Context.Companies.Add(new Company
            {
                Name = req.Name
            });
            Context.SaveChanges();
        }
    }
}