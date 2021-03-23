using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsCore;
using NewsServices;

namespace NewsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private INewsService _newsService;
        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return await Task.FromResult(Ok(_newsService.GetNews()));
        }

        [HttpGet("{id}")]
        public async Task< ActionResult> Get(string id)
        {            
            return await Task.FromResult(Ok(_newsService.GetNews(id)));
        }
    }
}
