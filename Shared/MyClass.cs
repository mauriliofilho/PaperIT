using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;


namespace Shared
{
	public class itEbook_api
	{
		public async Task<List<string>> GetAsync(string books)
		{
			string url = string.Format("http://it-ebooks-api.info/v1/search/");

			var client = new HttpClient ();
			client.DefaultRequestHeaders.Add ("User-Agent", "Other");

			var response = await client.GetAsync (url);
			var content = await response.Content.ReadAsStringAsync ();

			var json = JArray.Parse (content);

			var book = new List<string> ();
			foreach (var item in json) {
				var booksIT = item.Value<string> ("Title");
				book.Add (booksIT);
			}
			return book;
		}
	}
}

