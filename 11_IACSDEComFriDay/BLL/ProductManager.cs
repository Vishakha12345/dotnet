using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;
namespace BLL
{
    public static class ProductManager
    {


        public static List<Product> GetAll()
        {
            return ProductDAL.GetAll();
        }


        public static Product Get(int id)
        {
            return ProductDAL.GetById(id);
        }
    }
}
