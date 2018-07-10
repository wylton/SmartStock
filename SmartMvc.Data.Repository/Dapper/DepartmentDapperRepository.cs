using Dapper;
using DapperExtensions;
using SmartMvc.Domain.Entities;
using SmartMvc.Domain.Interfaces.Repository.ReadOnly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SmartMvc.Data.Repository.Dapper
{
    public class DepartmentDapperRepository : Common.Repository, IDepartmentReadOnlyRepository
    {

        public Department Get(int id)
        {
            using (var cn = SmartConnection)
            {
                var department = cn.Query<Department>("SELECT * FROM Department WHERE Id=@Id", new { Id = id }).FirstOrDefault();
                return department;
            }
        }

        public IEnumerable<Department> All()
        {
            using (var cn = SmartConnection)
            {
                var departments = cn.Query<Department>("SELECT * FROM Department");
                return departments;
            }
        }

        public IEnumerable<Department> Find(Expression<Func<Department, bool>> predicate)
        {
            using (var cn = SmartConnection)
            {
                var departments = cn.GetList<Department>(predicate);
                return departments;
            }
        }
    }
}
