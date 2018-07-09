using Syncfusion.SfNavigationDrawer.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChartSample
{
    public partial class MainPage : ContentPage
    {
        public SfNavigationDrawer Drawer
        {
			get;
			set;
        }

        public MainPage()
        {
            InitializeComponent();
            
            Drawer = new SfNavigationDrawer()
            {
                DrawerWidth = 400
			};
        }
    }
}