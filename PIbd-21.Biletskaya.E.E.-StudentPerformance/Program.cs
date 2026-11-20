using Unity;
using PIbd_21.Biletskaya.E.E._StudentPerformance.DependencyInjection;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            IUnityContainer container = DependencyConfig.CreateContainer();

            container.RegisterType<MainForm>();

            Application.Run(container.Resolve<MainForm>());
        }
    }
}
