using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace HappyOffice
{
    public sealed partial class MainPage : Page
    {
        private async void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            var todoItem = new Point { Username = TextInput.Text };
            await InsertTodoItem(todoItem);
        }
    }

}
