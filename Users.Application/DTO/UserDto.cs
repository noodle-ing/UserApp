using System.Text.Json.Serialization;

namespace Users.Application.DTO;

public record UserDto(
    [property: JsonPropertyName("id")]long Id,
    [property: JsonPropertyName("firstName")]string Name,
    [property: JsonPropertyName("lastName")]string LastName,
    [property: JsonPropertyName("age")]byte Age);