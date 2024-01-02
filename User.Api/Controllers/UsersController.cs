using Microsoft.AspNetCore.Mvc;
using Users.Application.DTO;
using Users.Application.Services;

namespace User.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{

    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _userService.GetAllAsync();
        return Ok(result);
    }

    // [HttpGet("{id:long}")]
    // public async Task<IActionResult> Get([FromRoute] long id)
    // {
    //     var result = await _userService.GetAsync(id);
    //     return Ok();
    // }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody]CreateUserDto dto)
    {
        var result = await _userService.CreateAsync(dto);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateUserDto dto)
    {
        var result = await _userService.UpdateAsync(dto);
        return Ok(result);
    }
    
    [HttpDelete("{id:long}")]
    public async Task<IActionResult> Delete([FromBody] long id)
    {
        var result = await _userService.DeleteAsync(id);
        return Ok(result);
    }
    

}