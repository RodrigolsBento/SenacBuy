namespace SenacBuy.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;//recebe valor default, 
        public string Email { get; set; } = string.Empty;
        public string SenhaHash { get; set; } = string.Empty; //vai ter criptografia, questão da LGPD
        public string? FotoPerfil { get; set; } //pode ser nulo, o usuário pode não ter foto de perfil

    }
}
