using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WowCaseApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Initialize();
            log4net.Config.XmlConfigurator.Configure();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        static void Initialize()
        {
            DotNetEnv.Env.Load("MyVar.env");
            if (DotNetEnv.Env.GetString("ConnectionStringName") == null || DotNetEnv.Env.GetString("ConnectionString") == null|| DotNetEnv.Env.GetString("ConnectionStringProvider") == null) return;
            ConnectionStringSettings css = new ConnectionStringSettings(DotNetEnv.Env.GetString("ConnectionStringName"), DotNetEnv.Env.GetString("ConnectionString"), DotNetEnv.Env.GetString("ConnectionStringProvider"));

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings.Clear();
            config.ConnectionStrings.ConnectionStrings.Add(css);
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}
