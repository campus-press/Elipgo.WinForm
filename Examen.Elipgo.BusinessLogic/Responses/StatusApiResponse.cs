namespace Examen.Elipgo.BusinessLogic.Responses
{
    public class StatusApiResponse
    {
        public bool Success { get; set; }
        public string Status_Code { get; set; }
        public string Error_Code { get; set; }
        public string Message { get; set; }
        public string Message_Error { get; set; }
    }

    public class StatusApiResponse<T>
    {
        public bool Success { get; set; }
        public string Status_Code { get; set; }
        public string Error_Code { get; set; }
        public string Message { get; set; }
        public string Message_Error { get; set; }
        public T Value { get; set; }
    }
}
