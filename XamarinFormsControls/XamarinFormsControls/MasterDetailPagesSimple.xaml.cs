using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPagesSimple : MasterDetailPage
    {
        public MasterDetailPagesSimple()
        {
            InitializeComponent();
        }
    }
}