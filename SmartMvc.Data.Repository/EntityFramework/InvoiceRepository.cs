﻿using SmartMvc.Data.Repository.EntityFramework.Common;
using SmartMvc.Domain.Entities;
using SmartMvc.Domain.Interfaces.Repository;

namespace SmartMvc.Data.Repository.EntityFramework
{
    public class InvoiceRepository : Repository<Invoice>, IInvoiceRepository
    {

    }
}
