﻿using Lab4_23.Data;
using Lab4_23.Models.DTOs;
using Lab4_23.Models.One_to_Many;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab4_23.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatabaseController : ControllerBase
    {
        private readonly Lab4Context _lab4Context;

        public DatabaseController(Lab4Context lab4Context)
        {
            _lab4Context = lab4Context;
        }

        [HttpGet("model1")]
        public async Task<IActionResult> GetModel1()
        {
            return Ok(await _lab4Context.Models1.ToListAsync());
        }

        [HttpPost("model1")]
        public async Task<IActionResult> Create (Model1DTO model1Dto)
        {
            var newModel1 = new Model1
            {
                Id = Guid.NewGuid(),
                Name = model1Dto.Name
            };

            await _lab4Context.AddAsync(newModel1);
            await _lab4Context.SaveChangesAsync();

            return Ok(newModel1);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Model1DTO model1Dto)
        {
            Model1 model1ById = await _lab4Context.Models1.FirstOrDefaultAsync(x => x.Id == model1Dto.Id);
            if (model1ById == null)
            {
                return BadRequest("Object does not exist");
            }

            model1ById.Name = model1Dto.Name;
            _lab4Context.Update(model1ById);
            await _lab4Context.SaveChangesAsync();
            
            return Ok(model1ById);
        }

        [HttpGet("model2")]
        public async Task<IActionResult> GetModel2()
        {
            return Ok(await _lab4Context.Models1.ToListAsync());
        }

        [HttpPost("model2")]
        public async Task<IActionResult> Create(Model2DTO model2Dto)
        {
            var newModel2 = new Model2
            {
                Id = Guid.NewGuid(),
                Name = model2Dto.Nume

            };

            await _lab4Context.AddAsync(newModel2);
            await _lab4Context.SaveChangesAsync();

            return Ok(newModel2);
        }

        [HttpPost("update2")]
        public async Task<IActionResult> Update(Model2DTO model2Dto)
        {
            Model2 model2ById = await _lab4Context.Models2.FirstOrDefaultAsync(x => x.Id == model2Dto.Id);
            if (model2ById == null)
            {
                return BadRequest("Object does not exist");
            }

            model2ById.Name = model2Dto.Nume;
            _lab4Context.Update(model2ById);
            await _lab4Context.SaveChangesAsync();

            return Ok(model2ById);
        }
    }
}
