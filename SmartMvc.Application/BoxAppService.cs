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
    public class BoxAppService : AppService<SmartContext>, IBoxAppService
    {
        private readonly IBoxService _service;

        public BoxAppService(IBoxService boxService)
        {
            _service = boxService;
        }

        public ValidationResult Create(Box box)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Add(box));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public ValidationResult Update(Box box)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Update(box));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public ValidationResult Remove(Box box)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Delete(box));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public Box Get(int id, bool @readonly = false)
        {
            return _service.Get(id, @readonly);
        }

        public IEnumerable<Box> All(bool @readonly = false)
        {
            return _service.All(@readonly);
        }

        public IEnumerable<Box> Find(Expression<Func<Box, bool>> predicate, bool @readonly = false)
        {
            return _service.Find(predicate, @readonly);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
