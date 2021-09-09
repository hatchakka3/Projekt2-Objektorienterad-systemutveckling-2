namespace BusinessEntities
{
    public interface IPerson
    {
        string Email { get; set; }
        string Name { get; set; }
        string Password { get; set; }
        string SocialSecurityNumber { get; set; }
        string Username { get; set; }
    }
}