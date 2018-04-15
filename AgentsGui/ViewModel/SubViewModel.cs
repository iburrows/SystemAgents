using System;
using System.Collections.ObjectModel;

namespace AgentsGui.ViewModel
{
    public class SubViewModel:BaseViewModel
    {
        ObservableCollection<AgentViewModel> agents = new ObservableCollection<AgentViewModel>();

        private string name;

        public string Description
        {
            get { return name; }
            set { name = value; }
        }

        public ObservableCollection<AgentViewModel> Agents
        {
            get { return agents; }
            set { agents = value; }
        }

        public SubViewModel()
        {
            Agents.Add(new AgentViewModel() { Name = "Agent 1", Host = "1234", PosX = 50, PosY = 100, Time = DateTime.Now.ToShortTimeString() });
            Agents.Add(new AgentViewModel() { Name = "Agent 2", Host = "4567", PosX = 100, PosY = 150, Time = DateTime.Now.ToShortTimeString() });
            Agents.Add(new AgentViewModel() { Name = "Agent 3", Host = "8768", PosX = 50, PosY = 200, Time = DateTime.Now.ToShortTimeString() });
        }
    }
}