using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using RibbonBarModule.Views;
namespace RibbonBarModule
{
    public class RibbonBarModule:IModule
    {
        private readonly IRegionManager regionManager;
        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("RibbonRegion", typeof(RibbonBarView));
        }
        public RibbonBarModule(IRegionManager regMan)
        {
            regionManager = regMan;
        }
    }
}
