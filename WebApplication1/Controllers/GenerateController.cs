using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenerateController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GenerateController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("SeedDataBase")]
        public void SeedDataBase()
        {
            //_context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();
            _context.SaveChanges();
        }


        [HttpPost("PopulateUsers")]
        public void PopulateUsers()
        {
            _context.Database.EnsureCreated();

            _context.Users.AddRange(new UserModel[]
            {
                new UserModel()
                {
                    FirstName = "Paulina",
                    LastName = "Kunibert",
                    Login = "user",
                    Password = "user",
                    Email = "user@mail.com",
                    Phone = "01234567890"
                },
                new UserModel()
                {
                    FirstName = "Mihael",
                    LastName = "Niraj",
                    Login = "user",
                    Password = "user",
                    Email = "user@mail.com",
                    Phone = "01234567890"
                },
                new UserModel()
                {
                    FirstName = "Karl",
                    LastName = "Melia",
                    Login = "user",
                    Password = "user",
                    Email = "user@mail.com",
                    Phone = "01234567890"
                }
            });

            _context.SaveChanges();
        }

    }
}