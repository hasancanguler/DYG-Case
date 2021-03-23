using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NewsDAL
{
    public class JSONRepository<T> : IRepository<T>
    {
        private List<T> LoadTestNews()
        {
            var returnList = new List<T>();
            using (StreamReader r = new StreamReader(@"case_study.data.json"))
            {
                string json = r.ReadToEnd();
                returnList = JsonConvert.DeserializeObject<List<T>>(json);
            }
            return returnList;
        }

        public List<T> Get()
        {
            return LoadTestNews();
        }
    }
}
