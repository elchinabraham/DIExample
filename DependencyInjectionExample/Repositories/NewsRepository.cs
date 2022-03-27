using DependencyInjectionExample.Database;
using DependencyInjectionExample.Models;
using System.Collections.Generic;

namespace DependencyInjectionExample.Repositories
{
    public class NewsRepository : INewsRepository
    {
        IOperation _operation;
        public NewsRepository(IOperation operation)
        {
            _operation = operation;
        }

        public List<News> GetAllNews()
        {
            return new List<News>
            {
                new News { Id = 1, Name = "BBC" },
                new News { Id = 2, Name = "CNN" },
                new News { Id = 3, Name = "Euronews" },
                new News { Id = 4, Name = "Goal" },
            };
        }

        public News GetNews()
        {
            return new News { Id = 3, Name = "Elcin" };
        }
    }
}
