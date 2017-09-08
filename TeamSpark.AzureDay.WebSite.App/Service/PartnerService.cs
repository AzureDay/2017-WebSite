using System;
using System.Collections.Generic;
using System.Linq;
using TeamSpark.AzureDay.WebSite.App.Entity;
using TeamSpark.AzureDay.WebSite.Data.Enum;

namespace TeamSpark.AzureDay.WebSite.App.Service
{
	public sealed class PartnerService
	{
		private readonly List<Partner> _partners;

		public PartnerService()
		{
			_partners = new List<Partner>
			{
				new Partner
				{
					Id = "DataArt",
					Title = Localization.App.Service.Partners.DataArt.Title,
					Description = Localization.App.Service.Partners.DataArt.Description.Replace(Environment.NewLine, "<br/>"),
					LogoUrl = "https://azureday2017ua.blob.core.windows.net/images/logos/DA-logo-color-rgb.jpg",
					WebUrl = "http://dataart.ua",
					PartnerType = PartnerType.Info | PartnerType.Workshop
				},
				new Partner
				{
					Id = "Ciklum",
					Title = Localization.App.Service.Partners.Ciklum.Title,
					Description = Localization.App.Service.Partners.Ciklum.Description.Replace(Environment.NewLine, "<br/>"),
					LogoUrl = "https://azureday2017ua.blob.core.windows.net/images/logos/ciklum02.JPG",
					WebUrl = "https://www.ciklum.com",
					PartnerType = PartnerType.Info | PartnerType.Workshop | PartnerType.Bronze
				},
				new Partner
				{
					Id = "ITStep",
					Title = Localization.App.Service.Partners.ITStep.Title,
					Description = Localization.App.Service.Partners.ITStep.Description.Replace(Environment.NewLine, "<br/>"),
					LogoUrl = "https://azureday2017ua.blob.core.windows.net/images/logos/itstep02.JPG",
					WebUrl = "http://itstep.org/ua/",
					PartnerType = PartnerType.Info | PartnerType.Workshop
				},
				new Partner
				{
					Id = "Daxx",
					Title = Localization.App.Service.Partners.Daxx.Title,
					Description = Localization.App.Service.Partners.Daxx.Description.Replace(Environment.NewLine, "<br/>"),
					LogoUrl = "https://azureday2017ua.blob.core.windows.net/images/logos/daxx.jpg",
					WebUrl = "http://www.daxx.com",
					PartnerType = PartnerType.Info
				},
				new Partner
				{
					Id = "Microsoft",
					Title = Localization.App.Service.Partners.Microsoft.Title,
					Description = Localization.App.Service.Partners.Microsoft.Description.Replace(Environment.NewLine, "<br/>"),
					LogoUrl = "https://azureday2017ua.blob.core.windows.net/images/logos/microsoft.jpg",
					WebUrl = "https://www.microsoft.com/uk-ua/",
					PartnerType = PartnerType.Info | PartnerType.Gold | PartnerType.Workshop
				},
				new Partner
				{
					Id = "EasyPay",
					Title = Localization.App.Service.Partners.EasyPay.Title,
					Description = Localization.App.Service.Partners.EasyPay.Description.Replace(Environment.NewLine, "<br/>"),
					LogoUrl = "https://azureday2017ua.blob.core.windows.net/images/logos/easypay.jpg",
					WebUrl = "https://easypay.ua/",
					PartnerType = PartnerType.Info | PartnerType.Speaker
				},
				new Partner
				{
					Id = "ITEA",
					Title = Localization.App.Service.Partners.ITEA.Title,
					Description = Localization.App.Service.Partners.ITEA.Description.Replace(Environment.NewLine, "<br/>"),
					LogoUrl = "https://azureday2017ua.blob.core.windows.net/images/logos/ITEA.jpg",
					WebUrl = "http://itea.ua/",
					PartnerType = PartnerType.Info
				},
				new Partner
				{
					Id = "EPAM",
					Title = Localization.App.Service.Partners.EPAM.Title,
					Description = Localization.App.Service.Partners.EPAM.Description.Replace(Environment.NewLine, "<br/>"),
					LogoUrl = "https://azureday2017ua.blob.core.windows.net/images/logos/epam_logo.png",
					WebUrl = "https://www.epam.com/careers",
					PartnerType = PartnerType.Gold
				},
				new Partner
				{
					Id = "XamarinUA",
					Title = Localization.App.Service.Partners.XamarinUA.Title,
					Description = Localization.App.Service.Partners.XamarinUA.Description.Replace(Environment.NewLine, "<br/>"),
					LogoUrl = "https://azureday2017ua.blob.core.windows.net/images/logos/XamarinUA.png",
					WebUrl = "https://www.facebook.com/groups/xamarin.ua/",
					PartnerType = PartnerType.Info
				},
				new Partner
				{
					Id = "dotNetCore",
					Title = Localization.App.Service.Partners.dotNetCore.Title,
					Description = Localization.App.Service.Partners.dotNetCore.Description.Replace(Environment.NewLine, "<br/>"),
					LogoUrl = "https://azureday2017ua.blob.core.windows.net/images/logos/dotNetCore.jpg",
					WebUrl = "http://dot-net.in.ua/",
					PartnerType = PartnerType.Info
				},
				new Partner
				{
					Id = "AzureUA",
					Title = Localization.App.Service.Partners.AzureUA.Title,
					Description = Localization.App.Service.Partners.AzureUA.Description.Replace(Environment.NewLine, "<br/>"),
					LogoUrl = "https://azureday2017ua.blob.core.windows.net/images/logos/AzureUA.png",
					WebUrl = "https://www.facebook.com/groups/azure.ua/",
					PartnerType = PartnerType.Info
				},
				new Partner
				{
					Id = "Yakaboo",
					Title = Localization.App.Service.Partners.Yakaboo.Title,
					Description = Localization.App.Service.Partners.Yakaboo.Description.Replace(Environment.NewLine, "<br/>"),
					LogoUrl = "https://azureday2017ua.blob.core.windows.net/images/logos/yakaboo.jpg",
					WebUrl = "http://www.yakaboo.ua/",
					PartnerType = PartnerType.Info
				},
				new Partner
				{
					Id = "Devart",
					Title = Localization.App.Service.Partners.DevArt.Title,
					Description = Localization.App.Service.Partners.DevArt.Description.Replace(Environment.NewLine, "<br/>"),
					LogoUrl = "https://azureday2017ua.blob.core.windows.net/images/logos/devart.png",
					WebUrl = "https://www.devart.com/",
					PartnerType = PartnerType.Info
				},
				new Partner
				{
					Id = "OReilly",
					Title = Localization.App.Service.Partners.OReilly.Title,
					Description = Localization.App.Service.Partners.OReilly.Description.Replace(Environment.NewLine, "<br/>"),
					LogoUrl = "https://azureday2017ua.blob.core.windows.net/images/logos/ORM.jpg",
					WebUrl = "oreilly.com",
					PartnerType = PartnerType.Raffle
				},
				new Partner
				{
					Id = "EnglishDom",
					Title = Localization.App.Service.Partners.EnglishDom.Title,
					Description = Localization.App.Service.Partners.EnglishDom.Description.Replace(Environment.NewLine, "<br/>"),
					LogoUrl = "https://azureday2017ua.blob.core.windows.net/images/logos/ED.png",
					WebUrl = "https://www.englishdom.com/",
					PartnerType = PartnerType.Info
				},
				new Partner
				{
					Id = "CloudMonix",
					Title = Localization.App.Service.Partners.CloudMonix.Title,
					Description = Localization.App.Service.Partners.CloudMonix.Description.Replace(Environment.NewLine, "<br/>"),
					LogoUrl = "https://azureday2017ua.blob.core.windows.net/images/logos/CM.png",
					WebUrl = "http://www.cloudmonix.com/",
					PartnerType = PartnerType.Raffle
				},
				new Partner
				{
					Id = "Jetbrains",
					Title = Localization.App.Service.Partners.Jetbrains.Title,
					Description = Localization.App.Service.Partners.Jetbrains.Description.Replace(Environment.NewLine, "<br/>"),
					LogoUrl = "https://azureday2017ua.blob.core.windows.net/images/logos/jetbrains.jpg",
					WebUrl = "https://www.jetbrains.com/",
					PartnerType = PartnerType.Raffle
				},
				new Partner
				{
					Id = "Trudua",
					Title = Localization.App.Service.Partners.Trudua.Title,
					Description = Localization.App.Service.Partners.Trudua.Description.Replace(Environment.NewLine, "<br/>"),
					LogoUrl = "https://azureday2017ua.blob.core.windows.net/images/logos/trud_ua.png",
					WebUrl = "http://kiev.trud.com/",
					PartnerType = PartnerType.Info
				},
				new Partner
				{
					Id = "Developex",
					Title = Localization.App.Service.Partners.Developex.Title,
					Description = Localization.App.Service.Partners.Developex.Description.Replace(Environment.NewLine, "<br/>"),
					LogoUrl = "https://azureday2017ua.blob.core.windows.net/images/logos/developex_logo.png",
					WebUrl = "http://developex.com/",
					PartnerType = PartnerType.Info | PartnerType.Workshop
				},
				new Partner
				{
					Id = "Dbbest",
					Title = Localization.App.Service.Partners.Dbbest.Title,
					Description = Localization.App.Service.Partners.Dbbest.Description.Replace(Environment.NewLine, "<br/>"),
					LogoUrl = "https://azureday2017ua.blob.core.windows.net/images/logos/dbbest.png",
					WebUrl = "https://www.dbbest.com/",
					PartnerType = PartnerType.Info | PartnerType.Workshop
				},
				new Partner
				{
					Id = "Global Logic",
					Title = Localization.App.Service.Partners.GL.Title,
					Description = Localization.App.Service.Partners.GL.Description.Replace(Environment.NewLine, "<br/>"),
					LogoUrl = "https://azureday2017ua.blob.core.windows.net/images/logos/gl.png",
					WebUrl = "https://www.globallogic.com",
					PartnerType = PartnerType.Info | PartnerType.Workshop
				}
			};
		}

		public IEnumerable<Partner> GetPartners()
		{
			return _partners
				.OrderBy(x => x.Id);
		}

		public IEnumerable<Partner> GetPartnersByType(PartnerType partnerType)
		{
			return _partners
				.Where(x => x.PartnerType.HasFlag(partnerType))
				.OrderBy(x => x.Id);
		}

		public Partner DataArt { get { return _partners.Single(x => x.Id == "DataArt"); } }
		public Partner Ciklum { get { return _partners.Single(x => x.Id == "Ciklum"); } }
		public Partner ITStep { get { return _partners.Single(x => x.Id == "ITStep"); } }
	}
}
