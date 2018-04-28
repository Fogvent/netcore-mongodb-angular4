using System;

namespace ViewModels
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int TopicsCount { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
