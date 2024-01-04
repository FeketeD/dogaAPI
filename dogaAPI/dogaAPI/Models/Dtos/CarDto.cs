namespace dogaAPI.Models.Dtos
{
    public record CarDto(Guid Id, string Brand, string Model, int Price, DateTime CretedDate);
    public record CreateCarDto(string Brand, string Model, int Price);
    public record UpdateCarDto(string Brand, string Model, int Price);

    public record DealerDto(Guid Id, string Name, string Address, Guid CarsId, DateTime CretedDate);
    public record CreateDealerDto(string Name, string Address, Guid CarsId);
    public record UpdateDealerDto(string Name, string Address, Guid CarsId);
}
