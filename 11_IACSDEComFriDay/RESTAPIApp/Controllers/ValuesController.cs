using System.Collections.Generic;
using System.Web.Http;

namespace RESTAPIApp.Controllers
{
    public class ValuesController : ApiController
    {
        List<string> flowers = new List<string>();
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "Rose", "Lotus", "Gerbera", "Carnation" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            string flower = "Gerbera";

            switch (id)
            {
                case 1:
                    flower = "Rose";
                    break;
                case 2:
                    flower = "Lotus";
                    break;
                case 3:
                    flower = "Jasmine";
                    break;
                case 4:
                  flower = "Carnation";
                    break;
               }
            return flower;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            this.flowers.Add(value);

        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
