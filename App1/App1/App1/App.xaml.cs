﻿using System;

using App1.Views;
using App1.Services;
using Xamarin.Forms;

namespace App1
{
	public partial class App : Application
	{
		public static bool UseMockDataStore = true;
		public static string AzureMobileAppUrl = "https://[CONFIGURE-THIS-URL].azurewebsites.net";

		public App ()
		{
			InitializeComponent();

			if (UseMockDataStore)
				DependencyService.Register<MockDataStore>();
			else
				DependencyService.Register<AzureDataStore>();

            MainPage = new MainPage();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
