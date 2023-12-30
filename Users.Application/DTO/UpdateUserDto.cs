using System.Text.Json.Serialization;

namespace Users.Application.DTO;

public record UpdateUserDto(
    [property: JsonPropertyName("id")]long Id,
    [property: JsonPropertyName("firstName")]string FirsName,
    [property: JsonPropertyName("lastName")]string LastName,
    [property: JsonPropertyName("age")]byte Age);