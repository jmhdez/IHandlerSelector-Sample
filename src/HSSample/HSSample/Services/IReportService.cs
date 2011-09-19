using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HSSample.Services
{
    public interface IReportService
    {
        void GenerateReport(string currentUser);
    }
}
