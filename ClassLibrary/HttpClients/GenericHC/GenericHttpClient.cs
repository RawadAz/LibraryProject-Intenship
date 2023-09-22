using ClassLibrary.Helper;
using ClassLibrary.JwtToken;
using System.Net;
using System.Net.Http.Headers;

namespace ClassLibrary.HttpClients.GenericHC
{
    public class GenericHttpClient<T> where T : class
    {
        private readonly string _baseUrl = "https://localhost:7049/api";

        public async Task<IEnumerable<T>> GetAll(string url)
        {
            url = _baseUrl + url;

            using var httpClient = new LibraryHttpClient();
            
            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {

                IEnumerable<T> t = await response.Content.ReadAsAsync<IEnumerable<T>>();

                if (t != null)
                    return t;

            }
            string errorMessage = await response.Content.ReadAsStringAsync();
            throw new Exception(errorMessage);
        }

        public async Task<T> Get(string url)
        {
            url = _baseUrl + url;

            using var httpClient = new LibraryHttpClient();

            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                T t = await response.Content.ReadAsAsync<T>();

                if (t != null)
                    return t;

            }
            string errorMessage = await response.Content.ReadAsStringAsync();
            throw new Exception(errorMessage);
        }

        public async Task<string> Add(string url, StringContent requestContent)
        {
            url = _baseUrl + url;

            using var httpClient = new LibraryHttpClient();

            HttpResponseMessage response = await httpClient.PostAsync(url, requestContent);

            string content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.OK)
                return content;

            string errorMessage = content;
            throw new Exception(errorMessage);
        }

        public async Task<string> Update(string url, StringContent? requestContent = null)
        {
            url = _baseUrl + url;

            using var httpClient = new LibraryHttpClient();

            HttpResponseMessage response = await httpClient.PutAsync(url, requestContent);

            string content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.OK)
                return content;

            string errorMessage = content;
            throw new Exception(errorMessage);
        }

        public async Task<string> Delete(string url)
        {
            url = _baseUrl + url;

            using var httpClient = new LibraryHttpClient();

            HttpResponseMessage response = await httpClient.DeleteAsync(url);

            string content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.OK)
                return content;

            throw new Exception(content);
        }

    }
}
