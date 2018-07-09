using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Common;

namespace BlurryZXing
{
	public partial class MainPage : ContentPage
	{
		public EncodingOptions BarcodeOptions => new EncodingOptions() { Height = 300, Width = 300, PureBarcode = true };

		public MainPage()
		{
			InitializeComponent();
		}
	}
}
