using Fogvent.BusinessServices.Interfaces;
using Fogvent.Data.Common.Sql;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fogvent.BusinessServices.Implementations
{
    public class CategoriesService : ICategoriesService
    {
        #region Private Fields
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        #region Constructor
        public CategoriesService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region Interface Implementation
        public async Task<ViewModels.CategoriesList> GetAsync(int pageIndex, int pageSize, string keyword = null)
        {
            var predicate = BuildSearchFilter(keyword);

            var items = await _unitOfWork.RepositoryFor<Entities.Category>().GetAsync(category => new ViewModels.Category
            {
                Id = category.Id,
                Name = category.Name,
                CreatedOn = category.CreatedOn,
                ModifiedOn = category.ModifiedOn,
                TopicsCount = category.Topics.Count
            }, predicate, c => c.OrderBy(o => o.Id), null, pageIndex, pageSize);
            var total = _unitOfWork.RepositoryFor<Entities.Category>().Get().Count();

            return new ViewModels.CategoriesList { Items = items, Total = total };
        }
        public ICollection<ViewModels.Lookup> GetCategoriesLookup()
        {
            var items = _unitOfWork.RepositoryFor<Entities.Category>().Get().Select(category => new ViewModels.Lookup
            { Id = category.Id, Name = category.Name }).ToList();

            return items;
        }
        public ViewModels.Category Add(BindingModels.Category categoryBindingModel)
        {
            if (categoryBindingModel == null) throw new ArgumentNullException(nameof(categoryBindingModel));

            var categoryEntity = AutoMapper.Mapper.Map<Entities.Category>(categoryBindingModel);
            var addedCategory = _unitOfWork.RepositoryFor<Entities.Category>().Insert(categoryEntity);
            _unitOfWork.SaveChanges();

            return AutoMapper.Mapper.Map<ViewModels.Category>(addedCategory);
        }

        public bool Delete(Guid id)
        {
            if (Guid.Empty == id) throw new ArgumentNullException(nameof(id));

            bool result = _unitOfWork.RepositoryFor<Entities.Category>().Delete(id);
            if (result) _unitOfWork.SaveChanges();

            return result;
        }



        

        public ViewModels.CategoryDetails GetCategoryById(Guid id)
        {
            var includedProperties = new List<Expression<Func<Entities.Category, object>>>() { c => c.Topics };
            var categoryEntity = _unitOfWork.RepositoryFor<Entities.Category>().Get(filter: c => c.Id == id, includedProperties: includedProperties).FirstOrDefault();

            if (categoryEntity == null) return null;

            return AutoMapper.Mapper.Map<ViewModels.CategoryDetails>(categoryEntity);
        }

        public bool Update(BindingModels.Category categoryBindingModel)
        {
            if (categoryBindingModel == null) throw new ArgumentNullException(nameof(categoryBindingModel));

            var categoryEntity = AutoMapper.Mapper.Map<Entities.Category>(categoryBindingModel);
            bool result = _unitOfWork.RepositoryFor<Entities.Category>().Update(categoryEntity);

            if (result) _unitOfWork.SaveChanges();

            return result;
        }
        #endregion

        #region Private Methods
        private ExpressionStarter<Entities.Category> BuildSearchFilter(string keyword)
        {
            var predicate = PredicateBuilder.True<Entities.Category>();

            if (!string.IsNullOrEmpty(keyword))
                predicate = predicate.And(c => c.Name.ToLower().Contains(keyword.ToLower()));

            return predicate;
        }
        #endregion
    }
}
