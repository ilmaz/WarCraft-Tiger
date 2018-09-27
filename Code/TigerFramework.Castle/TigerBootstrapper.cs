﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using TigerFramework.Application;
using TigerFramework.Core;

namespace TigerFramework.Castle
{
    public static class TigerBootstrapper
    {
        public static void WireUp(IWindsorContainer container)
        {
            container.Register(Component.For<IServiceLocator>()
                .UsingFactoryMethod(a=> new WindsorServiceLocatorAdapter(container)));

            container.Register(Component.For<ICommandBus>()
                .ImplementedBy<CommandBus>());
        }
    }
}