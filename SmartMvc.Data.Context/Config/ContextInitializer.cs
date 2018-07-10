using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SmartMvc.Domain.Entities;

namespace SmartMvc.Data.Context.Config
{
    public class ContextInitializer : DropCreateDatabaseIfModelChanges<SmartContext>
    {
        protected override void Seed(SmartContext context)
        {
            

            //context.SaveChanges();
        }
    }
}