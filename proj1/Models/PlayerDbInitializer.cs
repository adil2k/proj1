using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proj1.Models
{
    public class PlayerDbInitializer : DropCreateDatabaseAlways<PlayerContext>
    {
        protected override void Seed(PlayerContext db)
        {
            db.Players.Add(new Player { Name = "Messi", Team = "Barcelona", Price = 220 });
            db.Players.Add(new Player { Name = "Lewandowski", Team = "Bayern Munchen", Price = 180 });
            db.Players.Add(new Player { Name = "Чайка", Team = "А. Чехов", Price = 150 });

            base.Seed(db);
        }
    }
}
