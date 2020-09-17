namespace WebAPIDependencyInjection.Model
{
    using System.Collections.Generic;
    public class Repository : IRepository
    {
        public IEnumerable<string> Values { get; set; }

        /// <summary>
        ///     Constructor of Repository class
        /// </summary>
        public Repository()
        {
            Values = new List<string> { "Value1", "Value2", "Value3", "Value4" };
        }
    }
}