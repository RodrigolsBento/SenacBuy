namespace SenacBuy.Domain.Entities
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public decimal  Preco { get; set; }


        //cardinalidade com prorpiedade de navegação
        //juntando linq e langda 
        //for sem precisar do for ou seja percorrer os itens 
        public ICollection<ItemPedido> ItensPedido { get; set; } = new List<ItemPedido>();



    }
}
