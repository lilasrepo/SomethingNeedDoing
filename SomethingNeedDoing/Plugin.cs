using System;
using Dalamud.Plugin;
using ECommons;
using ECommons.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace SomethingNeedDoing;

// porting-note(api13): upstream 6122cec2 moved the entry point to IAsyncDalamudPlugin
// (LoadAsync + DisposeAsync), which is API15-only -- api13's IDalamudPlugin is just
// IDisposable (Cecil-verified). This file is therefore TC-owned and hand-written, exactly
// like Questionable's QuestionablePlugin.cs: an explicit constructor instead of AutoCtor's
// generated one, the load performed inline, and a synchronous Dispose. The generic Host and
// the Injectio-generated AddSomethingNeedDoing() registration are upstream's and are kept
// verbatim -- only the plugin-lifecycle shell differs.
//
// Consequence, accepted deliberately: upstream additions to the ConfigureServices block do
// not arrive on their own, so diff this method against upstream on every refresh.
public partial class Plugin : IDalamudPlugin
{
    public string Name => Svc.PluginInterface.InternalName;
    internal string Prefix => "SND";

    internal static Plugin P { get; private set; } = null!;
    internal static Config C { get; private set; } = null!;
    internal string Version => Svc.PluginInterface.Manifest.AssemblyVersion.ToString(2);

    private readonly IDalamudPluginInterface _pluginInterface;
    private readonly IHost _host;

    public Plugin(IDalamudPluginInterface pluginInterface)
    {
        _pluginInterface = pluginInterface;
        P = this;
        ECommonsMain.Init(_pluginInterface, this, Module.ObjectFunctions, Module.DalamudReflector);

        EzConfig.DefaultSerializationFactory = new ConfigFactory();
        C = EzConfig.Init<Config>();
        Config.Migrate(C);

        _host = new HostBuilder()
            .UseContentRoot(_pluginInterface.AssemblyLocation.Directory!.FullName)
            .ConfigureServices(services =>
            {
                services.AddSingleton(C);
                services.AddHostedService(sp => sp.GetRequiredService<Config>());
                services.AddSomethingNeedDoing();
            })
            .Build();

        _host.StartAsync().GetAwaiter().GetResult();
    }

    public void Dispose()
    {
        try
        {
            _host.StopAsync().GetAwaiter().GetResult();
        }
        finally
        {
            _host.Dispose();
            ECommonsMain.Dispose();
        }
    }
}
