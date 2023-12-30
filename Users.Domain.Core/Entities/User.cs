using Users.Domain.Core.Common;

namespace Users.Domain.Core.Entities; // здесь будут хранится все сущности которые  должны быть в проекте

public class User : BaseEntity
{
    public string Name { get; set; }
    public string SurName { get; set; }
    public byte Age { get; set; }
}