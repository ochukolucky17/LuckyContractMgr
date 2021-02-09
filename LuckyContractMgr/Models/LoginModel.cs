using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyContractMgr.Models
{
    public class LoginModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string Telephone { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class LoginViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
