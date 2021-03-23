using NewsCore.Interceptors;
using NewsServices.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsServices
{
    public interface INewsService
    {
        List<NewsDto> GetNews();
        [Caching(100)]
        NewsDto GetNews(string id);
    }
}
