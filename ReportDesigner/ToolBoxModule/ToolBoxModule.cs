using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using ToolBoxModule.Views;
namespace ToolBoxModule
{
   public class ToolBoxModule:IModule
    {
        private readonly IRegionManager regionManager;
        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("ToolBarRegion",  typeof(ToolBoxView));
        }
        public ToolBoxModule(RegionManager regMan)
        {
            regionManager = regMan;
        }
    }
}
