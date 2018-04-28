using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fogvent.BusinessServices.Interfaces
{
    public interface ICategoriesService
    {
        Task<ViewModels.CategoriesList> Get(int pageIndex, int pageSize, string keyword = null);
        ICollection<ViewModels.Lookup> GetCategoriesLookup();
        ViewModels.CategoryDetails GetCategoryById(Guid id);
        //ViewModels.Customer Add(BindingModels.Customer customerBindingModel);
        //bool Update(BindingModels.Customer customerBindingModel);
        bool Delete(Guid id);
    }
}
