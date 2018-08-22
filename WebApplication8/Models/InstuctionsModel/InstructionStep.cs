using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8.Models.Instuctions
{
    public class InstructionStep
    {
        public int Id { get; set; }
        public string TitleStep { get; set; }
        public string Text { get; set; }

        public string InstuctionId { get; set; }
        public Instruction Instruction { get; set; }
    }
}
