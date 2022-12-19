using Application.Specifications;
using Domain.Entities;
using Presentation.Filter;

namespace Presentation.Specifications;

public class AccountsWithAccountGroupsCountSpecification : BaseSpecification<Account>
{
    public AccountsWithAccountGroupsCountSpecification(AccountFilterParams accountFilterParams) : base(
        x =>
            (string.IsNullOrEmpty(accountFilterParams.Search) || x.Name.ToLower().Contains(accountFilterParams.Search))
            &&
            (!accountFilterParams.AccountGroupId.HasValue || x.AccountGroupId == accountFilterParams.AccountGroupId))

    {
    }
}