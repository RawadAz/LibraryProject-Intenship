
using ClassLibrary.Helper;
using ClassLibrary.HttpClients.GenericHC;
using ClassLibrary.JwtToken;
using ClassLibrary.Models.Employee.DTO_s;
using ClassLibrary.Models.Employee.DTO_s.LoginInfo;
using ClassLibrary.Models.Employee.DTO_s.PasswordUpdate;
using System.Net;
using System.Text;
using System.Text.Json;


namespace ClassLibrary.HttpClients.EmployeeHC
{
    public class EmployeeHttpClient : GenericHttpClient<EmployeeDTO>
    {      

        private readonly string _baseUrl = "https://localhost:7049/api/Employee";

        public async Task<LoginInfoResponseDTO?> GetLoginInfo(LoginInfoRequestDTO dto)
        {
            var url = _baseUrl + "/Login";
            var serializedDto = JsonSerializer.Serialize(dto);
            var request = new StringContent(serializedDto, Encoding.UTF8, "application/json");

            using var httpClient = new HttpClient();
                
            HttpResponseMessage response = await httpClient.PostAsync(url, request);

            if (response.StatusCode == HttpStatusCode.OK)
            {

                LoginInfoResponseDTO? responseDTO = await response.Content.ReadAsAsync<LoginInfoResponseDTO?>();

                if (responseDTO != null)
                {   
                    AccessToken.Token = responseDTO.Token;
                    responseDTO.Token = null;

                    return responseDTO;
                }
            }
            string errorMessage = await response.Content.ReadAsStringAsync();
            throw new Exception(errorMessage);
        }

        public async Task<IEnumerable<int>> GetManagerIds()
        {
            string url = _baseUrl + "/Manager_Ids";

            using var httpClient = new LibraryHttpClient();

            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {

                IEnumerable<int> Ids = await response.Content.ReadAsAsync<IEnumerable<int>>();

                if (Ids.Any())
                    return Ids;

            }
            string errorMessage = await response.Content.ReadAsStringAsync();
            throw new Exception(errorMessage);
        }

        public async Task<IEnumerable<int>> GetEmployeeIds()
        {
            string url = _baseUrl + "/Employee_Ids";

            using var httpClient = new LibraryHttpClient();

            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {

                IEnumerable<int> Ids = await response.Content.ReadAsAsync<IEnumerable<int>>();

                if (Ids.Any())
                    return Ids;

            }
            string errorMessage = await response.Content.ReadAsStringAsync();
            throw new Exception(errorMessage);
        }

        public async Task<string> DeleteMultipleEmployees(List<int> ids)
        {
            string url = _baseUrl + "/Multiple";

            var serializedIds = JsonSerializer.Serialize(ids);
            var requestContent = new StringContent(serializedIds, Encoding.UTF8, "application/json");

            HttpRequestMessage request = new()
            {
                Method = HttpMethod.Delete,
                Content = requestContent,
                RequestUri = new Uri(url),
            };

            using var httpClient = new LibraryHttpClient();

            HttpResponseMessage response = await httpClient.SendAsync(request);

            string content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.OK)
                return content;

            string errorMessage = content;
            throw new Exception(errorMessage);
        }

        public async Task<string> UpdatePassword(PasswordUpdateDTO dto)
        {
            string url = _baseUrl + "/Password";

            var serializedEmployee = JsonSerializer.Serialize(dto);
            var request = new StringContent(serializedEmployee, Encoding.UTF8, "application/json");

            using var httpClient = new LibraryHttpClient();

            HttpResponseMessage response = await httpClient.PutAsync(url, request);

            string content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.OK)
                return content;

            string errorMessage = content;
            throw new Exception(errorMessage);
        }
    }
}
