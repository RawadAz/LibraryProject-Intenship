using Microsoft.Data.SqlClient;
using System.Net;

namespace Library.Configurations;

public class GlobalExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public GlobalExceptionHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private static Task HandleExceptionAsync(HttpContext context, Exception ex)
    {
        HttpStatusCode statusCode;
        string message;

        var exceptionType = ex.GetType();

        if (exceptionType == typeof(NotImplementedException))
        {
            message = "Service unavailable";
            statusCode = HttpStatusCode.NotImplemented;
        }

        else if (exceptionType == typeof(InvalidCastException))
        {
            message = "something went wrong, please check the info you entered";
            statusCode = HttpStatusCode.BadRequest;
        }

        else if (exceptionType == typeof(InvalidOperationException))
        {
            message = ex.Message;
            statusCode = HttpStatusCode.InternalServerError;
        }
        //SQL Exceptions
        else if (exceptionType == typeof(SqlException))
        {
            var sqlEx = (SqlException)ex;

            switch (sqlEx.Number)
            {
                // Unique/Primary/Foreign key exception
                case 2627:
                    message = sqlEx.Message;

                    if (sqlEx.Message.ToLower().Contains("phone_number"))
                        message = "Phone Number Already Exists!";

                    else if (sqlEx.Message.ToLower().Contains("event_client_ids"))
                        message = "client already reserved seats for this event, try updating instead";

                    else if (sqlEx.Message.ToLower().Contains("manager_id"))
                        message = "Invalid manager id, please enter a correct one";

                    else if (sqlEx.Message.ToLower().Contains("fk_supervisor_emp"))
                        message = "Invalid supervisor id";

                    else if (sqlEx.Message.ToLower().Contains("username"))
                        message = "Username Already Exists!";

                    else if (sqlEx.Message.ToLower().Contains("branch_id"))
                        message = "Invalid branch id, please enter a correct one";

                    else if (sqlEx.Message.ToLower().Contains("fk_trans_book_id"))
                        message = "Book not available";

                    else if (sqlEx.Message.ToLower().Contains("fk_trans_client_id"))
                        message = "client not found";

                    else if (sqlEx.Message.ToLower().Contains("fk_trans_employee_id"))
                        message = "Invalid employee id";
                    
                    statusCode = HttpStatusCode.BadRequest; 
                    break;

                // constraint exceptions
                case 547:
                    message = sqlEx.Message;
                    statusCode = HttpStatusCode.BadRequest;

                    if (sqlEx.Message.ToLower().Contains("gender"))
                        message = "please select a correct gender (male/female)";

                    
                    else if (sqlEx.Message.ToLower().Contains("chk_in_stock"))
                        message = "Book out of stock";
    
                    else if (sqlEx.Message.ToLower().Contains("currently_rented_const"))
                        message = "client exceeded the allowed number of rented books";

                    else if (sqlEx.Message.ToLower().Contains("transaction_type_check"))
                        message = "Invalid transaction type, please select a valid type (purchase/rent)";

                    

                    break;

                // TimeOut
                case -2:
                case 8645:
                    message = "Your request took too long and the server timed out, please try again";
                    statusCode = HttpStatusCode.RequestTimeout;
                    break;

                // Transaction failed
                case 1205:
                    message = "Failed to complete transaction, Please try again";
                    statusCode = HttpStatusCode.Conflict;
                    break;

                // Handle other SQL exceptions here if needed

                default:
                    message = ex.Message;
                    statusCode = HttpStatusCode.InternalServerError;
                    // Handle any other SQL exceptions that are not explicitly covered
                    break;
            }
        }

        else
        {
            message = ex.Message;
            statusCode = HttpStatusCode.InternalServerError;

        }

        var exceptionResult = message;
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)statusCode;

        return context.Response.WriteAsync(exceptionResult);
        }

    }

