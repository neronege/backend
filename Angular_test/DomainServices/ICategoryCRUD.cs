using Angular_test.Models;
using System.Collections.Generic;

namespace Angular_test.DomainServices
{
    public interface ICategoryCRUD        //interface class'ı tanımlıyoruz
    {
        Category Add(CategoryModel model);     //Category yazarak içerisindeki tanımları yazıyoruz
                                               //post,ekleme işlemi için Add kullanıyoruz CategoryModel model ile çekiyoruz
        Category Update(CategoryModel model);// Put işlemi için Update kullanıyoruz
        void Delete(int id);
         
        Category GetById(int id); //Tek object çekmek için GetById kullanıyoruz

        List<Category> GetAll(); //Get işlem yapmak için, list içerisine category yazıyoruz ve getall diyoruz
    }
}
