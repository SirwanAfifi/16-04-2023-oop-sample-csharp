using System.Text;

namespace Abstract 
{
    public class ReportGeneratorService
    {
        public string GenerateReport(List<Pet> pets)
        {
            var report = new StringBuilder();
            report.AppendLine("Type, Name,Date Joined Practice,Number Of Visits,Number of Lives");
            foreach (var pet in pets)
            {
                report.AppendLine(pet.Format());
            }
            return report.ToString();
        }
    }
}