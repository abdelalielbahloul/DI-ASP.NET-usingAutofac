using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public static class ContainerConfig
    {
        public static IContainer Config()
        {
            var builder = new ContainerBuilder();

            return builder.Build();
        }
    }
}
