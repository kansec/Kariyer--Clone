using KariyerClone.Models;

namespace KariyerClone.Repositories
{
    public interface ICompanyRepository
    {
        Task<List<Company>> GetAllAysnc();
        Task<Company> GetByIdAsync(int id);

    }
}
