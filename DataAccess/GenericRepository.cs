using DataAccess_Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        TestContext _context { get; set; }

        public GenericRepository(TestContext context)
        {
            this._context = context;
        }

        public async Task<T> GetAsync(int? id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            return entity;
        }

        //public async Task<TResult> GetAsync<TResult>(int? id)
        //{
        //    var result = await _context.Set<T>().FindAsync(id);
        //    return (TResult)(object)result;
        //}
    }
}
