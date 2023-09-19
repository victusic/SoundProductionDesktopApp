﻿using SpDesktop.Entities;
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

namespace SpDesktop.Pages.AdministratorsPages.InPages
{
    /// <summary>
    /// Логика взаимодействия для GroupView.xaml
    /// </summary>
    public partial class GroupView : Page
    {
        private Group _currentGroups = new Group();
        public GroupView(Group selectedGroup)
        {
            InitializeComponent();

            if (selectedGroup != null)
            {
                _currentGroups = selectedGroup;
            }

            DataContext = _currentGroups;
        }

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scv = (ScrollViewer)sender;
            scv.ScrollToVerticalOffset(scv.VerticalOffset - e.Delta / 3);
            e.Handled = true;
        }
    }
}
