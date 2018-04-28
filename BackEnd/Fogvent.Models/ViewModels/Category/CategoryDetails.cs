using System;
using System.Collections.Generic;

namespace ViewModels
{
    public class CategoryDetails
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int OrdersCount { get; set; }
        public ICollection<TopicsList> Topics { get; set; }
    }
}
