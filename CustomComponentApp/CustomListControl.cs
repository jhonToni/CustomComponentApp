// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace CustomComponentApp
{

    //public class HelloItemCollection: ObservableCollection<HelloItem> {

    //    CustomListControl _control;


    //    public HelloItemCollection(CustomListControl control)
    //    {
    //        _control = control;
    //    }


       
    //    protected override void InsertItem(int index, HelloItem item)
    //    {




    //        base.InsertItem(index, item);
    //    }



    //    protected override void RemoveItem(int index)
    //    {
    //        base.RemoveItem(index);
    //    }


    //    protected override void MoveItem(int oldIndex, int newIndex)
    //    {
    //        base.MoveItem(oldIndex, newIndex);
    //    }


    //    protected override void SetItem(int index, HelloItem item)
    //    {
    //        base.SetItem(index, item);
    //    }


       

    //}

    public class HelloItem : DependencyObject
    {

    }
 
    public sealed class CustomListControl : Control
    {
        private ObservableCollection<HelloItem> _items;

        public CustomListControl()
        {
            this.DefaultStyleKey = typeof(CustomListControl);
            _items = new ObservableCollection<HelloItem>();
            _items.CollectionChanged += (o, args) => {

                
                Debug.WriteLine("collection changed");
            };

        }



        public ObservableCollection<HelloItem> Items {
            get {
                return _items; 
            } 
        
        }



    }
}
