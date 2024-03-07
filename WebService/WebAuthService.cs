using NewsPaper.Models;
using NewsPaper.Utility;

namespace NewsPaper.WebService
{
    public class WebAuthService
    {
        private readonly WebBaseService _baseService;

        public WebAuthService(WebBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto?> AssignRoleAsync(RegistrationRequestDto registrationRequestDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = ApiType.POST,
                Data = registrationRequestDto,
                Url = $"{StaticDetails.AuthAPIBase}/api/auth/AssignRole"
            });
        }

        public async Task<ResponseDto?> LoginAsync(LoginRequestDto loginRequestDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = ApiType.POST,
                Data = loginRequestDto,
                Url = $"{StaticDetails.AuthAPIBase}/api/auth/login"
            }, withBearer: false);
        }

        public async Task<ResponseDto?> RegisterAsync(RegistrationRequestDto registrationRequestDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = ApiType.POST,
                Data = registrationRequestDto,
                Url = $"{StaticDetails.AuthAPIBase}/api/auth/register"
            }, withBearer: false);
        }
    }
}