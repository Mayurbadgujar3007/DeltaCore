using DeltaWare1.Models;
namespace DeltaWare1.Service
{
    public class ProductService
    {
            public List<DeltaWare> GetProducts()
            {
                List<DeltaWare> productList = new List<DeltaWare>
        {
            new DeltaWare 
            {
                ProductId = 1001,
                Name = "Tools Gears",
                Description = "Gear tools production specification"
            },
            new DeltaWare 
            {  
                ProductId = 2001,
                Name = "Panels",
                Description = "Switch Gear Panels" 
            },
            new DeltaWare
            {
                ProductId = 2008,
                Name = "DocTonar",
                Description = "Document Solar Objects"
            }
           
        };

                return productList;
            }
        }
    }

