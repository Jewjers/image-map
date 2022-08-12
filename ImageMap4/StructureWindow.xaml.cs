﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace ImageMap4;
/// <summary>
/// Interaction logic for StructureWindow.xaml
/// </summary>
public partial class StructureWindow : Window
{
    public StructureViewModel ViewModel => (StructureViewModel)DataContext;
    public StructureWindow()
    {
        InitializeComponent();
        ViewModel.PropertyChanged += ViewModel_PropertyChanged;
    }

    private void ViewModel_PropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(StructureViewModel.Grid))
            UpdateGrid();
    }

    private void UpdateGrid()
    {
        StructureGrid.SplitGrid.Children.Clear();
        for (int y = 0; y < ViewModel.GridHeight; y++)
        {
            for (int x = 0; x < ViewModel.GridWidth; x++)
            {
                if (ViewModel.Grid[x, y] != null)
                {
                    var item = new Image { Source = ViewModel.Grid[x, y].Data.ImageSource };
                    Grid.SetColumn(item, x);
                    Grid.SetRow(item, y);
                    StructureGrid.SplitGrid.Children.Add(item);
                }
            }
        }
    }
}
