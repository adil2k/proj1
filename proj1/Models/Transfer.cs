using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proj1.Models
{
    public class Transfer
    {
        public int TransferId { get; set; }  // ID трансфера

        public string TransferTeam { get; set; }  // команда покупатель

        public int PlayerId { get; set; }  // ID игрока

        public DateTime Date { get; set; }  // дата покупки
    }
}
