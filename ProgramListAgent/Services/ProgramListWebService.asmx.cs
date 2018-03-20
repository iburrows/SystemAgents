using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ProgramListAgent.Services
{
    /// <summary>
    /// Summary description for ProgramListWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ProgramListWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Program> GetProgramList()
        {
            var programList = new List<Program>();
            string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (Microsoft.Win32.RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key))
            {
                foreach (string subkey_name in key.GetSubKeyNames())
                {
                    using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                    {
                        var programName = subkey.GetValue("DisplayName");
                        if (programName != null)
                        {
                            Program program = new Program((string)programName);
                            programList.Add(program);
                        }

                    }
                }

            }
            return programList;
        }
    }
}
