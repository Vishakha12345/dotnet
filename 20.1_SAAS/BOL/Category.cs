using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Category
    {
        private int categoryId;
        private string title;

        public Category()
        {
            categoryId = 0;
            title = string.Empty;
        }
        public Category(int categoryId, string title)
        {
            this.categoryId = categoryId;
            this.title = title;
        }

        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public override string ToString()
        {
            return string.Format("CategoryID: {0}, Title: {1}",
                categoryId, title);
        }
    }
}
