using HGR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGR.Application.Abstractions
{
    public interface IDummyRepository
    {
        Task<List<Dummyentitiy>> GetAll();

        Task<Dummyentitiy> GetDummyById(int dummyId);

        Task<Dummyentitiy> AddDummy(Dummyentitiy toCreate);

        Task<Dummyentitiy> UpdateDummy(int dummyId, string name, string email);

        Task DeleteDummy(int dummyId);
    }
}
