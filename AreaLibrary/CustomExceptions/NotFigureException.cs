namespace AreaLibrary.CustomExceptions
{
    public class NotFigureException: Exception
    {
        public NotFigureException() { }

        public NotFigureException(string message): base(message) { }
    }
}
