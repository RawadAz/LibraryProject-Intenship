using ClassLibrary.Helper;
using ClassLibrary.HttpClients.GenericHC;
using ClassLibrary.Models.Reservation.DTO;
using System.Net;
using System.Text;
using System.Text.Json;

namespace ClassLibrary.HttpClients.ReservationHC;

public class ReservationHttpClient : GenericHttpClient<ReservationDTO>
{
    private readonly string _baseUrl = "https://localhost:7049/api/Reservation";

    public async Task<string> DeleteReservation(DeleteReservationDTO dto)
    {
        var serializedDTO = JsonSerializer.Serialize(dto);
        var requestContent = new StringContent(serializedDTO, Encoding.UTF8, "application/json");

        HttpRequestMessage request = new()
        {
            Method = HttpMethod.Delete,
            Content = requestContent,
            RequestUri = new Uri(_baseUrl)
        };

        using var httpClient = new LibraryHttpClient();
        HttpResponseMessage response = await httpClient.SendAsync(request);

        string content = await response.Content.ReadAsStringAsync();

        if (response.StatusCode == HttpStatusCode.OK)
            return content;

        string errorMessage = content;
        throw new Exception(errorMessage);
    }

}
