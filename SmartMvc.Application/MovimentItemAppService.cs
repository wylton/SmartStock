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
    public class MovimentItemAppService : AppService<SmartContext>, IMovimentItemAppService
    {
        private readonly IMovimentItemService _service;

        public MovimentItemAppService(IMovimentItemService movimentItemService)
        {
            _service = movimentItemService;
        }

        public ValidationResult Create(MovimentItem movimentItem)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Add(movimentItem));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public ValidationResult Update(MovimentItem movimentItem)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Update(movimentItem));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public ValidationResult Remove(MovimentItem movimentItem)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Delete(movimentItem));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public MovimentItem Get(int id, bool @readonly = false)
        {
            return _service.Get(id, @readonly);
        }

        public IEnumerable<MovimentItem> All(bool @readonly = false)
        {
            return _service.All(@readonly);
        }

        public IEnumerable<MovimentItem> Find(Expression<Func<MovimentItem, bool>> predicate, bool @readonly = false)
        {
            return _service.Find(predicate, @readonly);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
