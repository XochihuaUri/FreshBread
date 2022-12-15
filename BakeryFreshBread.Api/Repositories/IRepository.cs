using BakeryFreshBread.Api.Models;
using DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BakeryFreshBread.Api.Repositories
{
    public interface IRepository<T>
    {
        public Task<IEnumerable<T>> GetAll();

        public Task<ActionResult<T>> GetById(Guid id);


        public Task<T> Create(OfficeRequest officeRequest);


        public Task<bool> Delete(Guid id);

    }
}
