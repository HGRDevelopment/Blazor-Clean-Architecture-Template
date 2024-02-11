using HGR.Application.Abstractions;
using HGR.Domain.Entities;
using Microsoft.EntityFrameworkCore;



namespace HGR.Infrastructure.Repositories
{
    public class DummyRepository(DummyDbContext context) : IDummyRepository
    {
        public async Task<Dummyentitiy> AddDummy(Dummyentitiy toCreate)
        {
            context.Add(toCreate);
            await context.SaveChangesAsync();
            return toCreate;

        }

        public async Task DeleteDummy(int Id)
        {
            var dummyToDelete = context.Dummy.FirstOrDefaultAsync(x => x.Id == Id);

            if (dummyToDelete == null)
                return;

            context.Remove(dummyToDelete);
            await context.SaveChangesAsync();
        }

        public async Task<List<Dummyentitiy>> GetAll()
        {
            return await context.Dummy.ToListAsync();
        }

        public async Task<Dummyentitiy> GetDummyById(int Id)
        {
            return await context.Dummy.FirstOrDefaultAsync(x => x.Id == Id);
        }
        //TODO AUTOMAPPER / MODELS
        public async Task<Dummyentitiy> UpdateDummy(int Id, string name, string email)
        {
            var dummy = await context.Dummy.FirstOrDefaultAsync(x => x.Id == Id);


            dummy.Email = email;
            dummy.Name = name;
            await context.SaveChangesAsync();
            return dummy;
        }
    }
}
