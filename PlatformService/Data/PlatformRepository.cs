using PlatformService.Models;

namespace PlatformService.Data
{
    public class PlatformRepository : IPlatformRepository
    {
        private readonly ApplicationDbContext _db;

        public PlatformRepository(ApplicationDbContext db) => _db = db;

        public void CreatePlatform(Platform platform)
        {
            if (platform == null)
            {
                throw new ArgumentNullException(nameof(platform));
            }

            _db.Platforms.Add(platform);
        }

        public IEnumerable<Platform> GetAllPlatforms() => _db.Platforms.ToList();

        public Platform GetPlatformById(int id) => _db.Platforms.FirstOrDefault(p => p.Id == id);

        public bool SaveChanges() => _db.SaveChanges() >= 0;
    }
}
