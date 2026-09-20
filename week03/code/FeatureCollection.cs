public class FeatureCollection
{
    public Feature[] Features { get; set; } = [];
    // Create additional classes as necessary
}


public class Feature
{
    public EarthquakeProperties Properties { get; set; } = new();
    // Create additional classes as necessary
}

public class EarthquakeProperties
{
    public string Place { get; set; } = "";
    public double Mag { get; set; } 
}