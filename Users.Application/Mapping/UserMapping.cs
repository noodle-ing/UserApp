using Users.Application.DTO;
using Users.Domain.Core.Entities;

namespace Users.Application.Mapping;

public static class UserMapping
{
    public static UserDto? ToUserDto(this User? user)
    {
        return user == null ? null : new UserDto(user.Id, user.Name, user.SurName, user.Age);
    }
    
    public static User? ToUser(this CreateUserDto? user)
    {
        return user == null ? null : new User
        {
            Name = user.FirsName,
            SurName = user.LastName,
            Age = user.Age,
            CreatedAt = DateTime.Now
        };
    }
    
    public static User? ToUser(this UpdateUserDto? user)
    {
        return user == null ? null : new User
        {
            Id = user.Id,
            Name = user.FirsName,
            SurName = user.LastName,
            Age = user.Age,
            CreatedAt = DateTime.Now
        };
    }
}