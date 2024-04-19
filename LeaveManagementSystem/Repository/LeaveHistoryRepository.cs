using LeaveManagementSystem.Contracts;
using LeaveManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public LeaveHistoryRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Add(LeaveHistory entity)
        {
            _dbContext.LeaveHistories.Add(entity);
            return Save();
        }

        public bool Delete(LeaveHistory entity)
        {
            _dbContext.LeaveHistories.Remove(entity);
            return Save();
        }

        public bool Exists(int id)
        {
            return _dbContext.LeaveHistories.Any(l => l.Id == id);
        }

        public LeaveHistory FindById(int id)
        {
            return _dbContext.LeaveHistories.FirstOrDefault(l => l.Id == id);
        }

        public ICollection<LeaveHistory> GetAll()
        {
            return _dbContext.LeaveHistories.ToList();
        }

        public bool Save()
        {
            return _dbContext.SaveChanges() > 0;
        }

        public bool Update(LeaveHistory entity)
        {
            _dbContext.LeaveHistories.Update(entity);
            return Save();
        }
    }
}