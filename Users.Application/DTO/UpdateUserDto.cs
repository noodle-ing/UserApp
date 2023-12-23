using System.Text.Json.Serialization;

namespace Users.Application.DTO;

public record UpdateUserDto(
    [property: JsonPropertyName("Id")]long Id,
    [property: JsonPropertyName("firstName")]string Name,
    [property: JsonPropertyName("lastName")]string LastName,
    [property: JsonPropertyName("age")]byte Age);