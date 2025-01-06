namespace Repositories;

public interface IAuditEntity
{
    DateTime Created { get; set; }
    DateTime? Updated { get; set; }
}
