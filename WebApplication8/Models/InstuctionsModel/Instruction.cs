using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models.CommentsModel;

namespace WebApplication8.Models.Instuctions
{
    public class Instruction
    {
        public int InstructionId { get; set; }
        
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public string Name { get; set; }
       
        public string Decription { get; set; }
       
        public ICollection<InstructionStep> instructionSteps { get; set; }

        public DateTime EnrollmentDate { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
