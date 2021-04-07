using AutoMapper;
using DataAccess.Models;
using Domain.Models;

namespace TesteApp.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Paciente, PacienteViewModel>();
            CreateMap<PacienteViewModel, Paciente>();
        }
    }
}
