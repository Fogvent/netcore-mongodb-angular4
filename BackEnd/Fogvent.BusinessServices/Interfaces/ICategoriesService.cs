using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fogvent.BusinessServices.Interfaces
{
    public interface ICategoriesService
    {
        Task<ViewModels.CategoriesList> GetAsync(int pageIndex, int pageSize, string keyword = null);
        ICollection<ViewModels.Lookup> GetCategoriesLookup();
        ViewModels.CategoryDetails GetCategoryById(Guid id);
        ViewModels.Category Add(BindingModels.Category categoryBindingModel);
        bool Update(BindingModels.Category categoryBindingModel);
        bool Delete(Guid id);
    }
}
