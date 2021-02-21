using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();//Tümünü getir
        List<Product> GetAllByCategoryid(int id); //Kategori id ye göre getir.
        List<Product> GetByUnitPrice(decimal min, decimal max);//Min ve max değerlerini getir
    }
}
