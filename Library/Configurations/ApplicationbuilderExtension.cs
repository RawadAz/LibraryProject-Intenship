namespace Library.Configurations;

public static class ApplicationbuilderExtension
{
    public static IApplicationBuilder addGlobalErrorHandling(this IApplicationBuilder applicationBuilder)
        => applicationBuilder.UseMiddleware<GlobalExceptionHandlingMiddleware>();
}
