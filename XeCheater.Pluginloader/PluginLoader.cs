using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using XeCheater.Interfaces;
using XeCheater.Shared;

namespace XeCheater {
    public class PluginLoader {
        public IList<IPlugin> plugins = new List<IPlugin>();

        public async Task LoadPlugins(string folder)
        {
            await Task.Run(() => {
                if (!Directory.Exists(Constants.PluginFolder)) {
                    Directory.CreateDirectory(Constants.PluginFolder);
                }

                foreach (string plugin in Directory.GetFiles(Constants.PluginFolder, "*.dll"))
                {
                    Assembly asm = Assembly.LoadFrom(plugin);

                    foreach (Type type in asm.GetExportedTypes())
                    {
                        if (type.GetInterfaces().Contains(typeof(IPlugin)))
                        {
                            if (Activator.CreateInstance(type) is IPlugin instance)
                            {
                                if (instance != null)
                                {
                                    plugins.Add(instance);
                                }
                            }
                        }
                    }
                }
            });
        }
    }
}
