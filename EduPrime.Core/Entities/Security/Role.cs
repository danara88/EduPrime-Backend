namespace EduPrime.Core.Entities
{
    /// <summary>
    /// Role Entity
    /// </summary>
    public class Role : BaseEntity
    {
        public string Name { get; set; }

        public List<User> Users { get; set; }
    }
}
