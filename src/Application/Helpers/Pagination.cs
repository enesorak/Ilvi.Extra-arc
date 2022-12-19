namespace Application.Helpers;

public class Pagination<T> where T:class
{
    public Pagination(int pageSize,int pageIndex, int count, IReadOnlyList<T> data)
    {
        PageSize = pageSize;
        Data = data;
        Count = count;
        PageIndex = pageIndex;
    }
    public int PageIndex { get; set; }
    public int PageSize { get; set; }
    public int Count { get; set; }
    public IReadOnlyList<T> Data { get; set; }
}