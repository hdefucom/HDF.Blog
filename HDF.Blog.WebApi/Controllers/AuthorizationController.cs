using HDF.Blog.Model.ApiModel;
using HDF.Blog.Model.AppsettingModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HDF.Blog.WebApi.Controllers
{
    /// <summary>
    /// 身份验证控制器
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        private readonly TokenConfig _tokenConfig;
        private readonly ILogger<AuthorizationController> _logger;
        private readonly TokenConfig _config;

        public AuthorizationController(TokenConfig tokenConfig, ILogger<AuthorizationController> logger, TokenConfig config)
        {
            _tokenConfig = tokenConfig;
            _logger = logger;
            _config = config;
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<ApiResult<string>> UserLogin([FromForm] string userCode, [FromForm] string password)
        {
            if (userCode != "admin")
                return ApiResult.Fail<string>("该用户不存在！");

            if (password != "1")
                return ApiResult.Fail<string>("密码错误！");

            await Task.Delay(1);

            var claims = new Claim[]
            {
                new Claim("Id", "admin"),
                new Claim("UserCode", "admin"),
                new Claim("UserName", "管理员"),
                new Claim("UserRoles", ""),
                new Claim("UserType", "超级管理员"),
                new Claim(JwtRegisteredClaimNames.Nbf, new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds().ToString()),
                new Claim(JwtRegisteredClaimNames.Exp,new DateTimeOffset(DateTime.Now.AddMinutes(_tokenConfig.AccessExpiration)).ToUnixTimeSeconds().ToString()),
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.ASCII.GetBytes(_tokenConfig.Secret));

            var token = new JwtSecurityToken(
                issuer: _tokenConfig.Issuer,
                audience: _tokenConfig.Audience,
                claims: claims,
                notBefore: DateTime.Now,
                expires: DateTime.Now.AddMinutes(_tokenConfig.AccessExpiration),
                signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256));

            //生成Token
            string jwtToken = new JwtSecurityTokenHandler().WriteToken(token);

            _logger.LogInformation($"【登录用户-->Id:admin，Code:admin，Name:管理员】");

            return ApiResult.Success(jwtToken);
        }



        ///// <summary>
        ///// 获取用户信息（姓名，菜单）
        ///// </summary>
        ///// <returns></returns>
        //[HttpGet]
        //[Authorize]
        //public async Task<ApiResult<UserInfoModel>> GetUserInfo([FromServices] AccessToken token)
        //{
        //    var user = await _userServices.GetUserOrDefault(token.UserCode, true);

        //    if (user == default)
        //        return ApiResult.Fail<UserInfoModel>("登录用户无效！");

        //    var menus = user.UserRoles
        //        .SelectMany(ur => ur.Role.RoleMenus.Select(rm => rm.Menu))
        //        .GroupBy(m => m.Id, m => m, (k, v) => v.First())
        //        .ToList();

        //    return ApiResult.Success(new UserInfoModel { UserName = user.Name, Menus = menus });
        //}


        //[HttpPost]
        //[Authorize]
        //public async Task<ApiResult<bool>> UpdatePassWord(string oldPassWord, string newPassWord)
        //{
        //    bool res = await _userServices.UpdatePassWord(oldPassWord, newPassWord);
        //    return res ? ApiResult.Success(true) : ApiResult.Fail<bool>("修改失败！");
        //}





    }


}
