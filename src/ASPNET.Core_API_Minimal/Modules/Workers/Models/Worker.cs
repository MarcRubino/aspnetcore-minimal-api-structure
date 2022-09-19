namespace ASPNET.Core_API_Minimal.Modules.Workers.Models
{
    public class Worker
    {
        public int  Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime StartDate { get; set; }

    }
}
