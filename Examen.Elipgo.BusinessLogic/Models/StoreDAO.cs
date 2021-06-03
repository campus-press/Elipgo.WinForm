using System.Collections.Generic;

namespace Examen.Elipgo.BusinessLogic.Models
{
    public class StoreDAO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public IEnumerable<ArticleDAO> Articles { get; set; }
    }
}
