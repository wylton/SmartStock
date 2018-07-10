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
    public class MovimentItemDapperRepository : Common.Repository, IMovimentItemReadOnlyRepository
    {

        public MovimentItem Get(int id)
        {
            using (var cn = SmartConnection)
            {
                var movimentBox = cn.Query<MovimentItem>("SELECT * FROM MovimentItem WHERE Id=@Id", new { Id = id }).FirstOrDefault();
                return movimentBox;
            }
        }

        public IEnumerable<MovimentItem> All()
        {
            using (var cn = SmartConnection)
            {
                var movimentItems = cn.Query<MovimentItem>("SELECT * FROM MovimentItem");
                return movimentItems;
            }
        }

        public IEnumerable<MovimentItem> Find(Expression<Func<MovimentItem, bool>> predicate)
        {
            using (var cn = SmartConnection)
            {
                var movimentItems = cn.GetList<MovimentItem>(predicate);
                return movimentItems;
            }
        }
    }
}
