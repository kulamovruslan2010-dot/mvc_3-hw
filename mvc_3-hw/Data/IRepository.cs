using Microsoft.AspNetCore.Mvc;
using mvc_3_hw.Models;

namespace mvc_3_hw.Data
{
    public interface IRepository
    {
        List<Product> GetAll();
        Product? GetById(int id);
    }
}
