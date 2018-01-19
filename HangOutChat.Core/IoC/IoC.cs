using Ninject;
using System;

namespace HangOutChat.Core
{

    /// <summary>
    /// the IoC container for the application
    /// </summary>
    public static class IoC
    {
        /// <summary>
        /// the kernel for our ioc container
        /// </summary>
        public static IKernel Kernel { get; private set; } = new StandardKernel();

        /// <summary>
        /// set the ioc container binds all info required 
        /// </summary>
        public static void SetUp()
        {
            // Bind all required viewmodels
            BindViewModel();
        }

        /// <summary>
        /// Binds all singleton viewmodels
        /// </summary>
        private static void BindViewModel()
        {
            // bind single instance of application viewmodel
            Kernel.Bind<ApplicationViewModel>().ToConstant(new ApplicationViewModel());
        }


        /// <summary>
        /// Gets the service from the IoC
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }

    }
}
