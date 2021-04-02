﻿using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnivercitiesController : ControllerBase
    {
        IUnivercityService _univercityService;
        public UnivercitiesController(IUnivercityService univercityService)
        {
            _univercityService = univercityService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _univercityService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _univercityService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("add")]
        public IActionResult Add(Univercity univercity)
        {
            var result = _univercityService.Add(univercity);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("update")]
        public IActionResult Update(Univercity univercity)
        {
            var result = _univercityService.Update(univercity);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("delete")]
        public IActionResult Delete(Univercity univercity)
        {
            var result = _univercityService.Delete(univercity);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}