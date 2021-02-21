using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    interface ICategoryService
    {
        //Category ile ilgili dış dünyaya neyi servis etmek istiyorsak buraya yazarız.
        List<Category> GetAll();//Tümünü getir
        Category GetByid(int categoryId); //Kategori id ye göre getir.
    }
}
