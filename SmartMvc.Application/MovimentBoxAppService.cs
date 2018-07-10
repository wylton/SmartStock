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
    public class MovimentBoxAppService : AppService<SmartContext>, IMovimentBoxAppService
    {
        private readonly IMovimentBoxService _service;

        public MovimentBoxAppService(IMovimentBoxService boxService)
        {
            _service = boxService;
        }

        public ValidationResult Create(MovimentBox box)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Add(box));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public ValidationResult Update(MovimentBox box)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Update(box));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public ValidationResult Remove(MovimentBox box)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Delete(box));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public MovimentBox Get(int id, bool @readonly = false)
        {
            return _service.Get(id, @readonly);
        }

        public IEnumerable<MovimentBox> All(bool @readonly = false)
        {
            return _service.All(@readonly);
        }

        public IEnumerable<MovimentBox> Find(Expression<Func<MovimentBox, bool>> predicate, bool @readonly = false)
        {
            return _service.Find(predicate, @readonly);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
