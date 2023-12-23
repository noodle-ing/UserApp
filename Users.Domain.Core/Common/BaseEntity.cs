namespace Users.Domain.Core.Common;

public class BaseEntity : IBaseEntity ,ICreatedAt
{
    public long Id { get; set; }
    public DateTime CreatedAt { get; set; }
}