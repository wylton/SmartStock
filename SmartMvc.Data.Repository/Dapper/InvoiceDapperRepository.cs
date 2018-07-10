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
    public class InvoiceDapperRepository : Common.Repository, IInvoiceReadOnlyRepository
    {

        public Invoice Get(int id)
        {
            using (var cn = SmartConnection)
            {
                var invoice = cn.Query<Invoice>("SELECT * FROM Invoice WHERE Id=@Id", new { Id = id }).FirstOrDefault();
                return invoice;
            }
        }

        public IEnumerable<Invoice> All()
        {
            using (var cn = SmartConnection)
            {
                var invoices = cn.Query<Invoice>("SELECT * FROM Invoice");
                return invoices;
            }
        }

        public IEnumerable<Invoice> Find(Expression<Func<Invoice, bool>> predicate)
        {
            using (var cn = SmartConnection)
            {
                var invoices = cn.GetList<Invoice>(predicate);
                return invoices;
            }
        }
    }
}
