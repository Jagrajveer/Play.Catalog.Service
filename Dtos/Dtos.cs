using System.ComponentModel.DataAnnotations;

namespace Play.Catalog.Service.Dtos;

public record ItemDto(Guid Id, string Name, string Description, decimal Price, DateTimeOffset CreatedDate);
public record CreateDto([Required] string Name, string Description, [Range(0, 1000)] decimal Price);
public record UpdateDto([Required] string Name, string Description, [Range(0, 1000)] decimal Price);
