using Balta.ContentContext;
using Balta.SubscriptionContext;

var articles = new List<Article>();
articles.Add(new Article(title: "Fundamentos OOP", url: "fundamentos-oop"));
articles.Add(new Article("Fundamentos C#", "fundamentos-csharp"));
articles.Add(new Article("ASP.NET", "fundamentos-aspnet"));

// foreach (var article in articles)
// {
//   Console.WriteLine(article.Id);
//   Console.WriteLine(article.Title);
//   Console.WriteLine(article.Url);
// }

var courses = new List<Course>();

var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

courses.Add(courseOOP);
courses.Add(courseCsharp);
courses.Add(courseAspNet);

var careers = new List<Career>();

var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");

var careerItemDotNet = new CareerItem(3, "Aprenda .NET", "", courseOOP);
var careerItemOOP = new CareerItem(2, "Aprenda OOP", "", courseCsharp);
var careerItemStart = new CareerItem(1, "Comece por aqui", "", courseAspNet);

careerDotnet.Items.Add(careerItemDotNet);
careerDotnet.Items.Add(careerItemOOP);
careerDotnet.Items.Add(careerItemStart);

careers.Add(careerDotnet);

foreach (var career in careers)
{
  Console.WriteLine(career.Title);
  foreach (var item in career.Items.OrderBy(x => x.Order))
  {
    Console.WriteLine($"{item.Order} - {item.Title}");
    Console.WriteLine(item.Course?.Title);
    Console.WriteLine(item.Course?.Level);
    foreach (var notification in item.Notifications)
    {
      Console.WriteLine($"{notification.Property} - {notification.Message}");
    }
  }
}

var payPalSubscription = new PayPalSubscription();
var student = new Student();
student.Subscriptions.Add(payPalSubscription);