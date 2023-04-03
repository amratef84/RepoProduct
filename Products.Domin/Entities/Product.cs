namespace Products.Domain.Entites
{
    public class Product
    {


        public Guid Id { get; set; }
        public string Name { get; set; }

      //  public int ProductId { get; set; }
      //  public string ProductName { get; set; }

        public string Description { get; set; }
       public ICollection<SizeProduct> Sizes { get; set; }


    }
    
}
