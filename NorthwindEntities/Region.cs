using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwindEntities
{
    [Table("Regions")]
    public class Region
    {
        [Key]
        public int RegionId { get; set; }
        public string RegionDescription { get; set; }
    }
}
