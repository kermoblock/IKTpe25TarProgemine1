using System;
using InheritanceAndServiceClass.AppServices.Services;
using InheritanceAndServiceClass.Core.ServiceInterface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace InheritanceAndServiceClass
{
    internal class Program
    {
        private readonly ICarServices _carServices;

        public Program
        (
            ICarServices carServices
        )
        {
            _carServices = carServices;
        }

        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped<ICarServices, CarServices>();

            Console.WriteLine("Hello World Switch!");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
                case 1:
                    var app = builder.Build();
                    using (var scope = app.Services.CreateScope())
                    {
                        var carServices = scope.ServiceProvider.GetRequiredService<ICarServices>();
                        var program = new Program(carServices);
                        program.GetAsync();
                    }
                    break;

                case 2:
                    var ap = builder.Build();
                    using (var scope = ap.Services.CreateScope())
                    {
                        var carServices = scope.ServiceProvider.GetRequiredService<ICarServices>();
                        var program = new Program(carServices);
                        program.PostData();
                    }
                    break;

                case 3:
                    var a = builder.Build();
                    using (var scope = a.Services.CreateScope())
                    {
                        var carServices = scope.ServiceProvider.GetRequiredService<ICarServices>();
                        var program = new Program(carServices);
                        program.PutData();
                    }
                    break;

                case 4:
                    var appp = builder.Build();
                    using (var scope = appp.Services.CreateScope())
                    {
                        var carServices = scope.ServiceProvider.GetRequiredService<ICarServices>();
                        var program = new Program(carServices);
                        program.DeleteData();
                    }
                    break;


                default:
                Console.WriteLine("Error");
                    break;
        }
    }

        public IActionResult GetAsync()
        {
            _carServices.GetData();

        return View();
        }

        public IActionResult PostData()
        {
            _carServices.SaveAsync();

            return View();
        }

        public IActionResult PutData()
        {
            _carServices.UpdateData();

            return View();
        }

        public IActionResult DeleteData()
        {
            _carServices.EraseData();

            return View();
        }

        private IActionResult View()
    {
        throw new NotImplementedException();
    }
    }
}


