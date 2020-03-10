using CsvHelper.Configuration;

namespace EksploracjaDanych
{
    public class DataModelCsvMap : ClassMap<DataModel>
    {
        public DataModelCsvMap()
        {
            Map(s => s.FixedAcidity).Name("fixed acidity");
            Map(s => s.VolatileAcidity).Name("volatile acidity");
            Map(s => s.CitricAcid).Name("citric acid");
            Map(s => s.ResidualSugar).Name("residual sugar");
            Map(s => s.Chlorides).Name("chlorides");
            Map(s => s.FreeSulfurDioxide).Name("free sulfur dioxide");
            Map(s => s.TotalSulfurDioxide).Name("total sulfur dioxide");
            Map(s => s.Density).Name("density");
            Map(s => s.PH).Name("pH");
            Map(s => s.Sulphates).Name("sulphates");
            Map(s => s.Alcohol).Name("alcohol");
            Map(s => s.Quality).Name("quality");
        }
    }
}
