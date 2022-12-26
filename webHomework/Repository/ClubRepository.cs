using Microsoft.EntityFrameworkCore;
using webHomework.Data;
using webHomework.Interfaces;
using webHomework.Models;

namespace webHomework.Repository
{
    public class Club_Repoistory : IClubRepository
    {
        private readonly ApplicationDbContext _context;

        public Club_Repoistory(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Club club)
        {
            _context.Add(club);
            return Save();
        }

        public bool Delete(Club club)
        {
            _context.Remove(club);
            return Save();
        }

        public async Task<IEnumerable<Club>> GetAll()
        {
            return await _context.Clubs.ToListAsync();
        }

        public Task<Club> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Club>> GetClubByCity(string city)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(Club club)
        {
            throw new NotImplementedException();
        }
    }
}
