using System;

using Xamarin.Forms;

namespace ToastDemo
{
	public class App : Application
	{
		Button toastButtonLong = new Button();
		Button toastButtonShort = new Button();
		Entry entry = new Entry();

		public App()
		{
			toastButtonLong.Text = "Show long toast message";
			toastButtonLong.Clicked += ToastButtonLongClicked;

			toastButtonShort.Text = "Show short toast message";
			toastButtonShort.Clicked += ToastButtonShortClicked; ;

			entry.Placeholder = "text for toast message";
			entry.HorizontalOptions = LayoutOptions.Center;

			var content = new ContentPage
			{
				Title = "Toast Demo",
				Content = new StackLayout
				{
					VerticalOptions = LayoutOptions.Start,
					Margin = 10.0,
					Children = {
						entry, toastButtonLong, toastButtonShort
					}
				}
			};

			MainPage = new NavigationPage(content);
		}

		string GetMessage()
		{
			var message = entry.Text;
			if (string.IsNullOrEmpty(message))
			{
				message = entry.Placeholder;
			}
			return message;
		}

		void ToastButtonLongClicked(object sender, EventArgs e)
		{
			XFToast.LongMessage(GetMessage());
		}

		void ToastButtonShortClicked(object sender, EventArgs e)
		{
			XFToast.ShortMessage(GetMessage());
		}
	}
}
