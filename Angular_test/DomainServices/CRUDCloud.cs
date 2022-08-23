using Angular_test.Models;
using System.Collections.Generic;

namespace Angular_test.DomainServices
{
    public class CRUDCloud : ICategoryCRUD
    {
        public Category Add(CategoryModel model)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return new List<Category>()
            {
                new Category
                {
                     Title = "Fake"

                }
            };
        }

        public Category GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Category Update(CategoryModel model)
        {
            throw new System.NotImplementedException();
        }
    }
}
