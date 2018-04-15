using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentsGui.ViewModel
{
    class SampleViewModel : BaseViewModel
    {

        ObservableCollection<SubViewModel> agentsCollection = new ObservableCollection<SubViewModel>();

        public ObservableCollection<SubViewModel> AgentsCollection
        {
            get {return agentsCollection; }
            set { agentsCollection = value; }
        }

        public SampleViewModel()
        {
            AgentsCollection.Add(new SubViewModel() { Description = "Agent Collection 1"});
            AgentsCollection.Add(new SubViewModel() { Description = "Agent Collection 2" });
            AgentsCollection.Add(new SubViewModel() { Description = "Agent Collection 3" });
        }
    }
}
