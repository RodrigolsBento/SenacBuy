namespace SenacBuy.Domain.Entities
{
    public class ItemPedido
    {

        public int Id { get; set; }

        public int PedidoId { get; set; } //chave estrangeira para o pedido

        public int ProdutoId { get; set; }//chave estrangeira para o produto

        public int Quantidade { get; set; } //quanto o usuário comprou
        public decimal PrecoUnitario { get; set; } 

        //propriedades de navegação, referência entre entidades, possui o tipo da classe 

        public Pedido? Pedido { get; set; }

        public Produto? Produto { get; set; }

        //calculo dentro de uma classe - não é boa e nem má pratica - á tipico
        public decimal Subtotal => Quantidade * PrecoUnitario; //langda função com flecha 








    }
}
