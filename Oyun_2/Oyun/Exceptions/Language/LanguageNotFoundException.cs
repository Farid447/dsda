﻿namespace Oyun.Exceptions.Language
{
    public class LanguageNotFoundException : Exception, IBaseException
    {
        public int StatusCode => StatusCodes.Status404NotFound;

        public string ErrorMessage { get; }

        //public LanguageNotFoundException()
        //{
        //    ErrorMessage = "Bu dil tapılmadı";
        //}

        public LanguageNotFoundException(string message = "Bu dil tapılmadı") : base(message)
        {
            ErrorMessage = message;
        }
    }
}
