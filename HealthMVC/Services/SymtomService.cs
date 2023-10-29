using HealthMVC.Dto;
using HealthMVC.Models;

namespace HealthMVC.Services
{
    public class SymtomService
    {
        private readonly HttpClient _httpClient;

        public SymtomService(IHttpClientFactory clientFactory)
        {
            _httpClient = clientFactory.CreateClient("HealthClient");
        }

        public async Task<List<symptomsDto>> GetSymptoms(string token, string languAge)
        {
            var symptoms = await _httpClient.GetFromJsonAsync<List<symptomsDto>>($"symptoms?token={token}&languAge={languAge}");
            return symptoms;
        }

        public async Task<Diagnosis> GetDiagnosis(string token, string languAge, int[] symptoms, String gender, int year_of_birth)
        {
            var diagnoses = await _httpClient.GetFromJsonAsync<List<Diagnosis>>($"diagnosis?token={token}&languAge={languAge}&symptoms=[{string.Join(",", symptoms)}]&gender={gender}&year_of_birth={year_of_birth}");
            var diagnosisWithHighAccuracy = diagnoses.OrderByDescending(d => d.Issue.Accuracy).FirstOrDefault();
            return diagnosisWithHighAccuracy;
        }

        public async Task<IssuesInfo> GetIssuesInfo(string token, string languAge, int issue_id)
        {
            var issuesInfo = await _httpClient.GetFromJsonAsync<IssuesInfo>($"issues/{issue_id}/info?token={token}&languAge={languAge}");
            return issuesInfo;
        }

        public async Task<List<SpecialisationDto>> GetSpecialisations(string token, string languague)
        {
            var spec = await _httpClient.GetFromJsonAsync<List<SpecialisationDto>>($"specialisations?token={token}&languAge={languague}");
            return spec;
        }
    }
}