using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FocusKeyboardTest
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void UserFocusedEntry_Focused(object sender, FocusEventArgs e)
        {
            if(UserFocusedEntry.IsFocused)
            {
                UserFocusedEntry.Unfocus();
            }
            ProgramFocusedEntry.Focus();
        }

        private void UserFocusedEntryDatePicker_Focused(object sender, FocusEventArgs e)
        {
            if (UserFocusedEntryDatePicker.IsFocused)
            {
                UserFocusedEntryDatePicker.Unfocus();
            }
            ProgramFocusedDatePicker.Focus();
        }
    }
}
