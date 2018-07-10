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
    public class UserAppService : AppService<SmartContext>, IUserAppService
    {
        private readonly IUserService _service;

        public UserAppService(IUserService userService)
        {
            _service = userService;
        }

        public ValidationResult Create(User user)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Add(user));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public ValidationResult Update(User user)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Update(user));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public ValidationResult Remove(User user)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Delete(user));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public User Get(int id, bool @readonly = false)
        {
            return _service.Get(id, @readonly);
        }

        public IEnumerable<User> All(bool @readonly = false)
        {
            return _service.All(@readonly);
        }

        public IEnumerable<User> Find(Expression<Func<User, bool>> predicate, bool @readonly = false)
        {
            return _service.Find(predicate, @readonly);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
