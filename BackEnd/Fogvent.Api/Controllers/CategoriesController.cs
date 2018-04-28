using System;
using System.Threading.Tasks;
using Fogvent.BusinessServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Fogvent.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Categories")]
    public class CategoriesController : Controller
    {
        #region Fields
        private readonly ICategoriesService _categoriesService;
        #endregion

        #region Contracture
        public CategoriesController(ICategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
        }
        #endregion

        #region GET Actions
        [HttpGet, Route("Lookup")]
        public ActionResult Get()
        {
            var result = _categoriesService.GetCategoriesLookup();
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult> Get(int pageNumber, int pageSize, string keyword = null)
        {
            var result = await _categoriesService.GetAsync(--pageNumber, pageSize, keyword);
            return Ok(result);
        }

        [HttpGet(), Route("{id}")]
        public ActionResult Get(Guid id)
        {
            var result = _categoriesService.GetCategoryById(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        #endregion

        #region POST Actions
        [HttpPost]
        public ActionResult Post([FromBody] BindingModels.Category categoryBindingModel)
        {
            var result = _categoriesService.Add(categoryBindingModel);
            return Ok(result);
        }
        #endregion

        #region PUT Actions
        [HttpPut, Route("{id}")]
        public ActionResult Put([FromQuery]Guid id, [FromBody] BindingModels.Category categoryBindingModel)
        {
            if (id != categoryBindingModel.Id) return BadRequest("Category ID is not same.");

            bool result = _categoriesService.Update(categoryBindingModel);

            if (result) return Ok();
            return NotFound();
        }
        #endregion

        #region DELETE Actions
        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(Guid id)
        {
            bool result = _categoriesService.Delete(id);

            if (result) return Ok();
            return NotFound();
        }
        #endregion
    }
}