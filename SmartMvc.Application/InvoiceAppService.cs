using SmartMvc.Application.Interfaces;
using SmartMvc.Data.Context;
using SmartMvc.Domain.Entities;
using SmartMvc.Domain.Interfaces.Service;
using SmartMvc.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SmartMvc.Application
{
    public class InvoiceAppService : AppService<SmartContext>, IInvoiceAppService
    {
        private readonly IInvoiceService _service;

        public InvoiceAppService(IInvoiceService invoiceService)
        {
            _service = invoiceService;
        }

        public ValidationResult Create(Invoice invoice)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Add(invoice));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public ValidationResult Update(Invoice invoice)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Update(invoice));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public ValidationResult Remove(Invoice invoice)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Delete(invoice));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public Invoice Get(int id, bool @readonly = false)
        {
            return _service.Get(id, @readonly);
        }

        public IEnumerable<Invoice> All(bool @readonly = false)
        {
            return _service.All(@readonly);
        }

        public IEnumerable<Invoice> Find(Expression<Func<Invoice, bool>> predicate, bool @readonly = false)
        {
            return _service.Find(predicate, @readonly);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
