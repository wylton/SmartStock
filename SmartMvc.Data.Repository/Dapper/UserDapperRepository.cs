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
    public class UserDapperRepository : Common.Repository, IUserReadOnlyRepository
    {

        public User Get(int id)
        {
            using (var cn = SmartConnection)
            {
                var movimentBox = cn.Query<User>("SELECT * FROM [User] WHERE Id=@Id", new { Id = id }).FirstOrDefault();
                return movimentBox;
            }
        }

        public IEnumerable<User> All()
        {
            using (var cn = SmartConnection)
            {
                var movimentBoxes = cn.Query<User>("SELECT * FROM [User]");
                return movimentBoxes;
            }
        }

        public IEnumerable<User> Find(Expression<Func<User, bool>> predicate)
        {
            using (var cn = SmartConnection)
            {
                var movimentBoxes = cn.GetList<User>(predicate);
                return movimentBoxes;
            }
        }
    }
}
