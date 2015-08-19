using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
namespace PropertiesModule
{
  public class PropertiesModule:IModule
    {
      private IRegionManager regionManager;
      private IUnityContainer container;
      public void Initialize()
        {

        }
      public PropertiesModule(UnityContainer cont, RegionManager regMan)
      {
          regionManager = regMan;
          container = cont;
      }
    }
}
