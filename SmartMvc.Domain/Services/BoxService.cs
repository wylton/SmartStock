﻿using SmartMvc.Domain.Entities;
using SmartMvc.Domain.Interfaces.Repository;
using SmartMvc.Domain.Interfaces.Repository.ReadOnly;
using SmartMvc.Domain.Interfaces.Service;
using SmartMvc.Domain.Services.Common;

namespace SmartMvc.Domain.Services
{
    public class BoxService : Service<Box>, IBoxService
    {
        public BoxService(IBoxRepository repository, IBoxReadOnlyRepository readOnlyRepository)
            : base(repository, readOnlyRepository)
        {
        }
    }
}
