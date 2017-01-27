using System;
using System.Linq;

namespace JosephGuadagno.Extensions.Assembly
{
    /// <summary>
    /// Extensions for the <see cref="System.Reflection.Assembly"/>
    /// </summary>
    public static class AssemblyExtensions
    {
        /// <summary>
        /// Returns an <see cref="Attribute"/> for a given assembly
        /// </summary>
        /// <typeparam name="T">The type of attribute to get</typeparam>
        /// <param name="assembly">The assembly to retrieve the attributes for</param>
        /// <returns></returns>
        public static T GetAssemblyAttribute<T>(this System.Reflection.Assembly assembly) where T : Attribute
        {
            object[] attributes = assembly.GetCustomAttributes(typeof(T), false);
            if (attributes.Length == 0)
                return null;
            return attributes.OfType<T>().SingleOrDefault();
        }
    }
}