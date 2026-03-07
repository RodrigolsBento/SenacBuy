namespace SenacBuy.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }

        public string  Nome { get; set; } = string.Empty;
        public string  CPF { get; set; } = string.Empty;//se tiver calculo valor numérico, se não string 

        
        //cardinalidade
        public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();//é tipo: "meus pedidos"




    }
}
