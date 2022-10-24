﻿using CoreDefault.jwt_core_proje_kampi.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreDefault.jwt_core_proje_kampi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("action")]
        public IActionResult Login()
        {
            return Created("", new BuildToken().CreateToken());
        }

        [Authorize]
        [HttpGet]
        public IActionResult Page1()
        {
            return Ok("Sayfa 1 için girişiniz başarılı");
        }
    }
}
