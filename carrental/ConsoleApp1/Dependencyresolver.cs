using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using Autofac;
using Autofac.Builder;
using Autofac.Core.Activators.Reflection;
using ConsoleApp1.Gallery;
using ConsoleApp1.Gallery.Interfaces;

namespace ConsoleApp1
{
    public static class Dependencyresolver
    {
        public static TObj Resolve<TObj>()
        {
            /*ContainerBuilder containerbuilder = new Autofac.ContainerBuilder();

            containerbuilder.RegisterType<Exif>().As<IExif>();


            Autofac.IContainer c = containerbuilder.Build();

            return c.Resolve<Tresult>(new  {Toresolve } );*/


            var builder = new ContainerBuilder();

            builder.RegisterType<Exif>().As<IExif>();
            builder.RegisterType<Video>().As<IVideo>();
            var container = builder.Build();


            return (TObj)(container.Resolve(typeof(TObj)));
        }
    }
}