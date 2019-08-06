using System;
using System.IO;
using System.Windows;
using System.Security.Principal;

namespace WpfApp3
{
	public partial class App : Application
	{
		public static int _isThisSharedCount = 0;
		public App()
		{
			if (Environment.GetCommandLineArgs().GetLength(0) > 1)
			{
				var args = Environment.GetCommandLineArgs();
				string argPassedIn = args[1].ToUpper();

				GenericIdentity identity = new GenericIdentity(argPassedIn);

				System.Threading.Thread.CurrentPrincipal = new GenericPrincipal(identity, new string[] { "roles" });
				while (1 > 0)
				{
					using (StreamWriter w = File.AppendText("log.txt"))
					{
						_isThisSharedCount++;
						w.WriteLine("For arg: " + argPassedIn + " Count: " + _isThisSharedCount.ToString() + " Name on thread: " + System.Threading.Thread.CurrentPrincipal.Identity.Name);
					}
					System.Threading.Thread.Sleep(3000);//sleep 3 seconds
				}
			}
			Environment.Exit(1);
		}
	}
}
