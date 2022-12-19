using Application.Helpers;
using Application.Specifications;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc.Razor;

namespace Presentation.Specifications;

public class AccountPaginatonSpecification :BaseSpecification<Account>
{
    public AccountPaginatonSpecification(Pagination<Account> pagination)
    {
        
    }
}