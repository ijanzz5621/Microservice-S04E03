using PlatformService.Models;

namespace PlatformService.Data
{
    public interface IPlatformRepo
    {
         bool SaveChanges();

         ICollection<Platform> GetAllPlatforms();

         Platform GetPlatformById(int id);

         void CreatePlatform(Platform platform);
    }
}