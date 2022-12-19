namespace Presentation.Dtos;

public record AccountDto(
    int Id,
    string Name,
    AccountGroupDto AccountGroup,
    int AccountGroupId,
    string? IBAN,
    string? TaxOffice,
    string? TaxNumber
);