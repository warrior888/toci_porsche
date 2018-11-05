using System;
using System.Linq;
using System.Reflection;
using ConsoleApp1.Gallery.Interfaces;
using Newtonsoft.Json.Serialization;

namespace ConsoleApp1.Gallery
{
    public class Dummy
    {
        public void ReflectionIndependentInjection()
        {
            IVideo Holidays = Dependencyresolver.Resolve<IVideo>();//new Video(/*resolve*/ (IExif)(Dependencyresolver.Resolve<IExif>()));
            Type typ = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Name == "IExif").First().DeclaringType;
            //Activator.CreateInstance<IExif>();

        }
    }
}