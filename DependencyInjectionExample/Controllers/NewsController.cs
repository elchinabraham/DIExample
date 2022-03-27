using DependencyInjectionExample.Models;
using DependencyInjectionExample.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DependencyInjectionExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        readonly INewsRepository _newsRepository;
        public NewsController(INewsRepository newsRepository)
        {
            _newsRepository = newsRepository;
        }

        [HttpGet]
        public List<News> Get()
        {
            return _newsRepository.GetAllNews();
        }

        [HttpGet("{id}")]
        public News Get(int id)
        {
            // this is testing
            return _newsRepository.GetNews();
        }
    }
}
