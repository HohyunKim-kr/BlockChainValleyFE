using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockChainValleyFE.Models
{
    public class MemberDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string TelegramHandle { get; set; }
        public string TwitterHandle { get; set; }
        public string WalletAddress { get; set; }
        public string Role { get; set; }
    }
}
