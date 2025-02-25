using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Szerveroldali_hazi1.Entities
{
    public class Duna_Vizallas
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public DateTime Date {  get; set; }
        public int Vaule { get; set; }
    }
}
