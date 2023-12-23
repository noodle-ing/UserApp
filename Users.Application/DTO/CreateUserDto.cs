using System.Text.Json.Serialization;

namespace Users.Application.DTO;

public record CreateUserDto(
    [property: JsonPropertyName("firstName")]string Name,
    [property: JsonPropertyName("lastName")]string LastName,
    [property: JsonPropertyName("age")]byte Age);