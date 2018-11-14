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
    /// Interaction logic for PlanningItemControl.xaml
    /// </summary>
    public partial class PlanningItemControl : UserControl
    {
        public PlanningItemControl()
        {
            InitializeComponent();
        }


        /// <summary>
        /// The planning item
        /// </summary>
        public PlanningItem PlanningItem
        {
            get { return (PlanningItem)GetValue(PlanningItemProperty); }
            set { SetValue(PlanningItemProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PlanningItem.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlanningItemProperty =
            DependencyProperty.Register("PlanningItem", typeof(PlanningItem), typeof(PlanningItemControl), new PropertyMetadata(default(PlanningItem)));

        /// <summary>
        /// Initiate drag drop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlanningItemView_MouseMove(object sender, MouseEventArgs e)
        {
            PlanningItemControl control = sender as PlanningItemControl;
            if (control != null && e.LeftButton == MouseButtonState.Pressed)
            {
                DragDrop.DoDragDrop(control, control.PlanningItem, DragDropEffects.Copy);
            }
            
        }
    }
}
