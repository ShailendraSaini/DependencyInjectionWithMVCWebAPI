namespace WebAPIDependencyInjection.Model
{
    using System;
    using System.Collections.Generic;
    using System.Web.Http.Dependencies;
    using Unity;

    /// <summary>
    ///     UnityResolver class for resolving dependencies
    /// </summary>
    public class UnityResolver : IDependencyResolver
    {
        private readonly IUnityContainer _container;

        public UnityResolver(IUnityContainer container)
        {
            _container = container;
        }

        /// <summary>
        ///     GetService method
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns></returns>
        public object GetService(Type serviceType)
        {
            try
            {
                return _container.Resolve(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return null;
            }
        }

        /// <summary>
        ///     GetService method
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns></returns>
        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _container.ResolveAll(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return new List<object>();
            }
        }

        /// <summary>
        ///     BeginScope method
        /// </summary>
        /// <returns></returns>
        public IDependencyScope BeginScope()
        {
            var child = _container.CreateChildContainer();
            return new UnityResolver(child);
        }

        /// <summary>
        ///     Dispose method
        /// </summary>
        public void Dispose()
        {
            _container.Dispose();
        }
    }
}