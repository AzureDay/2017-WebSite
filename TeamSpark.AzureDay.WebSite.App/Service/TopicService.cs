using System;
using System.Collections.Generic;
using System.Linq;
using TeamSpark.AzureDay.WebSite.App.Entity;

namespace TeamSpark.AzureDay.WebSite.App.Service
{
	public sealed class TopicService
	{
		private readonly LanguageService _languageService = new LanguageService();
		private readonly SpeakerService _speakerService = new SpeakerService();

		private readonly List<Topic> _topics;

		public TopicService()
		{
			_topics = new List<Topic>
			{
				new Topic
				{
					Id = -101,
					Title = Localization.App.Service.Topics.Food.Registration.Title
				},
				new Topic
				{
					Id = -102,
					Title = Localization.App.Service.Topics.Food.CoffeeBreak.Title
				},
				new Topic
				{
					Id = -103,
					Title = Localization.App.Service.Topics.Food.Lunch.Title
				},
				new Topic
				{
					Id = -104,
					Title = Localization.App.Service.Topics.Food.Afterparty.Title
				},

				new Topic
				{
					Id = -1,
					Language = _languageService.Russian,
					Speakers = new List<Speaker>
					{
						_speakerService.ABoyko(),
						_speakerService.GShopnik(),
						_speakerService.ATumanoff(),
						_speakerService.VTsykunov(),
						_speakerService.ILeontiev()
					},
					Title = Localization.App.Service.Topics.Special.Keynote.Title,
					Description = Localization.App.Service.Topics.Special.Keynote.Description.Replace(Environment.NewLine, "<br/>")
				},

				new Topic
				{
					Id = -99,
					Language = _languageService.Russian,
					Speakers = new List<Speaker> {_speakerService.ABoyko() },
					Title = Localization.App.Service.Topics.Special.Endnote.Title,
					Description = Localization.App.Service.Topics.Special.Endnote.Description.Replace(Environment.NewLine, "<br/>")
				},

				//new Topic
				//{
				//	Id = 1,
				//	Language = _languageService.English,
				//	Speaker = _speakerService.MMartensson(),
				//	Title = Localization.App.Service.Topics.MMartensson_05.Title,
				//	Description = Localization.App.Service.Topics.MMartensson_05.Description.Replace(Environment.NewLine, "<br/>")
				//},
				new Topic
				{
					Id = 2,
					Language = _languageService.Russian,
					Speakers = new List<Speaker> {_speakerService.ALaysha() },
					Title = Localization.App.Service.Topics.ALaysha_01.Title,
					Description = Localization.App.Service.Topics.ALaysha_01.Description.Replace(Environment.NewLine, "<br/>")
				},
				new Topic
				{
					Id = 3,
					Language = _languageService.Russian,
					Speakers = new List<Speaker> {_speakerService.ASurkov() },
					Title = Localization.App.Service.Topics.ASurkov_01.Title,
					Description = Localization.App.Service.Topics.ASurkov_01.Description.Replace(Environment.NewLine, "<br/>")
				},
				new Topic
				{
					Id = 4,
					Language = _languageService.Russian,
					Speakers = new List<Speaker> {_speakerService.DReznik() },
					Title = Localization.App.Service.Topics.DReznik_01.Title,
					Description = Localization.App.Service.Topics.DReznik_01.Description.Replace(Environment.NewLine, "<br/>")
				},
				new Topic
				{
					Id = 5,
					Language = _languageService.Russian,
					Speakers = new List<Speaker> {_speakerService.EPolonychko() },
					Title = Localization.App.Service.Topics.EPolonychko_01.Title,
					Description = Localization.App.Service.Topics.EPolonychko_01.Description.Replace(Environment.NewLine, "<br/>")
				},
				new Topic
				{
					Id = 6,
					Language = _languageService.Russian,
					Speakers = new List<Speaker> {_speakerService.OChorny() },
					Title = Localization.App.Service.Topics.OChorny_01.Title,
					Description = Localization.App.Service.Topics.OChorny_01.Description.Replace(Environment.NewLine, "<br/>")
				},
				new Topic
				{
					Id = 7,
					Language = _languageService.Russian,
					Speakers = new List<Speaker> {_speakerService.SKryshtop() },
					Title = Localization.App.Service.Topics.SKryshtop_01.Title,
					Description = Localization.App.Service.Topics.SKryshtop_01.Description.Replace(Environment.NewLine, "<br/>")
				},
				new Topic
				{
					Id = 8,
					Language = _languageService.English,
					Speakers = new List<Speaker> {_speakerService.VThavonekham() },
					Title = Localization.App.Service.Topics.VThavonekham_01.Title,
					Description = Localization.App.Service.Topics.VThavonekham_01.Description.Replace(Environment.NewLine, "<br/>")
				},
				new Topic
				{
					Id = 9,
					Language = _languageService.English,
					Speakers = new List<Speaker> {_speakerService.MSmereczynski() },
					Title = Localization.App.Service.Topics.MSmereczynski_01.Title,
					Description = Localization.App.Service.Topics.MSmereczynski_01.Description.Replace(Environment.NewLine, "<br/>")
				},
				new Topic
				{
					Id = 10,
					Language = _languageService.Russian,
					Speakers = new List<Speaker> {_speakerService.SPoplavskiy() },
					Title = Localization.App.Service.Topics.SPoplavskiy_02.Title,
					Description = Localization.App.Service.Topics.SPoplavskiy_02.Description.Replace(Environment.NewLine, "<br/>")
				},
				new Topic
				{
					Id = 11,
					Language = _languageService.Russian,
					Speakers = new List<Speaker> {_speakerService.IFesenko() },
					Title = Localization.App.Service.Topics.IFesenko_01.Title,
					Description = Localization.App.Service.Topics.IFesenko_01.Description.Replace(Environment.NewLine, "<br/>")
				},
				new Topic
				{
					Id = 12,
					Language = _languageService.Russian,
					Speakers = new List<Speaker> {_speakerService.ABoyko() },
					Title = Localization.App.Service.Topics.ABoyko_02.Title,
					Description = Localization.App.Service.Topics.ABoyko_02.Description.Replace(Environment.NewLine, "<br/>")
				},
				new Topic
				{
					Id = 13,
					Language = _languageService.Ukrainian,
					Speakers = new List<Speaker> {_speakerService.OKrakovetskyi() },
					Title = Localization.App.Service.Topics.OKrakovetskyi_02.Title,
					Description = Localization.App.Service.Topics.OKrakovetskyi_02.Description.Replace(Environment.NewLine, "<br/>")
				},
				new Topic
				{
					Id = 14,
					Language = _languageService.Russian,
					Speakers = new List<Speaker> {_speakerService.AYurchenko(), _speakerService.VTolmachov() },
					Title = Localization.App.Service.Topics.AYurchenko_01.Title,
					Description = Localization.App.Service.Topics.AYurchenko_01.Description.Replace(Environment.NewLine, "<br/>")
				},
				new Topic
				{
					Id = 15,
					Language = _languageService.Russian,
					Speakers = new List<Speaker> {_speakerService.ILeontiev() },
					Title = Localization.App.Service.Topics.ILeontiev_01.Title,
					Description = Localization.App.Service.Topics.ILeontiev_01.Description.Replace(Environment.NewLine, "<br/>")
				},
				//new Topic
				//{
				//	Id = 16,
				//	Language = _languageService.Russian,
				//	Speakers = new List<Speaker> {_speakerService.ATkachenko() },
				//	Title = Localization.App.Service.Topics.ATkachenko_02.Title,
				//	Description = Localization.App.Service.Topics.ATkachenko_02.Description.Replace(Environment.NewLine, "<br/>")
				//},
				//new Topic
				//{
				//	Id = 17,
				//	Language = _languageService.Russian,
				//	Speakers = new List<Speaker> {_speakerService.ATkachenko() },
				//	Title = Localization.App.Service.Topics.ATkachenko_01.Title,
				//	Description = Localization.App.Service.Topics.ATkachenko_01.Description.Replace(Environment.NewLine, "<br/>")
				//},
				new Topic
				{
					Id = 18,
					Language = _languageService.English,
					Speakers = new List<Speaker> {_speakerService.MFerdyn() },
					Title = Localization.App.Service.Topics.MFerdyn_02.Title,
					Description = Localization.App.Service.Topics.MFerdyn_02.Description.Replace(Environment.NewLine, "<br/>")
				},
				new Topic
				{
					Id = 19,
					Language = _languageService.Russian,
					Speakers = new List<Speaker> {_speakerService.ILiashov() },
					Title = Localization.App.Service.Topics.ILiashov_01.Title,
					Description = Localization.App.Service.Topics.ILiashov_01.Description.Replace(Environment.NewLine, "<br/>")
				},
				new Topic
				{
					Id = 20,
					Language = _languageService.Russian,
					Speakers = new List<Speaker> {_speakerService.ILiashov() },
					Title = Localization.App.Service.Topics.ILiashov_02.Title,
					Description = Localization.App.Service.Topics.ILiashov_02.Description.Replace(Environment.NewLine, "<br/>")
				},
				new Topic
				{
					Id = 21,
					Language = _languageService.English,
					Speakers = new List<Speaker> {_speakerService.EWasilewski() },
					Title = Localization.App.Service.Topics.EWasilewski_01.Title,
					Description = Localization.App.Service.Topics.EWasilewski_01.Description.Replace(Environment.NewLine, "<br/>")
				},
				new Topic
				{
					Id = 22,
					Language = _languageService.Russian,
					Speakers = new List<Speaker> {_speakerService.AShamray() },
					Title = Localization.App.Service.Topics.AShamray_01.Title,
					Description = Localization.App.Service.Topics.AShamray_01.Description.Replace(Environment.NewLine, "<br/>")
				},
				//new Topic
				//{
				//	Id = 23,
				//	Language = _languageService.Russian,
				//	Speakers = new List<Speaker> {_speakerService.AVidishchev() },
				//	Title = Localization.App.Service.Topics.AVidishchev_01.Title,
				//	Description = Localization.App.Service.Topics.AVidishchev_01.Description.Replace(Environment.NewLine, "<br/>")
				//},
				new Topic
				{
					Id = 24,
					Language = _languageService.Russian,
					Speakers = new List<Speaker> {_speakerService.SKorzh() },
					Title = Localization.App.Service.Topics.SKorzh_01.Title,
					Description = Localization.App.Service.Topics.SKorzh_01.Description.Replace(Environment.NewLine, "<br/>")
				},
				new Topic
				{
					Id = 25,
					Language = _languageService.English,
					Speakers = new List<Speaker> {_speakerService.JessicaEngstrom() },
					Title = Localization.App.Service.Topics.JessicaEngstrom_01.Title,
					Description = Localization.App.Service.Topics.JessicaEngstrom_01.Description.Replace(Environment.NewLine, "<br/>")
				},
				new Topic
				{
					Id = 26,
					Language = _languageService.English,
					Speakers = new List<Speaker> {_speakerService.JimmyEngstrom() },
					Title = Localization.App.Service.Topics.JimmyEngstrom_01.Title,
					Description = Localization.App.Service.Topics.JimmyEngstrom_01.Description.Replace(Environment.NewLine, "<br/>")
				},
				new Topic
				{
					Id = 27,
					Language = _languageService.English,
					Speakers = new List<Speaker> {_speakerService.EAuberix() },
					Title = Localization.App.Service.Topics.EAuberix_01.Title,
					Description = Localization.App.Service.Topics.EAuberix_01.Description.Replace(Environment.NewLine, "<br/>")
				},
				new Topic
				{
					Id = 28,
					Language = _languageService.English,
					Speakers = new List<Speaker> {_speakerService.EAuberix() },
					Title = Localization.App.Service.Topics.EAuberix_02.Title,
					Description = Localization.App.Service.Topics.EAuberix_02.Description.Replace(Environment.NewLine, "<br/>")
				},
				new Topic
				{
					Id = 29,
					Language = _languageService.English,
					Speakers = new List<Speaker> {_speakerService.MMateev() },
					Title = Localization.App.Service.Topics.MMateev_01.Title,
					Description = Localization.App.Service.Topics.MMateev_01.Description.Replace(Environment.NewLine, "<br/>")
				},
				//new Topic
				//{
				//	Id = 30,
				//	Language = _languageService.Russian,
				//	Speakers = new List<Speaker> {_speakerService.VBezmaly() },
				//	Title = Localization.App.Service.Topics._Dummy.Title,
				//	Description = Localization.App.Service.Topics._Dummy.Description.Replace(Environment.NewLine, "<br/>")
				//},
				new Topic
				{
					Id = 31,
					Language = _languageService.Russian,
					Speakers = new List<Speaker> {_speakerService.DDurasau() },
					Title = Localization.App.Service.Topics.DDurasau_01.Title,
					Description = Localization.App.Service.Topics.DDurasau_01.Description.Replace(Environment.NewLine, "<br/>")
				},
				new Topic
				{
					Id = 32,
					Language = _languageService.English,
					Speakers = new List<Speaker> {_speakerService.AMang() },
					Title = Localization.App.Service.Topics.AMang_01.Title,
					Description = Localization.App.Service.Topics.AMang_01.Description.Replace(Environment.NewLine, "<br/>")
				},
				new Topic
				{
					Id = 33,
					Language = _languageService.English,
					Speakers = new List<Speaker> {_speakerService.VThavonekham() },
					Title = Localization.App.Service.Topics.VThavonekham_02.Title,
					Description = Localization.App.Service.Topics.VThavonekham_02.Description.Replace(Environment.NewLine, "<br/>")
				},
				new Topic
				{
					Id = 34,
					Language = _languageService.Ukrainian,
					Speakers = new List<Speaker> {_speakerService.ENiedaszkowski() },
					Title = Localization.App.Service.Topics.ENiedaszkowski_02.Title,
					Description = Localization.App.Service.Topics.ENiedaszkowski_02.Description.Replace(Environment.NewLine, "<br/>")
				},
				new Topic
				{
					Id = 35,
					Language = _languageService.Russian,
					Speakers = new List<Speaker> {_speakerService.OChorny() },
					Title = Localization.App.Service.Topics.OChorny_02.Title,
					Description = Localization.App.Service.Topics.OChorny_02.Description.Replace(Environment.NewLine, "<br/>")
				}
			};
		}

		public IEnumerable<Topic> GetTopics()
		{
			return _topics;
		}

		public Topic Registration { get { return _topics.Single(x => x.Id == -101); } }
		public Topic CoffeeBreak { get { return _topics.Single(x => x.Id == -102); } }
		public Topic Lunch { get { return _topics.Single(x => x.Id == -103); } }
		public Topic Afterparty { get { return _topics.Single(x => x.Id == -104); } }
		public Topic Endnote { get { return _topics.Single(x => x.Id == -99); } }

		public Topic Keynote { get { return _topics.Single(x => x.Id == -1); } }

		//public Topic MMartensson_05 { get { return _topics.Single(x => x.Id == 1); } }
		public Topic ALaysha_01 { get { return _topics.Single(x => x.Id == 2); } }
		public Topic ASurkov_01 { get { return _topics.Single(x => x.Id == 3); } }
		public Topic DReznik_01 { get { return _topics.Single(x => x.Id == 4); } }
		public Topic EPolonychko_01 { get { return _topics.Single(x => x.Id == 5); } }
		public Topic OChorny_01 { get { return _topics.Single(x => x.Id == 6); } }
		public Topic SKryshtop_01 { get { return _topics.Single(x => x.Id == 7); } }
		public Topic VThavonekham_01 { get { return _topics.Single(x => x.Id == 8); } }
		public Topic MSmereczynski_01 { get { return _topics.Single(x => x.Id == 9); } }
		public Topic SPoplavskiy_02 { get { return _topics.Single(x => x.Id == 10); } }
		public Topic IFesenko_01 { get { return _topics.Single(x => x.Id == 11); } }
		public Topic ABoyko_02 { get { return _topics.Single(x => x.Id == 12); } }
		public Topic OKrakovetskyi_02 { get { return _topics.Single(x => x.Id == 13); } }
		public Topic AYurchenko_01 { get { return _topics.Single(x => x.Id == 14); } }
		public Topic ILeontiev_01 { get { return _topics.Single(x => x.Id == 15); } }
		//public Topic ATkachenko_02 { get { return _topics.Single(x => x.Id == 16); } }
		//public Topic ATkachenko_01 { get { return _topics.Single(x => x.Id == 17); } }
		public Topic MFerdyn_02 { get { return _topics.Single(x => x.Id == 18); } }
		public Topic ILiashov_01 { get { return _topics.Single(x => x.Id == 19); } }
		public Topic ILiashov_02 { get { return _topics.Single(x => x.Id == 20); } }
		public Topic EWasilewski_01 { get { return _topics.Single(x => x.Id == 21); } }
		public Topic AShamray_01 { get { return _topics.Single(x => x.Id == 22); } }
		//public Topic AVidishchev_01 { get { return _topics.Single(x => x.Id == 23); } }
		public Topic SKorzh_01 { get { return _topics.Single(x => x.Id == 24); } }
		public Topic JessicaEngstrom_01 { get { return _topics.Single(x => x.Id == 25); } }
		public Topic JimmyEngstrom_01 { get { return _topics.Single(x => x.Id == 26); } }
		public Topic EAuberix_01 { get { return _topics.Single(x => x.Id == 27); } }
		public Topic EAuberix_02 { get { return _topics.Single(x => x.Id == 28); } }
		public Topic MMateev_01 { get { return _topics.Single(x => x.Id == 29); } }
		//public Topic VBezmaly_01 { get { return _topics.Single(x => x.Id == 30); } }
		public Topic DDurasau_01 { get { return _topics.Single(x => x.Id == 31); } }
		public Topic AMang_01 { get { return _topics.Single(x => x.Id == 32); } }
		public Topic VThavonekham_02 { get { return _topics.Single(x => x.Id == 33); } }
		public Topic ENiedaszkowski_01 { get { return _topics.Single(x => x.Id == 34); } }
		public Topic OChorny_02 { get { return _topics.Single(x => x.Id == 35); } }
	}
}
