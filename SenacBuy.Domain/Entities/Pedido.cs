namespace SenacBuy.Domain.Entities
{
    public  class Pedido
    {

        public int Id { get; set; }
        public int ClienteId { get; set; }//representa a chave estranjeira do cliente 

        public DateTime DataPedido { get; set; } = DateTime.Now;//pega o horário que efetuou, sem precisar fazer no back

        public decimal  Total { get; set; }


        //propriedades de navegação, referência entre entidades, possui o tipo da classe 
        //objto cliente
        public Cliente? Cliente { get; set; }//populada com o que tem os dados do cliente 

        //criando colection
        public ICollection <ItemPedido> Itens { get; set; } = new List<ItemPedido>();
        //estou criando uma coleção de pedido                  esse é o item dentro da coleção

        //juntando linq e langda 
        //for sem precisar do for ou seja percorrer os itens 
        public void RecalcularTotal() 
        {
            Total = Itens.Sum(item => item.Quantidade * item.PrecoUnitario);//não precisa falar a tipagem da variável, objeto singular da lista que está acessando 
            //                cada item que eu acessar ele percorre o próximo item
        
        }

    }






}
