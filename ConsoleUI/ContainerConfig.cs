using Autofac;
using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ConsoleUI
{
    public static class ContainerConfig
    {
        public static IContainer Config()
        {
            var builder = new ContainerBuilder();

            /***
             * here we associate each interface with her implementation class
             */
            builder.RegisterType<Application>().AsSelf().As<IApplication>();
            builder.RegisterType<BusinessLogic>().AsSelf().As<IBusinessLogic>();
            /***
             * here we want to get all classes and interfaces in the Namespace DemoLibrary.Utilities
             * and associate each class with its interface
             */
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DemoLibrary)))
                .Where(t => t.Namespace.Contains("Utilities"))
                .As(c => c.GetInterfaces().FirstOrDefault(i => i.Name == $"I{c.Name}"));

            return builder.Build();
        }
    }
}
