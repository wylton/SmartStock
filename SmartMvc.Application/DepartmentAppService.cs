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
    public class DepartmentAppService : AppService<SmartContext>, IDepartmentAppService
    {
        private readonly IDepartmentService _service;

        public DepartmentAppService(IDepartmentService boxService)
        {
            _service = boxService;
        }

        public ValidationResult Create(Department box)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Add(box));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public ValidationResult Update(Department box)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Update(box));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public ValidationResult Remove(Department box)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Delete(box));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public Department Get(int id, bool @readonly = false)
        {
            return _service.Get(id, @readonly);
        }

        public IEnumerable<Department> All(bool @readonly = false)
        {
            return _service.All(@readonly);
        }

        public IEnumerable<Department> Find(Expression<Func<Department, bool>> predicate, bool @readonly = false)
        {
            return _service.Find(predicate, @readonly);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
