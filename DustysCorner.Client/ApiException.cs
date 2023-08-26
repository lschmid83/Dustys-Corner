using DustysCorner.Client.Models;
using System;

namespace DustysCorner.Client
{
    public class ApiException : Exception
    {
        public ErrorModel ErrorResponse { get; set; }

        public ApiException(ErrorModel errorResponse) : base(GetMessage(errorResponse))
        {
            ErrorResponse = errorResponse;
        }

        private static string GetMessage(ErrorModel errorResponse)
        {
            if (errorResponse != null)
            {
                return errorResponse.StatusCode + ": " + errorResponse.Message;
            }
            return null;
        }
    }
}
