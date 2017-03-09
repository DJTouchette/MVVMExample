
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace Hello.Forms.ViewModels
{
	public class FeaturesViewModel : Screen
	{
		private string textChange = "hello";
		private int counter = 0;

		public string TextChange
		{
			get { return textChange; }
			set
			{
				textChange = value;
				NotifyOfPropertyChange(() => TextChange);
			}
		}

		public int Counter
		{
			get { return counter; }
			set
			{
				counter = value;
				NotifyOfPropertyChange(() => Counter);
			}
		}

		public void Increment()
		{
			Counter++;
		}

		public void ChangeText()
		{
			TextChange = "Look I changed man MVVM Power.";
		}


	}
}