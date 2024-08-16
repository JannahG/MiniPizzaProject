using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

namespace MiniPizzaProject.Services
{
    public static class CsvDataReaderHelper
    {
        public static IEnumerable<T> ReadFromCsv<T>(string fileName, ClassMap<T> classMap) where T : class
        {
            string filePath = Path.Combine(AppContext.BaseDirectory, "Data", fileName);

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("The specified file was not found.", filePath);
            }

            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true
            });

            csv.Context.RegisterClassMap(classMap);

            var records = csv.GetRecords<T>().ToList();
            return records;
        }
    }
}