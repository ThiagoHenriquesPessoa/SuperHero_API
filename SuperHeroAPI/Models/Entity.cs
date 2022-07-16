namespace SuperHeroAPI.Models
{
    public class Entity
    {
        public int Id { get; set; }

        public Entity()
        {
            var idRandom = new Random();
            Id = idRandom.Next();
        }
    }
}