using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BreweryBucketListWIP.Models;
using System.Web.ModelBinding;

namespace BreweryBucketListWIP
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // added code to populate the ListView control with Product Data from the database
        // code supports products by individual category, as well as showing all products 
        public IQueryable<Product> GetProducts([QueryString("id")] int? categoryId)
        {
            var db = new BreweryBucketListWIP.Models.ProductContext();
            IQueryable<Product> query = db.Products;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }

            return query;
        }
    }
}