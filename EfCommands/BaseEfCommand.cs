using DataAccess;

namespace EfCommands
{
    public abstract class BaseEfCommand
    {
        protected GameRentContext Context { get; set; }

        protected BaseEfCommand(GameRentContext context) => Context = context;
    }
}