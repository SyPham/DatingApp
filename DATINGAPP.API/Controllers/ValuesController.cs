using DATINGAPP.API.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace DATINGAPP.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]

    public class ValuesController : ControllerBase
    {
        public DataContext _context { get; }

        public ValuesController(DataContext context){
           _context = context;
        }
        [HttpGet("get")]
        public async Task<IActionResult> GetValues()
        {
            var values =await _context.Values.ToListAsync();
            return Ok(values);
        }

       
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id){
            var value =await _context.Values.FindAsync(id);
            return Ok(value);
        }
    }
}