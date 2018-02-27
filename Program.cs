using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace BPF.OAMQServices
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main()
        {
            //调试时使用下面的代码
            //OAMQService oms = new OAMQService();
            //oms.Start();
            //return;
            /////////////

            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
			{ 
				new OAMQService() 
			};
            ServiceBase.Run(ServicesToRun);
        }
    }
}
