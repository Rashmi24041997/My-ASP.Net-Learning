namespace NotesAPI.Models.Entities
{
    public class Note
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string Descrpn { get; set; }
        public bool IsVisible { get; set; }
    }
}
