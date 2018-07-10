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
    public class BoxDapperRepository : Common.Repository, IBoxReadOnlyRepository
    {

        public Box Get(int id)
        {
            using (var cn = SmartConnection)
            {
                var Box = cn.Query<Box>("SELECT * FROM Box WHERE Id=@Id", new { Id = id }).FirstOrDefault();
                return Box;
            }
        }

        public IEnumerable<Box> All()
        {
            using (var cn = SmartConnection)
            {
                var Boxs = cn.Query<Box>("SELECT * FROM Box");
                return Boxs;
            }
        }

        public IEnumerable<Box> Find(Expression<Func<Box, bool>> predicate)
        {
            using (var cn = SmartConnection)
            {
                var Boxs = cn.GetList<Box>(predicate);
                return Boxs;
            }
        }
    }
}
