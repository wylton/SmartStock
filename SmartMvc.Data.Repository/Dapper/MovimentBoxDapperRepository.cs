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
    public class MovimentBoxDapperRepository : Common.Repository, IMovimentBoxReadOnlyRepository
    {

        public MovimentBox Get(int id)
        {
            using (var cn = SmartConnection)
            {
                var movimentBox = cn.Query<MovimentBox>("SELECT * FROM MovimentBox WHERE Id=@Id", new { Id = id }).FirstOrDefault();
                return movimentBox;
            }
        }

        public IEnumerable<MovimentBox> All()
        {
            using (var cn = SmartConnection)
            {
                var movimentBoxes = cn.Query<MovimentBox>("SELECT * FROM MovimentBox");
                return movimentBoxes;
            }
        }

        public IEnumerable<MovimentBox> Find(Expression<Func<MovimentBox, bool>> predicate)
        {
            using (var cn = SmartConnection)
            {
                var movimentBoxes = cn.GetList<MovimentBox>(predicate);
                return movimentBoxes;
            }
        }
    }
}
