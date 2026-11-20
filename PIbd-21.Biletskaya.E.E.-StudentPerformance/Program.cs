
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using Unity;
using PIbd_21.Biletskaya.E.E._StudentPerformance.DependencyInjection;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Forms;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
                IConfiguration configuration = new ConfigurationBuilder()
                    .SetBasePath(AppContext.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: false)
                    .Build();

                Log.Logger = new LoggerConfiguration()
                    .ReadFrom.Configuration(configuration)
                    .CreateLogger();

                using ILoggerFactory loggerFactory =
                    LoggerFactory.Create(builder =>
                        builder.AddSerilog(Log.Logger, dispose: false));

                Microsoft.Extensions.Logging.ILogger appLogger = loggerFactory.CreateLogger("StudentPerformance");

                IUnityContainer container = DependencyConfig.CreateContainer();

                container.RegisterInstance<Microsoft.Extensions.Logging.ILogger>(appLogger);

                Log.Information("Приложение запущено");

                container.RegisterType<MainForm>();

                Application.Run(container.Resolve<MainForm>());
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Критическая ошибка приложения");

                MessageBox.Show(
                    "Произошла ошибка при запуске приложения:\n" + ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Log.Information("Приложение завершено");
                Log.CloseAndFlush();
            }
        }
    }
}
