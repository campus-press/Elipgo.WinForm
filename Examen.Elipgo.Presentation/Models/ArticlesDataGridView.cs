using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Elipgo.Presentation.Models
{
    public class ArticlesDataGridView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int TotalInShelf { get; set; }
        public int TotalInVault { get; set; }
        public int StoreId { get; set; }
        public string NameStore { get; set; }
        public string Address { get; set; }
    }
}
