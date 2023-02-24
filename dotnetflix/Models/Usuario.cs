namespace dotnetflix.Models
{
    public class Usuario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public int TempoExperiencia { get; set; }
        public List<Tutorial> MeusFavoritos { get; set; }
        public string LinkFotoPerfil { get; set; }

    }
}
