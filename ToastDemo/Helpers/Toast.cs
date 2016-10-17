using System;
using Xamarin.Forms;

namespace ToastDemo
{
	public static class XFToast
	{
		public static void ShortMessage(string message)
		{
			DependencyService.Get<IMessage>().ShortAlert(message);
		}

		public static void LongMessage(string message)
		{
			DependencyService.Get<IMessage>().LongAlert(message);
		}
	}
}
