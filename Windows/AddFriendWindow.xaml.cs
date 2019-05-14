﻿using MISMC.ViewModel;
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
using System.Windows.Shapes;

namespace MISMC.Windows
{
    /// <summary>
    /// AddFriendWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AddFriendWindow : Window
    {
        public AddFriendWindow()
        {
            InitializeComponent();
            this.DataContext = AddFriendViewModel.CreateInstance();
        }
    }
}
