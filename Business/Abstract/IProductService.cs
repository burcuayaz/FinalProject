using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();//Tümünü getir, liste döndürür
        IDataResult<List<Product>> GetAllByCategoryid(int id); //Kategori id ye göre getir.liste döndürür
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);//Min ve max değerlerini getir.liste döndürür
        List<ProductDetailDTO> GetProductDetails();//liste döndürür
        IDataResult<Product> GetById(int productId); //Sisteme girdiğimiz id'ye göre bize product döndürüyor.ürün döndürür

        IResult Add(Product product);//ekleme işlemi yapar geriye IResult sonucunu döndürür.
    }
}
