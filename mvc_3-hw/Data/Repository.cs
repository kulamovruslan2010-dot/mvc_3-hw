using Microsoft.AspNetCore.Mvc;
using mvc_3_hw.Models;

namespace mvc_3_hw.Data
{

    public class Repository : IRepository
    {
        private readonly List<Product> _products;

        public Product? GetById(int id) => _products.FirstOrDefault(p => p.Id == id);
        public Repository()
        {
            _products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Яблоки Гала",
                Category = "Фрукты",
                Price = 120,
                Description = "Сладкие сочные яблоки, 1 кг.",
                UrlPhoto = "https://picsum.photos/seed/apple/400/400"
            },
            new Product
            {
                Id = 2,
                Name = "Молоко 2,5%",
                Category = "Молочные продукты",
                Price = 85,
                Description = "Пастеризованное молоко, 1 литр.",
                UrlPhoto = "https://picsum.photos/seed/milk/400/400"
            },
            new Product
            {
                Id = 3,
                Name = "Хлеб Бородинский",
                Category = "Выпечка",
                Price = 45,
                Description = "Тёмный ржаной хлеб с кориандром.",
                UrlPhoto = "https://picsum.photos/seed/bread/400/400"
            },
            new Product
            {
                Id = 4,
                Name = "Кофе Арабика",
                Category = "Напитки",
                Price = 690,
                Description = "Зерновой кофе средней обжарки, 250 г.",
                UrlPhoto = "https://picsum.photos/seed/coffee/400/400"
            },
            new Product
            {
                Id = 5,
                Name = "Сыр Гауда",
                Category = "Молочные продукты",
                Price = 320,
                Description = "Полутвёрдый сыр, 300 г.",
                UrlPhoto = "https://picsum.photos/seed/cheese/400/400"
            },
            new Product
            {
                Id = 6,
                Name = "Бананы",
                Category = "Фрукты",
                Price = 95,
                Description = "Спелые бананы, 1 кг.",
                UrlPhoto = "https://picsum.photos/seed/banana/400/400"
            }
        };
        }

        public List<Product> GetAll() => _products;
    }
}
