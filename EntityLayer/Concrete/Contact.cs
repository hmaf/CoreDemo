using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int CotractId { get; set; }
        public string ContractUserName { get; set; }
        public string ContractMail { get; set; }
        public string ContractSubject { get; set; }
        public string ContractMessage { get; set; }
        public DateTime ContractDate { get; set; }
        public bool ContractStatus { get; set; }
    }
}
