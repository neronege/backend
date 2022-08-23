using Angular_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Angular_test.DomainServices //Controllerda yazmazdan önce burada işlemleri gerçekelştiriyoruz
{                                     //interface class'ında tanımladığımız ICategoryCRUD'u CategoryCRUD'da çağrıyoruz
    public class CategoryCRUD : ICategoryCRUD
    {
        private readonly AppDbContext context;  //AppDbContext veri tabınında okuyup, değişken olarak context'i tanımlıyoruz

        public CategoryCRUD(AppDbContext context) 
        {
            this.context = context;
        }

        public Category Add(CategoryModel model)     // public Category class'ında
        {                                            //ICategory class' içerisindekini çağrıyoruz, 
            var category = new Category              // category ve model içerisinde bulunanları tanımlıyoruz
            {
                Title = model.Title,                  
                Description = model.Description,
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now
            };
            context.Categories.Add(category);      //database'e göndereceklerimizi yazıyoruz
            context.SaveChanges();                 // kaydediyoruz
            return category;                       // ve category'ü döndürüyourz
        }

        public void Delete(int id)
        {
            var category = GetById(id);             // id'yi çağrıp, değişkeni tanımlıyoruz
            context.Categories.Remove(category);    // database içeriside contex.Categories ile ulaşıp category'i siliyoruz
            context.SaveChanges();                  // kaydediyoruz   
        }

        public List<Category> GetAll()
        {
            return context.Categories.ToList();     //Get için db içerisine ulaşıp ToList diyoruz
        }

        public Category GetById(int id)
        {
            return context.Categories.Find(id);      //Id çekmek için Find(id) diyoruz
        }

        public Category Update(CategoryModel model)
        {
            var category = context.Categories.Find(model.Id);           //Find(model.Id) diyerek object ulaşıyoruz
            category.Title = model.Title;                               //Add'deki tanımlama yaparak yazıyoruz
            category.Description = model.Description;                   
            category.ModifiedOn = DateTime.Now;
            context.Categories.Update(category);                          //Update ile gönderiyoruz
            context.SaveChanges();                                        //kaydediyoruz
            return category;
        }
    }
}
