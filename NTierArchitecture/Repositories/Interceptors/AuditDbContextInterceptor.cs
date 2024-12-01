namespace Repositories.Interceptors
{
    public class AuditDbContextInterceptor : SaveChangesInterceptor
    {
        private static readonly Dictionary<EntityState, Action<DbContext, IAuditEntity>> Behaviors = new()
        {
            { EntityState.Added, AddBehavior },
            { EntityState.Modified, ModifiedBehavior }
        };

        public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
        {
            foreach (var entityEntry in eventData.Context!.ChangeTracker.Entries().ToList())
            {
                if (entityEntry.Entity is not IAuditEntity auditEntity)
                    continue;

                Behaviors[entityEntry.State](eventData.Context, auditEntity);

                #region 1.Way

                //switch (entityEntry.State)
                //{
                //    case EntityState.Added:
                //        AddBehavior(eventData.Context, auditEntity);
                //        break;

                //    case EntityState.Modified:
                //        ModifiedBehavior(eventData.Context, auditEntity);
                //        break;
                //}

                #endregion
            }

            return base.SavingChangesAsync(eventData, result, cancellationToken);
        }

        private static void AddBehavior(DbContext context, IAuditEntity auditEntity)
        {
            auditEntity.Created = DateTime.Now;
            context.Entry(auditEntity).Property(x => x.Updated).IsModified = false;
        }

        private static void ModifiedBehavior(DbContext context, IAuditEntity auditEntity)
        {
            auditEntity.Updated = DateTime.Now;
            context.Entry(auditEntity).Property(x => x.Created).IsModified = false;
        }
    }
}
