
using NC.Public.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Data;

namespace NC.Public.Models
{
    //public class TabControlItem : BaseModel
    //{

    //    public String Id { get; set; }
    //    private string _TabHeader = "";
    //    public string TabHeader { get { return _TabHeader; } set { _TabHeader = value; OnPropertyChanged(nameof(TabHeader)); } }

    //    private UIElement _TabContent=new UIElement();
    //    public UIElement TabContent { get { return _TabContent; } set { _TabContent = value; OnPropertyChanged(nameof(TabContent)); } }

    //    private string _TabDateTime;
    //    public string TabDateTime { get { return _TabDateTime; } set { _TabDateTime = value; OnPropertyChanged(nameof(TabDateTime)); } }


    //    public TabControlItem()
    //    {
    //        TabDateTime = PersianDateTime.Now.ToString();
    //        Id = System.Guid.NewGuid().ToString();
           
    //    }

      
    //}





    //public class VMTabControlViewModel : BaseModel
    //{
    //    private Visibility _TabVisibility { get; set; } = Visibility.Collapsed;
    //    public Visibility TabVisibility
    //    {
    //        get { return _TabVisibility; }
    //        set { _TabVisibility = value; OnPropertyChanged("TabVisibility"); }

    //    }
    //    public List<TabControlItem> TabControlItems { get; set; }
    //    private ICollectionView _TabControlItemsView;
    //    public ICollectionView TabControlItemsView
    //    {
    //        get { return _TabControlItemsView; }
    //        set { _TabControlItemsView = value; 
              
    //            if(TabControlItems.Count > 0)
    //            {
    //                TabVisibility = Visibility.Visible;
    //            }
    //            else
    //            {
    //                TabVisibility = Visibility.Collapsed;
    //            }
    //              OnPropertyChanged("TabControlItemsView"); 
    //            OnPropertyChanged("VisibilityRelatedTabControl");
    //        }
    //    }

    //    public VMTabControlViewModel()
    //    {
    //        TabControlItems = new List<TabControlItem>();
    //        TabControlItemsView = CollectionViewSource.GetDefaultView(TabControlItems);

    //        // TabControlItemsView.CurrentChanged += TabControlItemsSelectionChanged;
    //    }
    //    public void TabControlItemsSelectionChanged(object sender, EventArgs e)
    //    {

    //    }


    //    public Visibility VisibilityRelatedTabControl
    //    {
    //        get
    //        {
    //            return TabControlItems.Count() < 1 ? Visibility.Collapsed : Visibility.Visible;

    //        }
    //    }


    //}
}
