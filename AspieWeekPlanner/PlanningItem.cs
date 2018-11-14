using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspieWeekPlanner
{
    /// <summary>
    /// A planning item
    /// </summary>
    public class PlanningItem
    {
        /// <summary>
        /// How much energy does the task cost to perform
        /// </summary>
        public PlanningWeight Weight { get; set; }

        /// <summary>
        /// The description
        /// </summary>
        public string Description { get; set; }
    }
}
