using Application.Helpers;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Presentation.Dtos;
using Presentation.Exceptions;
using Presentation.Filter;
using Presentation.Specifications;

namespace Presentation.Controllers;


 
public class AccountController :BaseApiController
{

 private readonly IUnitOfWork _unitOfWork;
 private readonly IMapper _mapper;
 
 
 private readonly IGenericRepository<Account> _accountRepo;

 public AccountController(IUnitOfWork unitOfWork, IMapper mapper, IGenericRepository<Account> accountRepo)
 {
  _unitOfWork = unitOfWork;
  _mapper = mapper;
  _accountRepo = accountRepo;
 }

 [HttpGet("{id:int}")]
 public async Task<IActionResult> GetAsync(int id)
 {
  var select = await _accountRepo.FindByIdAsync(id);
  if (select is null)
   return NotFound(new ApiResponse(404, "Cant touch this !! Id not found"));
  return Ok(select);
 }

 [HttpGet()]
 public async Task<ActionResult<IReadOnlyList<Pagination<Account>>>> GetAccounts([FromQuery]AccountFilterParams accountFilterParams)
 {
  var spec = new AccountsWithAccountGroupsSpecification(accountFilterParams);
  var countSpec = new AccountsWithAccountGroupsCountSpecification(accountFilterParams);
  var accounts = await _accountRepo.ListFilterAsync(spec);
  var count = await _accountRepo.CountAsync(countSpec);
 var map = _mapper.Map<List<AccountDto>>(accounts);

 var pagination 
  = new Pagination<AccountDto>(accountFilterParams.PageSize,accountFilterParams.PageIndex,count,map);
 
 return Ok(pagination);

 }


}