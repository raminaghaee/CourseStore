using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.DAL.Frameworke;
public class AddAuditFieldInterceptor :SaveChangesInterceptor
{
    public override int SavedChanges(SaveChangesCompletedEventData eventData, int result)
    {
        SetShadowProperties(eventData);
        return base.SavedChanges(eventData, result);
    }

    public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
    {
        SetShadowProperties(eventData);
        return base.SavingChangesAsync(eventData, result, cancellationToken);
    }

    private static void SetShadowProperties(DbContextEventData eventData)
    {
        var changeTraker = eventData.Context.ChangeTracker;

        var addedEntities = changeTraker.Entries().Where(c=>
                c.State==Microsoft.EntityFrameworkCore.EntityState.Added).ToList();

        var modifiedEntities = changeTraker.Entries().Where(c=>
                c.State==Microsoft.EntityFrameworkCore.EntityState.Modified).ToList();
        
        DateTime now = DateTime.Now;
        foreach (var item in addedEntities)
        {
            item.Property("CreateBy").CurrentValue = "Ramin";
            item.Property("UpdateBy").CurrentValue = "Alireza";
            item.Property("CreateDate").CurrentValue = now;
            item.Property("UpdateDate").CurrentValue = now;
        }
        foreach (var item in modifiedEntities)
        {
            item.Property("UpdateBy").CurrentValue = "Alireza";
            item.Property("UpdateDate").CurrentValue = now;
        }
    }
}

