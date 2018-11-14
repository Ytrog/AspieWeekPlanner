using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AspieWeekPlanner
{
    /// <summary>
    /// Interaction logic for DropSurface.xaml
    /// </summary>
    public partial class DropSurface : UserControl
    {
        public DropSurface()
        {
            InitializeComponent();
        }


        /// <summary>
        /// The max weight that can be dropped on this surface
        /// </summary>
        public PlanningWeight MaxPlanningWeight
        {
            get { return (PlanningWeight)GetValue(MaxPlanningWeightProperty); }
            set { SetValue(MaxPlanningWeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MaxPlanningWeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaxPlanningWeightProperty =
            DependencyProperty.Register("MaxPlanningWeight", typeof(PlanningWeight), typeof(DropSurface), new PropertyMetadata(PlanningWeight.Heavy));


        /// <summary>
        /// How much weight is already allocated
        /// </summary>
        public PlanningWeight TotalPlanningWeight { get; set; }

        /// <summary>
        /// The allocated planning items
        /// </summary>
        public List<PlanningItem> Items { get; set; }

        /// <summary>
        /// Handle the drop event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StackPanel_Drop(object sender, DragEventArgs e)
        {
            
        }
    }
}
