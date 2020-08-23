using System.Reflection;
using AL;
using Castle.DynamicProxy;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using InterceptorProject;
using WComponent = Castle.MicroKernel.Registration.Component;

namespace Windsor
{
    public class Program
    {
        public static IWindsorContainer container = new WindsorContainer();
        static void Main(string[] args)
        {
            InitializeWindsor();

            var tester = new Tester(container.Resolve<IClass1Interface>());
            tester.InvokeClass1();
        }

        private static void InitializeWindsor()
        {

            container.Install(FromAssembly.This());

            container.Register(WComponent.For<IInterceptor>().ImplementedBy<ALInterceptor3>().LifestyleTransient(),
                    WComponent.For<IInterceptor>().ImplementedBy<ALInterceptor2>().LifestyleTransient(),

                Types.FromAssemblyNamed("AL").BasedOn<BaseClass>().WithServiceAllInterfaces()
                .Configure(f => f.Interceptors<ALInterceptor3>().LifestyleTransient()),
            Types.FromAssemblyNamed("AL").BasedOn<ServiceBase>().WithServiceAllInterfaces()
                .Configure(f => f.Interceptors<ALInterceptor2>().LifestyleTransient()),

                Classes.FromAssemblyNamed("AL").Pick().WithServiceAllInterfaces().LifestyleTransient()
                );
            //container.Register(Types.FromAssemblyNamed("AL").BasedOn<BaseClass>().WithServiceAllInterfaces()
            //    .Configure(f => f.Interceptors<ALInterceptor3>().LifestyleTransient()));
            //container.Register(Classes.FromAssemblyNamed("AL").Pick().WithServiceAllInterfaces().LifestyleTransient());


            //container.Register(WComponent.For<IInterceptor>().ImplementedBy<ALInterceptor3>().LifestyleTransient());
            //container.Register(Types.FromAssemblyNamed("AL").BasedOn<BaseClass>().WithServiceAllInterfaces()
            //    .Configure(f => f.Interceptors<ALInterceptor3>().LifestyleTransient()));
            //container.Register(Classes.FromAssemblyNamed("AL").Pick().WithServiceAllInterfaces().LifestyleTransient());

            //container.Register(WComponent.For<IClass1Interface>().ImplementedBy<Class1>().LifestyleTransient());
            //container.Register(WComponent.For<IClass2Interface>().ImplementedBy<Class2>().LifestyleTransient());
            //container.Register(WComponent.For<IClass3Interface>().ImplementedBy<Class3>().LifestyleTransient());
        }
    }
}
