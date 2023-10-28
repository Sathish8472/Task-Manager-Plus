using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TaskManagerPlus.Domain.Entities;

namespace TaskManagerPlus.Domain.Services
{
    public class WorkService : IWorkService
    {
        public bool IsValidWork(Work work)
        {
            if (string.IsNullOrWhiteSpace(work.Name) ||
                string.IsNullOrWhiteSpace(work.Description) ||
                work.Date == DateTime.MinValue ||
                work.StartTime == TimeSpan.Zero ||
                work.Endtime == TimeSpan.Zero ||
                work.AssignedUser == null)
            {
                return false;
            }

            if (work.Endtime <= work.StartTime)
            {
                return false;
            }

            if (work.Date < DateTime.Today)
            {
                return false;
            }

            if (work.AssignedUser.Id <= 0 ||
                string.IsNullOrWhiteSpace(work.AssignedUser.FirstName) ||
                string.IsNullOrWhiteSpace(work.AssignedUser.LastName) ||
                string.IsNullOrWhiteSpace(work.AssignedUser.Email))
            {
                return false;
            }

            return true;
        }
    }
}
