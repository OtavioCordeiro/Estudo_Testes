using Autofac;
using Estudo_Component.Repositories;
using Estudo_Component.Repositories.Interfaces;
using Estudo_Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estudo_Api.Modules
{
    public class RepositoriesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StringsRepository>().Named<IRepository>("DataRepository");
            builder.Register(c => new Repository(c.ResolveNamed<IRepository>("DataRepository"))).Named<IRepository>("Repository");
        }
    }
}