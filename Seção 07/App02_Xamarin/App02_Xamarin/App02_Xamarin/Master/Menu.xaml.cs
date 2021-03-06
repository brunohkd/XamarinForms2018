﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_Xamarin.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : MasterDetailPage
	{
		public Menu ()
		{
			InitializeComponent ();
		}

        private void GoPaginaPerfil1(object sender, EventArgs args)
        {
            try
            {
               Detail = new NavigationPage(new Pages.Perfil1());
            } catch (Exception e)
            {
                DisplayAlert("ERRO", e.Message, "OK");
            }
        }

        private void GoPaginaXamarin(object sender, EventArgs args)
        {
            try
            {
               Detail = new NavigationPage(new Pages.Xamarin());
            } catch (Exception e)
            {
                DisplayAlert("ERRO", e.Message, "OK");
            }
        }
    }
}