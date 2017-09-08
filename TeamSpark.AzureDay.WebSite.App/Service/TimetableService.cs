using System.Collections.Generic;
using System.Linq;
using TeamSpark.AzureDay.WebSite.App.Entity;

namespace TeamSpark.AzureDay.WebSite.App.Service
{
	public sealed class TimetableService
	{
		private readonly List<Timetable> _timetables = new List<Timetable>();

		private readonly TopicService _topicService = new TopicService();
		private readonly RoomService _roomService = new RoomService();

		public TimetableService()
		{
			_timetables.AddRange(new List<Timetable>
			{
				new Timetable { TimeStart = "8:15", TimeEnd = "9:00", Room = _roomService.CoffeeBreak, Topic = _topicService.Registration },
				new Timetable { TimeStart = "10:15", TimeEnd = "10:30", Room = _roomService.CoffeeBreak},
				new Timetable { TimeStart = "11:30", TimeEnd = "12:00", Room = _roomService.CoffeeBreak, Topic = _topicService.CoffeeBreak },
				new Timetable { TimeStart = "13:00", TimeEnd = "13:15", Room = _roomService.CoffeeBreak },
				new Timetable { TimeStart = "14:15", TimeEnd = "14:45", Room = _roomService.CoffeeBreak, Topic = _topicService.Lunch },
				new Timetable { TimeStart = "15:45", TimeEnd = "16:00", Room = _roomService.CoffeeBreak },
				new Timetable { TimeStart = "17:00", TimeEnd = "17:30", Room = _roomService.CoffeeBreak, Topic = _topicService.CoffeeBreak },
				new Timetable { TimeStart = "19:15", TimeEnd = "21:00", Room = _roomService.CoffeeBreak, Topic = _topicService.Afterparty }
			});

			_timetables.AddRange(new List<Timetable> // web dev
			{
				new Timetable { TimeStart = "9:00", TimeEnd = "10:15", Room = _roomService.Room1, Topic = _topicService.Keynote },
				new Timetable { TimeStart = "10:30", TimeEnd = "11:30", Room = _roomService.Room1, Topic = _topicService.OKrakovetskyi_02 },
				new Timetable { TimeStart = "12:00", TimeEnd = "13:00", Room = _roomService.Room1, Topic = _topicService.ABoyko_02 },
				new Timetable { TimeStart = "13:15", TimeEnd = "14:15", Room = _roomService.Room1, Topic = _topicService.IFesenko_01 },
				new Timetable { TimeStart = "14:45", TimeEnd = "15:45", Room = _roomService.Room1, Topic = _topicService.SKorzh_01 },
				new Timetable { TimeStart = "16:00", TimeEnd = "17:00", Room = _roomService.Room1, Topic = _topicService.ILeontiev_01 },
				new Timetable { TimeStart = "17:30", TimeEnd = "18:30", Room = _roomService.Room1, Topic = _topicService.EAuberix_01 },
				new Timetable { TimeStart = "18:30", TimeEnd = "19:15", Room = _roomService.Room1, Topic = _topicService.Endnote }
			});

			_timetables.AddRange(new List<Timetable> // iot
			{
				new Timetable { TimeStart = "10:30", TimeEnd = "11:30", Room = _roomService.Room2, Topic = _topicService.SPoplavskiy_02 },
				new Timetable { TimeStart = "12:00", TimeEnd = "13:00", Room = _roomService.Room2, Topic = _topicService.ASurkov_01 },
				new Timetable { TimeStart = "13:15", TimeEnd = "14:15", Room = _roomService.Room2, Topic = _topicService.VThavonekham_02 },
				new Timetable { TimeStart = "14:45", TimeEnd = "15:45", Room = _roomService.Room2, Topic = _topicService.EAuberix_02 },
				new Timetable { TimeStart = "16:00", TimeEnd = "17:00", Room = _roomService.Room2, Topic = _topicService.JessicaEngstrom_01 },
				new Timetable { TimeStart = "17:30", TimeEnd = "18:30", Room = _roomService.Room2, Topic = _topicService.JimmyEngstrom_01 }
			});

			_timetables.AddRange(new List<Timetable> // data
			{
				new Timetable { TimeStart = "10:30", TimeEnd = "11:30", Room = _roomService.Room3, Topic = _topicService.AMang_01 },
				new Timetable { TimeStart = "12:00", TimeEnd = "13:00", Room = _roomService.Room3, Topic = _topicService.EPolonychko_01 },
				new Timetable { TimeStart = "13:15", TimeEnd = "14:15", Room = _roomService.Room3, Topic = _topicService.ALaysha_01 },
				new Timetable { TimeStart = "14:45", TimeEnd = "15:45", Room = _roomService.Room3, Topic = _topicService.MFerdyn_02 },
				new Timetable { TimeStart = "16:00", TimeEnd = "17:00", Room = _roomService.Room3, Topic = _topicService.DReznik_01 },
				new Timetable { TimeStart = "17:30", TimeEnd = "18:30", Room = _roomService.Room3, Topic = _topicService.MMateev_01 }
			});

			_timetables.AddRange(new List<Timetable> // devops
			{
				new Timetable { TimeStart = "10:30", TimeEnd = "11:30", Room = _roomService.Room4, Topic = _topicService.SKryshtop_01 },
				new Timetable { TimeStart = "12:00", TimeEnd = "13:00", Room = _roomService.Room4, Topic = _topicService.OChorny_01 },
				new Timetable { TimeStart = "13:15", TimeEnd = "14:15", Room = _roomService.Room4, Topic = _topicService.OChorny_02 },
				new Timetable { TimeStart = "14:45", TimeEnd = "15:45", Room = _roomService.Room4, Topic = _topicService.AYurchenko_01 },
				new Timetable { TimeStart = "16:00", TimeEnd = "17:00", Room = _roomService.Room4, Topic = _topicService.AShamray_01 },
				new Timetable { TimeStart = "17:30", TimeEnd = "18:30", Room = _roomService.Room4, Topic = _topicService.DDurasau_01 }
			});

			_timetables.AddRange(new List<Timetable> // it-pro
			{
				new Timetable { TimeStart = "10:30", TimeEnd = "11:30", Room = _roomService.Room5, Topic = _topicService.ENiedaszkowski_01 },
				new Timetable { TimeStart = "12:00", TimeEnd = "13:00", Room = _roomService.Room5, Topic = _topicService.ILiashov_02 },
				new Timetable { TimeStart = "13:15", TimeEnd = "14:15", Room = _roomService.Room5, Topic = _topicService.MSmereczynski_01 },
				new Timetable { TimeStart = "14:45", TimeEnd = "15:45", Room = _roomService.Room5, Topic = _topicService.EWasilewski_01 },
				new Timetable { TimeStart = "16:00", TimeEnd = "17:00", Room = _roomService.Room5, Topic = _topicService.VThavonekham_01 },
				new Timetable { TimeStart = "17:30", TimeEnd = "18:30", Room = _roomService.Room5, Topic = _topicService.ILiashov_01 }
			});
		}


		public List<Timetable> GetTimetable()
		{
			return _timetables
				.OrderBy(t => t.TimeStartHours)
				.ThenBy(t => t.TimeStartMinutes)
				.ThenBy(t => t.Room.RoomType.ToString())
				.ThenBy(t => t.Room.Title)
				.ToList();
		}
	}
}
