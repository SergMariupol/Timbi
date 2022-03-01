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
        public static void Initial(ApplicationContext content)
        {
            if (!content.TypeService.Any())
                content.TypeService.AddRange(TypeServices.Select(c => c.Value));

            if (!content.Region.Any())
                content.Region.AddRange(Regions.Select(c => c.Value));

            if (!content.Company.Any())
            {
                content.AddRange(
                    new Company
                    {
                        NameCompany = "Поставщик последней надежды (Нефтегаз Украины)",
                        Region = Regions["Донецкая"],
                        TypeService = TypeService["Газ"],
                        img = "/img/CompanyIcon/Tesla.jpg",
                    },
                    new Company
                    {
                        NameCompany = "Мариуполь водоканал",
                        Region = Regions["Донецкая"],
                        TypeService = TypeService["Вода"],
                        img = "/img/CompanyIcon/Tesla.jpg",
                    },
                    new Company
                    {
                        NameCompany = "Запорожские электросети",
                        Region = Regions["Запорожская"],
                        TypeService = TypeService["Электричество"],
                        img = "/img/CompanyIcon/Tesla.jpg",
                    });
            }
            content.SaveChanges();
        }

        public static Dictionary<string, TypeService> TypeService;
        public static Dictionary<string, TypeService> TypeServices
        {
            get
            {
                if (TypeService == null)
                {
                    var list = new TypeService[]
                    {
                    new TypeService{TypeServices = "Газ"},
                    new TypeService{TypeServices = "Электричество"},
                    new TypeService{TypeServices = "Вода"},

                    };
                    TypeService = new Dictionary<string, TypeService>();
                    foreach (TypeService el in list)
                        TypeService.Add(el.TypeServices, el);
                }
                return TypeService;
            }
        }

        public static Dictionary<string, Region> Region;
        public static Dictionary<string, Region> Regions
        {
            get
            {
                if (Region == null)
                {
                    var list = new Region[]
                    {
                    new Region{RegionCompany = "Донецкая"},
                    new Region{RegionCompany = "Запорожская"},
                    new Region{RegionCompany = "Луганская"},
                    new Region{RegionCompany = "Днепропетровская"},
                    new Region{RegionCompany = "Сумская"},
                    };
                    Region = new Dictionary<string, Region>();
                    foreach (Region el in list)
                        Region.Add(el.RegionCompany, el);
                }
                return Region;
            }
        }
    }
}