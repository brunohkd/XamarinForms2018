using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutXF
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

		}

        private void GoPaginaStack(object sender, EventArgs args)
        {
            Navigation.PushAsync(new LayoutXF.Layouts.Stack.StackPage());
        }

        private void GoPaginaGrid(object sender, EventArgs args)
        {
            Navigation.PushAsync(new LayoutXF.Layouts.Grid.GridPage());
        }

        private void GoPaginaAbsolute(object sender, EventArgs args)
        {
            Navigation.PushAsync(new LayoutXF.Layouts.Absolute.AbsolutePage());
        }

        private void GoPaginaRelative(object sender, EventArgs args)
        {
            try
            {
                Navigation.PushAsync(new LayoutXF.Layouts.Relative.RelativePage());
            } catch (Exception e)
            {
                DisplayAlert("Error", e.Message, "OK");
            }
        }

        private void GoPaginaScroll(object sender, EventArgs args)
        {
            Navigation.PushAsync(new LayoutXF.Layouts.Scroll.ScrollPage());
        }
    }
}
