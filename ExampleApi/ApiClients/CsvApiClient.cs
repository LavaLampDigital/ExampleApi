using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CsvHelper;
using ExampleApi.Models;

namespace ExampleApi.ApiClients
{
    public interface ICsvApiClient
    {
        public Task<List<CsvLine>> GetCsvData();
    }
    
    public class CsvApiClient : ICsvApiClient
    {
        private readonly HttpClient _httpClient;

        public CsvApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CsvLine>> GetCsvData()
        {
            var response = await _httpClient.GetAsync("https://assets.publishing.service.gov.uk/government/uploads/system/uploads/attachment_data/file/1006267/Annex_B_-_Example_CSV_file_-_Appeals_in_vocational_and_technical_qualifications_-_guide_to_the_data_submission_process.csv");
            using var reader = new StreamReader(await response.Content.ReadAsStreamAsync());
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<CsvLine>().ToList();
        }
    }
}