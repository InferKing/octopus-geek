using AngleSharp;
using AngleSharp.Io;
using AngleSharp.Dom;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

var requester = new DefaultHttpRequester();
requester.Headers["User-Agent"] = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.14; rv:68.0) Gecko/20100101 Firefox/68.0";
IConfiguration config = Configuration.Default.With(requester).WithDefaultLoader();
using IBrowsingContext context = BrowsingContext.New(config);

var url = "https://api.hh.ru/resumes/94092023";
using var doc = await context.OpenAsync(url);
// var title = doc.QuerySelector("title").InnerHtml;

// Console.WriteLine(doc.Prettify());

// var pars = doc.QuerySelectorAll("pre");
Console.WriteLine(doc.Prettify());
//JObject json = JsonConvert.DeserializeObject<JObject>(pars[0].Text());
//var items = json.Property("items");
//foreach (var item in items)
//{
//    Console.WriteLine(item);
//}
