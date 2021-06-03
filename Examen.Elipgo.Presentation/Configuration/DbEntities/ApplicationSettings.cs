namespace Examen.Elipgo.Presentation.Configuration.DbEntities
{
    public class ApplicationSettings
    {
        public int Id { get; set; }
        public string UrlConnectionRestAPI { get; set; }
        public bool IsFirstExecution { get; set; }
    }
}
