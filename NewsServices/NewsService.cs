using NewsCore;
using NewsDAL;
using NewsServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using NewsCore.Interceptors;

namespace NewsServices
{
    public class NewsService: INewsService
    {
        private readonly IRepository<NewsDto> _newsRepository;
        public NewsService(IRepository<NewsDto> newsRepository)
        {
            _newsRepository = newsRepository;
        }

        public List<NewsDto> GetNews()
        {
            return _newsRepository.Get();
        }
        
        public NewsDto GetNews(string id)
        {
            return _newsRepository.Get().Where(w=>w.Id.Equals(id)).FirstOrDefault();
        }
    }
}
