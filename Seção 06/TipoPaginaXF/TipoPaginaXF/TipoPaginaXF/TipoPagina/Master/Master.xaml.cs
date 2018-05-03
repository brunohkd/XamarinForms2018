using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TipoPaginaXF.TipoPagina.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        private void MudarPagina1 (object senders, EventArgs args)
        {
            Detail = new Navigation.Pagina1();
        }

        private void MudarPagina2 (object senders, EventArgs args)
        {
            Detail = new Navigation.Pagina2();
        }

        private void MudarPaginaConteudo (object senders, EventArgs args)
        {
            Detail = new NavigationPage(new TipoPagina.Master.Conteudo());
        }
	}
}