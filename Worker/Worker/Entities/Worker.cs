using Course.Entities.Enums;


namespace Course.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public WorkerLevel Level { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; }

        public Worker(string name, double baseSalary, WorkerLevel level, Departament departament)
        {
            Name = name;
            BaseSalary = baseSalary;
            Level = level;
            Departament = departament;
            Contracts = new List<HourContract>();
        }
        public void AddContract(HourContract contracts)
        {
            Contracts.Add(contracts);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.totalValue();
                }
            }
            return sum;
        }
    }
}
