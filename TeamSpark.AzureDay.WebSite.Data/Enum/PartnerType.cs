﻿namespace TeamSpark.AzureDay.WebSite.Data.Enum
{
	public enum PartnerType
	{
		VIP = 101,
		Gold = 201,
		Silver = 301,
		Raffle = 401,
		Info = 501,
		Speaker = 601,
		Tech = 701
	}

	public static class PartnerTypeExtension
	{
		public static string ToDisplayStringCategory(this PartnerType type)
		{
			switch (type)
			{
				case PartnerType.VIP:
					return "Генеральный партнер";
				case PartnerType.Gold:
					return "Золотые партнеры";
				case PartnerType.Silver:
					return "Серебряные партнеры";
				case PartnerType.Raffle:
					return "Партнеры по призам";
				case PartnerType.Info:
					return "Информационные партнеры";
				case PartnerType.Speaker:
					return "Партнеры по докладчикам";
				case PartnerType.Tech:
					return "Технические партнеры";
				default:
					return string.Empty;
			}
		}

		public static string ToDisplayStringPartner(this PartnerType type)
		{
			switch (type)
			{
				case PartnerType.VIP:
					return "Генеральный партнер";
				case PartnerType.Gold:
					return "Золотой партнер";
				case PartnerType.Silver:
					return "Серебряный партнер";
				case PartnerType.Raffle:
					return "Партнер по призам";
				case PartnerType.Info:
					return "Информационный партнер";
				case PartnerType.Speaker:
					return "Партнер по докладчикам";
				case PartnerType.Tech:
					return "Технический партнер";
				default:
					return string.Empty;
			}
		}
	}
}
