using AppCore.Interfaces;
using AppCore.Services;
using Autofac;
using Domain.Interfaces;
using Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
		Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var builder = new ContainerBuilder();

			builder.RegisterType<NotaListRepository>().As<INotaRepository>();
			builder.RegisterType<NotaServices>().As<NotaRepositoryServices>();
			var container = builder.Build();
			Application.Run(new Form1(container.Resolve<NotaRepositoryServices>()));
		}
	}
}
