using Library_API;

namespace Api.Aggregator.Configuratuins.Services;

public static class CarConfigurations
{
    public static IServiceCollection CarConfigur(this IServiceCollection services, IConfiguration Configuration)
    {
        services.AddHttpClient<ICarService, CarService>(o =>
        {
            o.BaseAddress = new Uri(Configuration["ApiSetting:CarUrl"]);
        });
        return services; 
    }
}


public class CarService : ICarService
{
    private readonly HttpClient _client;

    public CarService(HttpClient client)
    {
        _client = client;
    }

    public async Task<CarDtails> GetCarDtails(int id)
    {
        var response = await _client.GetAsync($"/api/v1/Cars/{id}");
        return await response.ReadContentAs<CarDtails>();
    }
}

public interface ICarService
{
    Task<CarDtails> GetCarDtails(int id);
}

public class ListCar
{
  public List<CarDtails> Cars { get; set; }
}

public class CarDtails
{

    public int Id { get; set; }

    public byte CarTypeId { get; set; }

    public string CarName { get; set; }

    public string CodePlack { get; set; }

    public string NumberPlack { get; set; }

    public bool IsActive { get; set; }


}
