namespace AgentsGui.ViewModel
{
    public class AgentViewModel : BaseViewModel
    {
        private string name;
        private string host;
        private string time;
        private double posX;
        private double posY;



        public double PosX
        {
            get { return posX; }
            set { posX = value; }
        }
        public double PosY
        {
            get { return posY; }
            set { posY = value; }
        }
        public string Host
        {
            get { return host; }
            set { host = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public string Time
        {
            get { return time; }
            set { time = value; }
        }
    }
}