namespace SMC_back.Entities
{
    public class Staff  
    {
        public int StaffID { get; set; }
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Description { get; set; }
        public Person Person { get; set; }

    }
}
