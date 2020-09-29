using BLL.Interfaces;
using BLL.Services;
using DAL.Interfaces;
using PL;

using DAL.Interfaces.Repositories;
using DAL.EF;
using NLayerApp.DAL.Repositories;
using DAL.Entities;
using System;
using System.Linq;
using PL.Controllers;

namespace ConsolePro
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext dataContext = new DataContext();
            IUnitOfWork unitOfWork = new EFUnitOfWork(dataContext);


            IMarketerServices marketerServices = new MarketerServices(unitOfWork);
            MarketerController marketerController = new MarketerController(marketerServices);
            View view = new View(marketerController);
            while (true)
            {
                view.MakeAction();
            }

        }
    }
}
