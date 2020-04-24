using Asp.net_Core_Project.Data;
using Asp.net_Core_Project.Models;
using System.Threading.Tasks;
using System.Linq;

namespace Asp.net_Core_Project.Services
{
    public class BarsService : IBarsService
    {
        private readonly ApplicationDbContext dbContex;

        public BarsService(ApplicationDbContext dbContext)
        {
            this.dbContex = dbContext;
        }
        public async Task<Bar> Create(string userId,string name, string town, string address, string ImageUrl)
        {

            var bar = new Bar
            {
                UserId = userId,
                Name = name,
                Town = town,
                Address = address,
                ImageUrl = ImageUrl
            };
            await this.dbContex.Bars.AddAsync(bar);
            await this.dbContex.SaveChangesAsync();
           

            return bar;
        }
    }
}
