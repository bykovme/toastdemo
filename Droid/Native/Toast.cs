using Android.Widget;
using Android.App;
using ToastDemo.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(MessageAndroid))]
namespace ToastDemo.Droid
{
	public class MessageAndroid : IMessage
	{
		public void LongAlert(string message)
		{
			Toast.MakeText(Application.Context, message, ToastLength.Long).Show();
		}

		public void ShortAlert(string message)
		{
			Toast.MakeText(Application.Context, message, ToastLength.Short).Show();
		}
	}
}