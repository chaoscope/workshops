﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Todo
{
	public partial class TodoDetailPage : ContentPage
	{
		public TodoDetailPage (TodoItem item)
		{
			BindingContext = item;

			InitializeComponent ();
		}
	}
}