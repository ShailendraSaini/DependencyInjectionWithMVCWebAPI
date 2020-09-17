namespace WebApiDepInject.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;
    using WebAPIDependencyInjection.Model;

    /// <summary>
    ///     Values Controller
    /// </summary>
    public class ValuesController : ApiController
    {
        private readonly IRepository _repo;

        public ValuesController(IRepository repo)
        {
            _repo = repo;
        }

        /// <summary>
        ///     GET api/values
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> Get()
        {
            return _repo.Values;
        }

        /// <summary>
        ///     GET api/values/5
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Get(int id)
        {
            var list = _repo.Values.ToList();

            if (id >= 0 && id < list.Count)
            {
                return list[id];
            }

            return "unknown";
        }
    }
}