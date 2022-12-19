using Application.Specifications;
using Domain.Entities;
using Presentation.Filter;

namespace Presentation.Specifications;

public class AccountsWithAccountGroupsSpecification:BaseSpecification<Account>
{
    public AccountsWithAccountGroupsSpecification(AccountFilterParams accountFilterParams):base(
        x=> 
            (string.IsNullOrEmpty(accountFilterParams.Search) || x.Name.ToLower().Contains(accountFilterParams.Search)) 
            &&
            (!accountFilterParams.AccountGroupId.HasValue || x.AccountGroupId == accountFilterParams.AccountGroupId) 
            
        )
    {
       
        AddInclude(x=> x.AccountGroup);
        AddOrderBy(x=>  x.Name);
        ApplyPaging(accountFilterParams.PageSize*(accountFilterParams.PageIndex-1),accountFilterParams.PageSize);

        if (string.IsNullOrEmpty(accountFilterParams.Sort)) return;
        switch (accountFilterParams.Sort)
        {
            case "nameDesc":
                AddOrderByDescending(p => p.Name);
                break;
            case "groupDesc":
                AddOrderByDescending(x => x.AccountGroup.Name);
                break;
            case "groupAsc":
                AddOrderBy(x => x.AccountGroup.Name);
                break;
        }

    }
    
    
    
}