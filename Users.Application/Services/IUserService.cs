using Users.Application.DTO;
using Users.Application.Responses;

namespace Users.Application.Services;

public interface IUserService
{
    Task<BaseApiResponse<IEnumerable<UserDto>>> GetAllAsync();
    Task<BaseApiResponse<UserDto>> GetAsync(long id);
    Task<BaseApiResponse<long>> CreateAsync(CreateUserDto dto);
    Task<BaseApiResponse<UserDto>> UpdateAsync(UpdateUserDto dto);
    Task<BaseApiResponse<bool>> DeleteAsync (long id);
}