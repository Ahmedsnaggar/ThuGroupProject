using System.Collections;
using ThuGroupProject;
using ThuGroupProject.Classes;

#region Befor15/08/2024
#region PersonList
//DateTime date = new DateTime(1999, 09, 30);
//List<Person> personsList = new List<Person>();
//for (int i = 1; i <= 10; i++)
//{
//    date = date.AddDays(1);
//    Person person = new Person();
//    person.Name = $"Name {i}";
//    person.DOB = date;
//    person.City = $"City {i}";
//    person.Address = $"Address {i}";
//    person.PhoneNumber = $"PhoneNumber {i}";
//    person.IdNumber = $"IdNumber {i}";
//    personsList.Add(person);
//}


//foreach (Person person in personsList)
//{
//    string str = $"Person's Name : {person.Name}, Person's BirthDate : {person.DOB.ToShortDateString()}, Person's City = {person.City}, Person's Address : {person.Address}, Person's Phone : {person.PhoneNumber}, Person's Id :{person.IdNumber}";
//    Console.WriteLine(str);
//}
#endregion

//Person person = new Person();
//string name = person.ShowName();
//Coffee coffee1 = new Coffee(4, "Arabica", "Columbia");
#region arraylist

//ArrayList arrayList = new ArrayList();

//arrayList.Add(1);
//arrayList.Add(person);
//arrayList.Add(coffee1);
//arrayList.Add("Ahmed");

//for (int i = 0; i < arrayList.Count; i++)
//{

//    if (arrayList[i]is Coffee)
//    {
//        Coffee coffee3 = (Coffee)arrayList[i];
//        Console.WriteLine($"Coffe3 strength : {coffee3.strength}, bean : {coffee3.bean}, origin : {coffee3.origin}");
//    }
    
//}
#endregion

#region Structs
//Coffee coffee2 = coffee1;
//Console.WriteLine($"Coffe1 strength : {coffee1.strength}, bean : {coffee1.bean}, origin : {coffee1.origin}, Coffe2 strength : {coffee2.strength}, bean : {coffee2.bean}, origin : {coffee2.origin}");

//coffee2.strength = 5;
//coffee2.bean = "Black";
//coffee2.origin = "Brazil";
//Console.WriteLine($"Coffe1 strength : {coffee1.strength}, bean : {coffee1.bean}, origin : {coffee1.origin}, Coffe2 strength : {coffee2.strength}, bean : {coffee2.bean}, origin : {coffee2.origin}");

//Menu menu = new Menu();

//foreach ( var item in menu.beveragesList)
//{
//    Console.WriteLine( item.Name );
//}

//string myBeverege = menu[5].Name;

//Console.WriteLine( myBeverege );
#endregion


#region Stack & Queue
//Stack<int> intStack = new Stack<int>();

//for (int i = 1; i <= 10; i++)
//{
//    intStack.Push(i);
//}



//foreach (int i in intStack)
//    Console.WriteLine(i);

//for (int i = 0; i < intStack.Count; i++)
//{
//    Console.WriteLine(intStack.ElementAt(i));
//}

//Queue<int> queue = new Queue<int>();

//for (int i = 1; i <= 10; i++)
//{
//    queue.Enqueue(i);
//}
//for (int i = 0; i < queue.Count; i++)
//{
//    Console.WriteLine(queue.ElementAt(i));
//}


#endregion

#region SortedList & Dictionary
//SortedList<string, int> sl = new SortedList<string, int>();
//SortedList sl = new SortedList();
//sl.Add("ID", 1);
//sl.Add("Name", "Ahmed");

//Console.WriteLine(sl["Name"]);

//Dictionary<string, string> d = new Dictionary<string, string>();

//d.Add("ID", "1");
//d.Add("Name", "Ahmed");

//foreach(var s in d)
//{
//    Console.WriteLine(s.Key + " : " + s.Value);
//}

#endregion
#endregion

#region Lec15/08/2024

#region Delegates
string str = "Hello World!";
Console.WriteLine("===== With Delegate =====");
//CallTextByDelegate(str, UpperCase);
//CallTextByDelegate(str, LowerCase);
//CallTextByDelegate(str, SubText);
//CallTextByDelegate(str, ReplaceText);
//CallTextByDelegate(str, JoinText);

//CallTextByDelegate(str, delegate (string myText) { Console.WriteLine( myText.ToUpper()); });


////Lambda 
//CallTextByDelegate(str, (myText2) => Console.WriteLine(myText2.ToUpper()));


void CallTextByDelegate(string text, TextDelegate dlg)
{
    dlg(text);
}


Console.WriteLine("===== Without Delegate =====");
//CallText(str, 'u');
//CallText(str, 'l');
//CallText(str, 's');
//CallText(str, 'r');
//CallText(str, 'j');
void CallText(string text, char textStatu)
{
    if(textStatu == 'u')
    {
        UpperCase(text);
    }else if(textStatu == 'l')
    {
        LowerCase(text);
    }
    else if (textStatu == 's')
    {
        SubText(text);
    }
    else if (textStatu == 'r')
    {
        ReplaceText(text);
    }else if(textStatu == 'j')
    {
        JoinText(text);
    }
}

void UpperCase(string text)
{
    Console.WriteLine(str.ToUpper());
}
void LowerCase(string text)
{
    Console.WriteLine(text.ToLower());
}
void SubText(string text)
{
    Console.WriteLine(text.Substring(2, 6));
}
void ReplaceText(string text)
{
    Console.WriteLine(text.Replace("Hello", "Welcome"));
}
void JoinText(string text)
{
    Console.WriteLine(String.Join(",", new string[] {text, " Joined By Join Method"}));
}
#endregion

#region OrdersEvent

List<Order> ordersList = new List<Order>();

for(int i = 1;  i <= 50; i++)
{
    Random rnd = new Random();
    Order curOrder = new Order();
    curOrder.ProductName = $"Product {i}";
    curOrder.Price = rnd.Next(50, 100);
    curOrder.Quantity  = rnd.Next(1, 10);
    ordersList.Add(curOrder);
}

foreach(Order curOrder in ordersList)
{
    double Total = curOrder.Price * curOrder.Quantity;
    curOrder.OrderDegreeEvent += GetOrderName;
    curOrder.OrderDegreeEvent -= GetOrderName;
    #region unsubscribe
    //curOrder.OrderDegreeEvent += GetHighValuesOrders;
    //curOrder.OrderDegreeEvent += GetNormalValuesOrders;
    //curOrder.OrderDegreeEvent += GetLowValuesOrders;
    //if (Total > 400)
    //{
    //    curOrder.OrderDegreeEvent -= GetNormalValuesOrders;
    //    curOrder.OrderDegreeEvent -= GetLowValuesOrders;
    //}else if(Total < 400 && Total > 200)
    //{
    //    curOrder.OrderDegreeEvent -= GetHighValuesOrders;
    //    curOrder.OrderDegreeEvent -= GetLowValuesOrders;
    //}else if(Total < 200)
    //{
    //    curOrder.OrderDegreeEvent -= GetNormalValuesOrders;
    //    curOrder.OrderDegreeEvent -= GetHighValuesOrders;
    //}
    #endregion
    #region subscribe
    if (Total > 400)
    {
        curOrder.OrderDegreeEvent += GetHighValuesOrders;
    }
    else if (Total < 400 && Total > 200)
    {
        curOrder.OrderDegreeEvent += GetNormalValuesOrders;
    }
    else if (Total < 200)
    {
        curOrder.OrderDegreeEvent += GetLowValuesOrders ;
    }
    #endregion

    curOrder.OrderDegreeMethod(curOrder);

    Console.WriteLine($"Product : {curOrder.ProductName}, Price : {curOrder.Price}, Quantity : {curOrder.Quantity}, Line Total: {curOrder.CalculateTotal(curOrder.Price, curOrder.Quantity)}, Line Total From Delegate : {curOrder.CalcMethod(curOrder.Price, curOrder.Quantity, curOrder.CalculateTotal)}");
}

void GetOrderName(Order order)
{
    Console.WriteLine($"Product Name = {order.ProductName}");
}
void GetHighValuesOrders(Order order)
{
    Console.WriteLine($"Product : {order.ProductName}, Price Value Is High");
}
void GetNormalValuesOrders(Order order)
{
    Console.WriteLine($"Product : {order.ProductName}, Price Value Is Normal");
}
void GetLowValuesOrders(Order order)
{
    Console.WriteLine($"Product : {order.ProductName}, Price Value Is Low");
}
#endregion

#endregion

Console.ReadLine();

delegate void TextDelegate(string text);

