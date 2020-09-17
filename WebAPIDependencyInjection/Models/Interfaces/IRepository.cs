namespace WebAPIDependencyInjection.Model
{
    using System.Collections.Generic;

    /// <summary>
    ///     Interface IRepository
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        ///     Gets or sets Values
        /// </summary>
        IEnumerable<string> Values { get; set; }
    }
}