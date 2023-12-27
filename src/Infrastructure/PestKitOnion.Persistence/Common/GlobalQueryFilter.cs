using Microsoft.EntityFrameworkCore;
using PestKitOnion.Domain.Entities;
using PestKitOnion.Domain.Entities.Common;

namespace PestKitOnion.Persistence.Common
{
    internal static class GlobalQueryFilter
    {
        public static void ApplyQuery<T>(ModelBuilder builder) where T : BaseEntity, new()
        {
            builder.Entity<T>().HasQueryFilter(x=>x.IsDeleted==false);
        }
        public static void AppQueryFilters(this ModelBuilder builder)
        {
            ApplyQuery<Tag>(builder);
            ApplyQuery<Department>(builder);
            ApplyQuery<Employee>(builder);
            ApplyQuery<Author>(builder);
            ApplyQuery<Employee>(builder);
            ApplyQuery<Blog>(builder);
        }
    }
}
