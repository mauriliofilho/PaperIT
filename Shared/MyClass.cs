using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;


namespace Shared
{
	public class itEbook_api
	{
		public object GetAsync1 (string text)
		{
			throw new NotImplementedException ();
		}

		public class Book
		{
			public object ID { get; set; }
			public string Title { get; set; }
			public string SubTitle { get; set; }
			public string Description { get; set; }
			public string Image { get; set; }
			public string isbn { get; set; }
		}

		public class RootObject
		{
			public string Error { get; set; }
			public double Time { get; set; }
			public string Total { get; set; }
			public int Page { get; set; }
			public List<Book> Books { get; set; }
		}
	}
}

