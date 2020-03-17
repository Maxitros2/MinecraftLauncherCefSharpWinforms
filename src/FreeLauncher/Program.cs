using System;
using System.Windows.Forms;
using FreeLauncher.Forms;


namespace FreeLauncher
{
    internal static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            if(Java.JavaExecutable==null)
            {
                MessageBox.Show("Для работы лаунчера необходима java");
                return;
            }
            Configuration configuration = new Configuration(args);
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BroLauncher(configuration));
            configuration.SaveConfiguration();
        }
    }
}
