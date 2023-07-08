
using Action;
using Application;
using Autofac;
using Interfaces;
using Mono.Cecil;



var loader = new Loader();
var container = loader.BuildContainer();
var app = container.Resolve<IApplication>();
await app.Run();


public class Loader 
{
    public IContainer BuildContainer()
    {
        var containerBuilder = new ContainerBuilder();
        containerBuilder.RegisterModule<ApplicationModule>();
        containerBuilder.RegisterModule<CalcActionModule>();

        LoadPlugins(containerBuilder);

        return containerBuilder.Build();
    }

    private void LoadPlugins(ContainerBuilder containerBuilder)
    {
        var dir = new FileInfo(GetType().Assembly.Location).Directory;
        var dlls = dir.GetFiles("*.dll");
        var asms = AppDomain.CurrentDomain.GetAssemblies();

        foreach (var dll in dlls.Where(x => IsSuitable(x.FullName)))
        {
            var defaultContext = System.Runtime.Loader.AssemblyLoadContext.Default;
            var loader = asms.FirstOrDefault(x => x.Location.ToLowerInvariant() == dll.FullName.ToLowerInvariant());
            if (loader == null)
            {
                loader = defaultContext.LoadFromAssemblyPath(dll.FullName);
            }
            containerBuilder.RegisterAssemblyModules(loader);
        }
    }

    private bool IsSuitable(string fullName)
    {
        var type = typeof(CalcPlugin);
        var asm = AssemblyDefinition.ReadAssembly(fullName);

        return asm.CustomAttributes.Any(attribute => attribute.AttributeType.Name == type.Name && attribute.AttributeType.Namespace == type.Namespace);
    }
}

