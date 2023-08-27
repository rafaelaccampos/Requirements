namespace Requirements.Models
{
    public class SelfEmployed
    {
        public SelfEmployed(
            string name,
            string cpf, 
            string rg, 
            string fantasyName, 
            string occupation)
        {
            Name = name;
            Cpf = cpf;
            Rg = rg;
            FantasyName = fantasyName;
            Occupation = occupation;
        }

        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string? FantasyName { get; set; }
        public string Occupation { get; set; }
    }
}
