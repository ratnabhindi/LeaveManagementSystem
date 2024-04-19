using LeaveManagementSystem.Contracts;
using LeaveManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public LeaveTypeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Add(LeaveType entity)
        {
            _dbContext.LeaveTypes.Add(entity);
            return Save();
        }

        public bool Delete(LeaveType entity)
        {
            _dbContext.LeaveTypes.Remove(entity);
            return Save();
        }

        public bool Exists(int id)
        {
            return _dbContext.LeaveTypes.Any(l => l.Id == id);
        }

        public LeaveType FindById(int id)
        {
            ///find
            return _dbContext.LeaveTypes.FirstOrDefault(l => l.Id == id);
        }

        public ICollection<LeaveType> GetAll()
        {
            return _dbContext.LeaveTypes.ToList();
        }

        public ICollection<LeaveType> GetEmployeesByLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            return _dbContext.SaveChanges() > 0;
        }

        public bool Update(LeaveType entity)
        {
            _dbContext.LeaveTypes.Update(entity);
            return Save();
        }
    }
}