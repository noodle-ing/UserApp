using Users.Application.DTO;
using Users.Application.Mapping;
using Users.Application.Responses;
using Users.Infrastructure.Data;

namespace Users.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _repository;

    public UserService(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<BaseApiResponse<IEnumerable<UserDto>>> GetAllAsync()
    {
        var users = await _repository.GetAsync();
        var usersDtos = users.Select(u => u.ToUserDto());
        return new BaseApiResponse<IEnumerable<UserDto>>(usersDtos, "Complited");
    }

    public async Task<BaseApiResponse<UserDto>> GetAsync(long id)
    {
        var user = await _repository.GetUserAsync(id);
        return new BaseApiResponse<UserDto>(user.ToUserDto());
    }

    public async Task<BaseApiResponse<long>> CreateAsync(CreateUserDto dto)
    {
        var resultId = await _repository.CreateUserAsync(dto.ToUser());
        return new BaseApiResponse<long>(resultId, "Created");
    }

    public async Task<BaseApiResponse<UserDto>> UpdateAsync(UpdateUserDto dto)
    {
        var user = await _repository.UpdateUserAsync(dto.ToUser());
        return new BaseApiResponse<UserDto>(user.ToUserDto());
    }

    public async Task<BaseApiResponse<bool>> DeleteAsync(long id)
    {
        var result = await _repository.DeleteAsync(id);
        var message = result ? "Deleted successfully" : "Id is not found";
        return new BaseApiResponse<bool>(result, message);
    }
}