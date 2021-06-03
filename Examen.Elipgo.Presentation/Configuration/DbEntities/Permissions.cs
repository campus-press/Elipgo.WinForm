namespace Examen.Elipgo.Presentation.Configuration.DbEntities
{
    public class Permissions
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
