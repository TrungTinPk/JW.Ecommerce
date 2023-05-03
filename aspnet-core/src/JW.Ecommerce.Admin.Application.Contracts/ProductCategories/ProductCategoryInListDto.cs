using System;
using System.Collections.Generic;
using System.Text;

namespace JW.Ecommerce.ProductCategories
{
    public class ProductCategoryInListDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int SortOrder { get; set; }
        public string CoverPicture { get; set; }
        public bool Visibility { get; set; }
        public bool IsActive { get; set; }
        public string SeoMetaDescription { get; set; }
    }
}
