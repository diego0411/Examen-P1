using System.Data.Entity;

namespace Evaluacion_Ray.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }
    }
}