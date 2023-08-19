using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WepAPICore.Model
{
    public class User
    {
            [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            public string Description { get; set; }
            public string Date { get; set; }
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public string EmailId { get; set; }


    }
}
