using Asp.net_Core_Project.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Asp.net_Core_Project.Services
{
    public interface IBarsService
    {
        Task<Bar> Create(string userId,string name, string town, string address, string ImageUrl);
    }
}
