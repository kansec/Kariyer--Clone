using KariyerClone.Data;
using KariyerClone.Models;
using Microsoft.EntityFrameworkCore;

namespace KariyerClone.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly AppDbContext _context;

        public CompanyRepository(AppDbContext context)
        {
            _context = context;

        }
        public async Task<List<Company>> GetAllAysnc()
        {
            return await _context.Companies.ToListAsync();
        }

        public async Task<Company> GetByIdAsync(int id)
        {
            var company = await _context.Companies.SingleOrDefaultAsync(c => c.Id == id);

            return company;
        }
    }
}
