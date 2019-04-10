using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hello_world
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HamMenu : MasterDetailPage
    {
        public HamMenu()
        {
            InitializeComponent();
            Detail = new NavigationPage(new AbsoluteLayoutEx1());
            List<Menu> menu = new List<Menu>
            {
                new Menu { Page = new AbsoluteLayoutEx1(), MenuTitle = "Absolute Layout ex 1", MenuDetail = "Example 1 Absolut layout" },
                new Menu { Page = new AbsoluteLayoutEx2(), MenuTitle = "Absolute Layout ex 2", MenuDetail = "Example 2 Absolut layout" },
                new Menu { Page = new GreetPage(), MenuTitle = "stack Layout greet", MenuDetail = "Simple greet page" },
                new Menu { Page = new GridPage(), MenuTitle = "Grid Layout ex", MenuDetail = "Simple grid page" },
                new Menu { Page = new GridPageDialer(), MenuTitle = "Grid Layout dialer ex", MenuDetail = "Simple grid dialer page" },
                new Menu { Page = new GridPageLogin(), MenuTitle = "Grid Layout login ex", MenuDetail = "Simple grid login page" },
                new Menu { Page = new ImageCirclePage(), MenuTitle = "Image circle ex", MenuDetail = "Simple image circle page" },
                new Menu { Page = new ImageExercise(), MenuTitle = "Image excersice ", MenuDetail = "Simple image excercise" },
                new Menu { Page = new ImagePage(), MenuTitle = "Image page excersice ", MenuDetail = "Simple image page excercise" },
                new Menu { Page = new ListExercisePage(), MenuTitle = "List page excersice ", MenuDetail = "Simple list page excercise" },
                new Menu { Page = new RelativeLayoutEx1(), MenuTitle = "Relative layout ", MenuDetail = "Simple Relative layout  excercise" },
                new Menu { Page = new StackLayoutEx1Page(), MenuTitle = "Stack layout ", MenuDetail = "Simple stack layout  excercise" },
                new Menu { Page = new StackLayoutEx2(), MenuTitle = "Stack layout ex 2", MenuDetail = "Stack layout  ex 2 excercise" },
                new Menu { Page = new StackPage(), MenuTitle = "Stack Page ex 2", MenuDetail = "Stack layout  ex 2 excercise" },
            };

            ListMenu.ItemsSource = menu;
        }

        public  void MyMenu()
        {
  

        }

        private void ListMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var menu = e.SelectedItem as Menu;
            if(menu != null)
            {
                IsPresented = false;
                Detail = new NavigationPage(menu.Page);
            }
        }
    }
    public class Menu
    {
        public string MenuTitle { get; set; }

        public string MenuDetail { get; set; }
        public ImageSource Image { get; set; }
        public Page Page { get; set; }
    }
}