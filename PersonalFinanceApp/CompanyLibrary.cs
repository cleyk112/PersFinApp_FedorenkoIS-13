namespace PersonalFinanceApp
{
    public class CompanyLibrary
    {
        public List<Company> companies { get; set; }

        public CompanyLibrary()
        {
            companies = new List<Company>();
        }

        public void AddAccountToRepository(string _name)
        {
            companies?.Add(new Company(_name));
        }

        public void AddAccountToRepository(Company comp)
        {
            companies?.Add(comp);
        }

        public void RemoveAccountFromRepository(Company comp)
        {
            companies?.Remove(comp);
        }
    }
}
