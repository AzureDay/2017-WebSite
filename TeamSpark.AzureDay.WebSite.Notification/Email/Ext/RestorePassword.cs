﻿using TeamSpark.AzureDay.WebSite.Config;

namespace TeamSpark.AzureDay.WebSite.Notification.Email.Template
{
	public partial class RestorePassword
	{
		public string Year => Configuration.Year;
		public string Host => Configuration.Host;
		public string ConfirmationCode { get; set; }
	}
}
