using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proj1.Models
{
    public class Player
    {
        public int Id { get; set; }  // ID игрока
  
        public string Name { get; set; }  // имя игрока
        
        public string Team { get; set; }  // команда игрока
        
        public int Price { get; set; }  // трансферная цена игрока
    }
}
