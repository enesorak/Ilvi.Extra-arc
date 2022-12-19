namespace Presentation.Exceptions;

public class ApiResponse
{
    public ApiResponse(int statusCode, string? message = null)
    {
        StatusCode = statusCode;
        Message = message ?? GetDefaultMessageForStatusCode(statusCode);
    }

    private string GetDefaultMessageForStatusCode(int statusCode)
    {
        return statusCode switch
        {
            200 => "There is no problem at all",
            400 => "Boy, You are such a Bad Request",
            401 => "Oh, sorry, You are not authorized",
            404 => "Check it, Resource was not found",
            500 => "Oops, looks like Server Error",
            _ => "Error"
        };
    }

    public int StatusCode { get; set; }
    public string? Message { get; set; }
}