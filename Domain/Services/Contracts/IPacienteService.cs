using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Services.Contracts
{
    public interface IPacienteService
    {
        void AddOrUpdate(PacienteViewModel model);
        Task<IEnumerable<PacienteViewModel>> GetAsync();
        Task<PacienteViewModel> GetById(string id);
        void Remove(string id);
    }
}
