
using ASyncApp.Controllers;
namespace ASyncApp.Factory
{
    public static class ControllerFactory
    {

        public static TaxController CreateInstance()
        {
            return new TaxController();
        }
    }

}
