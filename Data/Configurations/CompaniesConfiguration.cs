using KariyerClone.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KariyerClone.Data.Configurations
{
    public class CompaniesConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
                new Company
                {
                    Id = 1,
                    Name = "Google",
                    Address = "California",
                    FoundationYear = 1998,
                    Sector = "IT",
                    Description  = "Google LLC is an American multinational " +
                    "technology company that focuses on artificial intelligence, " +
                    "search engine technology, online advertising, cloud computing, " +
                    "computer software, quantum computing, e-commerce, and consumer electronics.",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/53/Google_%22G%22_Logo.svg/800px-Google_%22G%22_Logo.svg.png",
                    NumberOfEmployees = 300000,
                    Website = "https://www.google.com/"
                },
                new Company
                {
                    Id = 2,
                    Name = "Disney",
                    Address = "California",
                    FoundationYear = 1923,
                    Sector = "Media",
                    Description = "The Walt Disney Company, commonly known as Disney, is an American multinational mass media and entertainment conglomerate headquartered at the Walt Disney Studios complex in Burbank, California.",
                    Logo = "https://frpnet.net/wp-content/uploads/2018/11/Disney-logo-1.jpg",
                    NumberOfEmployees = 200000,
                    Website = "https://thewaltdisneycompany.com/"
                },
                new Company
                {
                    Id = 3,
                    Name = "AIRBUS",
                    Address = "Leiden",
                    FoundationYear = 1970,
                    Sector = "Aerospace",
                    Description = "Airbus SE is a European multinational aerospace corporation. Airbus designs, manufactures and sells civil and military aerospace products worldwide and manufactures aircraft in Europe and various countries outside Europe.",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cf/Logo_Airbus_2014.svg/2560px-Logo_Airbus_2014.svg.png",
                    NumberOfEmployees = 100000,
                    Website = "https://www.airbus.com/en"
                },
                new Company
                {
                    Id = 4,
                    Name = "From Software",
                    Address = "Tokyo",
                    FoundationYear = 1986,
                    Sector = "IT",
                    Description = "FromSoftware, Inc. is a Japanese video game development company founded in November 1986 and a subsidiary of Kadokawa Corporation. The company is best known for their Armored Core and Souls series, including the related games Bloodborne, Sekiro, and Elden Ring.",
                    Logo = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/012011/from_soft.png?itok=EA5zFilD",
                    NumberOfEmployees = 9877,
                    Website = "https://www.fromsoftware.jp/ww/"
                },
                new Company
                {
                    Id = 5,
                    Name = "Peak",
                    Address = "Istanbul",
                    FoundationYear = 2010,
                    Sector = "IT",
                    Description = "Peak Games is a mobile gaming company based in Istanbul, Turkey. The privately-held company was acquired by Zynga in June 2020 for $1.8 billion. The company launched the games Toy Blast in 2015 and Toon Blast in 2017, both collectively have more than 12 million average mobile daily active users as of June 2020.",
                    Logo = "https://peakweb.global.ssl.fastly.net/static/assets/icons/logo-header-180-90.b348ab1a.png",
                    NumberOfEmployees = 3213,
                    Website = "https://peak.com/"
                }

                );





  

        }
    }
}
