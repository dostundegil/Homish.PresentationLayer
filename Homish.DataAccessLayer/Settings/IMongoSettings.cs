namespace Homish.DataAccessLayer.Settings
{
    public interface IMongoSettings
    {
        string AboutUsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string PropertiesByAreaCollectionName { get; set; }
        string PropertyCollectionName { get; set; }
        string StatisticsCollectionName { get; set; }
    }
}