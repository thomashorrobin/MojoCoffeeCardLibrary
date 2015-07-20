using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojoCoffeeCardLibrary
{
    public abstract class Card
    {
        public Card() { }

        public abstract string CardId { get; set; }

        public abstract DateTime CardIssueDate { get; set; }

        public abstract bool CardValid { get; set; }
    }
}
