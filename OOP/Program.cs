// See https://aka.ms/new-console-template for more information
using OOP.Reflection;
using System.Reflection;

Console.WriteLine("Hello, World!");


Type t = typeof(MyClass);
MethodInfo[] mi = t.GetMethods();
Console.WriteLine("Nesnenin adı :" + t.Name);
foreach (MethodInfo info in mi)
{
    ParameterInfo[] pi = info.GetParameters();
    Console.WriteLine("Metot Adı :" + info.Name + " Dönüş Tipi" + info.ReturnType);
    if (pi.Length > 0)
    {
        Console.WriteLine("parametre var");
    }
    for (int iX = 0; iX < pi.Length; iX++)
    {
        Console.WriteLine(iX + 1 + " . parametre : Dönüş Değerri " + pi[iX].ParameterType.Name + " Adı " + pi[iX].Name);
    }
}
Employee employee = new Employee();
employee.GetType().GetMethods().ToList().ForEach(method =>
{
    if (method.Name == "CostSalary")
    {
        var Sonuc = method.Invoke(employee, new object[] { 3, 5 });
        Console.WriteLine("Maaşı :" + Sonuc);
    }
});