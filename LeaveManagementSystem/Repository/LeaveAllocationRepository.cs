using LeaveManagementSystem.Contracts;
using LeaveManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public LeaveAllocationRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Add(LeaveAllocation entity)
        {
            _dbContext.LeaveAllocations.Add(entity);
            return Save();
        }

        public bool Delete(LeaveAllocation entity)
        {
            _dbContext.LeaveAllocations.Remove(entity);
            return Save();
        }

        public bool Exists(int id)
        {
            return _dbContext.LeaveAllocations.Any(l => l.Id == id);
        }

        public LeaveAllocation FindById(int id)
        {
            return _dbContext.LeaveAllocations.FirstOrDefault(l => l.Id == id);
        }

        public ICollection<LeaveAllocation> GetAll()
        {
            return _dbContext.LeaveAllocations.ToList();
        }

        public bool Save()
        {
            return _dbContext.SaveChanges() > 0;
        }

        public bool Update(LeaveAllocation entity)
        {
            _dbContext.LeaveAllocations.Update(entity);
            return Save();
        }
    }
}