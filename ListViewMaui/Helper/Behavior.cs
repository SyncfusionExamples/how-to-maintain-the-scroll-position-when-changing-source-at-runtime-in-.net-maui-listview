using Syncfusion.Maui.ListView;
using Syncfusion.Maui.ListView.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewMaui
{
    #region Behavior
    internal class Behavior : Behavior<ContentPage>
    {
        #region Fields

        SfListView ListView;
        Button UpdateButton;
        ListViewScrollView ScrollView;
        #endregion

        #region Overrides

        protected override void OnAttachedTo(ContentPage bindable)
        {
            ListView = bindable.FindByName<SfListView>("listView");
            UpdateButton = bindable.FindByName<Button>("updateButton");

            UpdateButton.Clicked += UpdateButton_Clicked;

            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            UpdateButton.Clicked -= UpdateButton_Clicked;
            UpdateButton = null;
            ListView = null;
            base.OnDetachingFrom(bindable);
        }
        #endregion

        #region Callback

        private void UpdateButton_Clicked(object sender, EventArgs e)
        {
            var viewModel = ListView.BindingContext as ContactsViewModel;
            viewModel.GenerateInfo();
            ListView.ItemsSource = viewModel.ContactsInfo;
        }

        #endregion
    }

    #endregion
}
