using Users.Domain.Core.Common;

namespace Users.Domain.Core.Entities;

public class User : BaseEntity
{
    public string Name { get; set; }
    public string SurName { get; set; }
    public byte Age { get; set; }
}