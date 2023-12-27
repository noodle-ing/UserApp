namespace Users.Domain.Core.Common;

public class BaseEntity : IBaseEntity ,ICreatedAt
{
    public DateTime CreatedAt { get; set; }
    public long Id { get; set; }
}