using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timbi.Data.Models;

namespace Timbi.Data
{
    public class DBObjects
    {
        public static Dictionary<string, Company> Company;
        public static void Initial(ApplicationContext content)
        {

            if (!content.Company.Any())
            {
                content.AddRange(
                    new Company
                    {
                        NameCompany = "Поставщик последней надежды (Нефтегаз Украины)",
                        RegionCompany = "Донецкая",
                        TypeServices = "Газ",
                        img = "/img/Tesla.jpg",
                    });
            }

            content.SaveChanges();


        }
       
    }
}