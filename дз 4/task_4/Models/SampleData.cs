using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using task_4.Models.Entities;

namespace task_4.Models
{
    public class SampleData
    {
        public static void Initialize(OrderContext context)
        {
            if (!context.Articles.Any())
            {
                context.Articles.AddRange(
                    new Article
                    {
                        Name = "leaflet",
                        Date = new DateTime(2019, 12, 2),
                        CompanyId = 0,
                        NumberOfCopies = 10000
                    },

                    new Article
                    {
                        Name = "leaflet",
                        Date = new DateTime(2020, 12, 20),
                        CompanyId = 1,
                        NumberOfCopies = 240000
                    },

                    new Article
                    {
                        Name = "billboards",
                        Date = new DateTime(2020, 4, 28),
                        CompanyId = 2,
                        NumberOfCopies = 1400
                    });
            }


            if (!context.Companies.Any())
            {
                context.Companies.AddRange(
                    new Company
                    {
                        Name = "AC",
                        Address = "425452, г. Заокский, ул. Елизаровой, дом 14",
                        DateOfEnd = new DateTime(2020, 8, 1)
                    },

                    new Company
                    {
                        Name = "Allard",
                        Address = "676684, г. Ачинское, ул. Красносельская Верхн., дом 81",
                        DateOfEnd = new DateTime(2020, 4, 1)
                    },

                    new Company
                    {
                        Name = "Elva",
                        Address = "301605, г. Енисейск, ул. Глазовский Переулок, дом 55",
                        DateOfEnd = new DateTime(2020, 8, 19)
                    });
            }

            context.SaveChanges();
        }
    }
}
