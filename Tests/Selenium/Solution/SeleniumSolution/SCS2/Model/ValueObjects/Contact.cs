namespace Six.Scs.QA.Application.Model.ValueObjects
{
    /// <summary>
    ///     defines the ways and media how to contact
    /// </summary>
    public class Contact
    {
        public string Language { set; get; }
        public string Telephone { set; get; }
        public string Mobile { set; get; }
        public string Fax { set; get; }
        public string Email { set; get; }
        public string Web { get; set; }
    }
}