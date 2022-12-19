using Application.Interfaces;
using AutoMapper;
using Domain.Primitives;
using Microsoft.AspNetCore.Mvc;
using Presentation.Exceptions;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FinanceController<T, TAdd, TUpdate, TList> : ControllerBase
    where T : Entity
    
{
    protected readonly IGenericRepository<T> _repository;
    private readonly IUnitOfWork _unitOfWork;
    protected readonly IMapper _mapper;
 
    public FinanceController(IGenericRepository<T> repository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetAsync(int id)
    {
        var select = await _repository.FindByIdAsync(id);
        if (select is null)
            return NotFound(new ApiResponse(404, "Cant touch this !! Id not found"));

        return Ok(select);
    }

    [HttpGet("List")]
    public async Task<IActionResult> ListAllAsync()
    {
        var select = await _repository.ListAsNoTrackingAsync();
        if (!select.Any())
            return NotFound(new ApiResponse(404, "Cant touch this !! Nothing to list"));
        var mapDto = _mapper.Map<List<TList>>(select);
        return Ok(mapDto);
    }

    [HttpPost("Add")]
    public async Task<IActionResult> AddAsync(TAdd entity)
    {
        var mapT = _mapper.Map<T>(entity);
        await _repository.AddAsync(mapT);
        await _unitOfWork.SaveChangesAsync();
        var mapDto = _mapper.Map<TList>(mapT);
        return Ok(mapDto);
    }

    [HttpPut("Update")]
    public async Task<IActionResult> UpdateAsync(TUpdate entity)
    {
        var mapT = _mapper.Map<T>(entity);
        _repository.Update(mapT);
        await _unitOfWork.SaveChangesAsync();
        var mapDto = _mapper.Map<TList>(mapT);
        return Ok(mapDto);
    }

    [HttpDelete("Remove/{id:int}")]
    public async Task<IActionResult> RemoveAsync(int id)
    {
        var selectRow = await _repository.FindByIdAsync(id);
        if (selectRow is null)
            return NotFound(new ApiResponse(404, "Cant touch this !! Id not found"));

        _repository.Remove(selectRow);
        await _unitOfWork.SaveChangesAsync();
        return Ok($"{typeof(T).Name} {id} successfully removed !");
    }
}