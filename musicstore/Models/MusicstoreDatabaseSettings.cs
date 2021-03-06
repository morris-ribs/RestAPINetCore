namespace Musicstore.Models
{
    public class MusicstoreDatabaseSettings : IMusicstoreDatabaseSettings
    {
        public string AlbumsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IMusicstoreDatabaseSettings
    {
        string AlbumsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}