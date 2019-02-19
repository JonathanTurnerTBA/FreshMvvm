using System;
using System.Collections.Generic;

namespace FreshMvvm
{
    public interface IFreshIOC
    {
        object Resolve(Type resolveType);
        IRegisterOptions Register<RegisterType>(RegisterType instance) where RegisterType : class;
        IRegisterOptions Register<RegisterType>(RegisterType instance, string name) where RegisterType : class;
        ResolveType Resolve<ResolveType>() where ResolveType : class;
        ResolveType Resolve<ResolveType>(string name) where ResolveType : class;
        IEnumerable<ResolveType> ResolveAll<ResolveType>() where ResolveType : class;
        IRegisterOptions Register<RegisterType, RegisterImplementation> ()
            where RegisterType : class
            where RegisterImplementation : class, RegisterType;
        void Unregister<RegisterType>();
        void Unregister<RegisterType>(string name);
    }
}

