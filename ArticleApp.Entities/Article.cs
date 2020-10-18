using System;
using ArticleApp.Core.Entities;

namespace ArticleApp.Entities
{
    public class Article : IEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime AddDate { get; set; }
    }
}
