using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;

namespace LabradorGH.PluginGrasshopper
{
    public class PluginLoader : GH_AssemblyPriority
    {
        public override GH_LoadingInstruction PriorityLoad()
        {
            Instances.ComponentServer.AddCategoryIcon("LabradorGH", ResourceLoader.LoadBitmap("PluginGrasshopper_16.png"));
            Instances.ComponentServer.AddCategorySymbolName("LabradorGH", 'P');
            return GH_LoadingInstruction.Proceed;
        }
    }
}