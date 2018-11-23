﻿using System;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlanningItemControl_MouseMove(object sender, MouseEventArgs e)
        {
            PlanningItemControl control = sender as PlanningItemControl;

            if (control != null && e.LeftButton == MouseButtonState.Pressed)
            {
                DragDrop.DoDragDrop(control, control.PlanningItem, DragDropEffects.Copy);
            }
        }

        /// <summary>
        /// Drop a heavy task block onto a <see cref="DropSurface"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeavyTask_MouseMove(object sender, MouseEventArgs e)
        {
            TemplateDragDrop(sender, e, PlanningWeight.Heavy);
        }

        private static void TemplateDragDrop(object sender, MouseEventArgs e, PlanningWeight planningWeight)
        {
            Rectangle control = sender as Rectangle;

            if (MouseHelper.ValidateDragDrop(control, e))
            {
                DragDrop.DoDragDrop(control, planningWeight, DragDropEffects.Copy);
            }
        }

        /// <summary>
        /// Drop a medium task block onto a <see cref="DropSurface"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediumTask_MouseMove(object sender, MouseEventArgs e)
        {
            TemplateDragDrop(sender, e, PlanningWeight.Medium);
        }

        /// <summary>
        /// Drop a light task block onto a <see cref="DropSurface"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LightTask_MouseMove(object sender, MouseEventArgs e)
        {
            TemplateDragDrop(sender, e, PlanningWeight.Light);
        }
    }
}
