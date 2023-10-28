using TaskManagerPlus.Domain.Entities;

namespace TaskManagerPlus.Domain.Services
{
    public interface IWorkService 
    {
        public bool IsValidWork(Work work);
    }
}
