using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace NewsDAL
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<News> News { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>().HasData(LoadTestNews());
        }

        public List<News> LoadTestNews()
        {
            var newsList = new List<News>();
            using (StreamReader r = new StreamReader(@"case_study.data.json"))
            {
                string json = r.ReadToEnd();
                newsList = JsonConvert.DeserializeObject<List<News>>(json);
            }
            return newsList;
        }
    }
}
