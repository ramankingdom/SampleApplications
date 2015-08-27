using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Interactivity;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Prism.Regions;
using System.Windows.Input;
namespace PropertiesModule.ViewModels
{
    public class TextPropertyViewModel : ITextPropertyViewModel
    {
        public readonly ICommand showTextPropertiesViewCommand;
        public TextPropertyViewModel(IRegionManager regMan,IEventAggregator eventAggregator)
        {
            this.showTextPropertiesViewCommand = new DelegateCommand(this.ShowTextProeprties);
        }
        public ICommand ShowTextPropertiesCommand
        {
            get { return this.showTextPropertiesViewCommand; }
        }
        public void ShowTextProeprties()
        { 
        }
    }
}