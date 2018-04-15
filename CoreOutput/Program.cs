using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CoreLogic;
using CoreOutput.SR_ProgramListWebService;
using Shared;
using Shared.Delegates;

namespace CoreOutput
{                                                           //HINT: START AS ADMIN!
    class Program
    {
        /// <summary>
        /// Contains a very simple output to the console
        ///
        /// </summary>
        /// <param name="args"></param>
        /// 
        
        static void Main(string[] args)
        {
            Program prog = new Program();
            
        }

        private static void client_GetProgramListCompleted(object sender, GetProgramListCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public Program()
        {
            Console.WriteLine("Core Component Started");
            LogicHandler lh = new LogicHandler(new MessageInformer(NewMessageReceived));
            Timer timer = new Timer(StartTimer, null, 0, 60000);

            Console.ReadLine();
            
            while (true)
            {
                Thread.Sleep(100);
            }

        }

        private void StartTimer(object state)
        {
            PrintName();
        }

        /// <summary>
        /// Prints an output to the console after a message was received
        /// </summary>
        /// <param name="message"></param>
        private void NewMessageReceived(CoreMessage message)
        {
            Console.WriteLine(String.Format("Received message from \"{0}\" at \"{1}\"\r\n\t{2}",
                                message.Source, message.Date.ToShortTimeString(), message.Data));
        }

        private List<CoreOutput.SR_ProgramListWebService.Program> GetListForConsole()
        {
            SR_ProgramListWebService.ProgramListWebServiceSoapClient client = new SR_ProgramListWebService.ProgramListWebServiceSoapClient();
            client.GetProgramListCompleted += client_GetProgramListCompleted;
            //List<CoreOutput.SR_ProgramListWebService.Program> programs = client.GetProgramListAsync();
            List<CoreOutput.SR_ProgramListWebService.Program> programs = client.GetProgramList();
            return programs;
        }

        //private void PrintName(List<CoreOutput.SR_ProgramListWebService.Program> programList)
        private void PrintName()
        {
            string time = DateTime.Now.ToShortTimeString();

            Console.WriteLine("Calling Program List Web Service at {0}", time);
            var programList = GetListForConsole();
            Console.WriteLine("*********************************");
            foreach (var item in programList)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("*********************************");
        }
    }
}
