﻿namespace Gu.Wpf.AutoRowGrid
{
    using System.Collections.ObjectModel;
    using System.Windows;

    public class Row : Collection<UIElement>, IRow
    {
        /// <summary><see cref="Name"/> is not used for anything but can perhaps be good for documentation.</summary>
        public string Name { get; set; }
    }
}