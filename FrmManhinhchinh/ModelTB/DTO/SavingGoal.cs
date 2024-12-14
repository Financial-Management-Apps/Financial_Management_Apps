using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmManhinhchinh.ModelTB.DTO
{
    public class SavingGoal
    {
        public int GoalId { get; set; } 
        public int UserId { get; set; } 
        public string GoalName { get; set; }
        public decimal TargetAmount { get; set; } 
        public decimal CurrentAmount { get; set; } 
        public DateTime DueDate { get; set; }
    }
}
