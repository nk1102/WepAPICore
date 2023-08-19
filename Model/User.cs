using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WepAPICore.Model
{
    public class User
    {
            [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int CaseId { get; set; }
            public string CaseDescription { get; set; }
            public string CaseDate { get; set; }
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public string EmailId { get; set; }


    }
}
