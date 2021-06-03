namespace Examen.Elipgo.BusinessLogic.Models
{
    public class ArticleDAO
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
        public StoreDAO Store { get; set; }
    }
}
