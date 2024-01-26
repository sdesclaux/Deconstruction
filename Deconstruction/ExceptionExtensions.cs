namespace Deconstruction
{
    public static class ExceptionExtensions
    {
        public static void Deconstruct(this Exception ex, out string message, out string? stacktrace)
        {
            message = ex.Message;
            stacktrace = ex.StackTrace;
        }
    }
}
