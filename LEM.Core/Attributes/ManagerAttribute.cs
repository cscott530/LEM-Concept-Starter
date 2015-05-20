using System;

namespace LEM.Core.Attributes
{
    //custom attribute to denote an item that is a Manager, which is just a placeholder term for now.
    //for now anything with this should implement IManager
    //allows the Startup method to get called.
    [AttributeUsage(AttributeTargets.Class)]
    public class ManagerAttribute : Attribute
    {
    }
}
