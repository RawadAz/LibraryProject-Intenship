using ClassLibrary.JwtToken;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Helper
{
    public class LibraryHttpClient : HttpClient
    {
        public LibraryHttpClient()
        {
            // Set the default headers in the constructor
            DefaultRequestHeaders.Accept.Clear();
            DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken.Token);
        }
    }
}
