using Minutes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Minutes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoteEntryEditPage : ContentPage
    {
        private NoteEntry entry;

        public NoteEntryEditPage(NoteEntry entry)
        {
            InitializeComponent();
            this.entry = entry;
        }
    }
}