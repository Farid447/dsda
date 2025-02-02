﻿using Blog.BL.DTOs.CategoryDtos;
using Blog.BL.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController(ICategoryService _service) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //await _service.GetAllAsync()
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            return Ok();
        }
    }
}
