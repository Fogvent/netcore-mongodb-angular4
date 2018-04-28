using System.Collections.Generic;

namespace ViewModels
{
    public class CategoriesList
    {
        public int Total { get; set; }
        public ICollection<Category> Items { get; set; }
    }
}
