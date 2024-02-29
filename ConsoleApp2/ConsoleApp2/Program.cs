using System;
class Employee
{
    public string Name { get; set; }
    public int EmployeeNumber { get; set; }
    public Employee(string name, int employeeNumber)
    {
        Name = name;
        EmployeeNumber = employeeNumber;
    }
}
class ProductionWorker : Employee
{
    public int Shift { get; set; }
    public double HourlyRate { get; set; }
    public ProductionWorker(string name, int employeeNumber) : base(name, employeeNumber)
    {
    }
}
class Program
{
    static void Main()
    {
        ProductionWorker worker = new ProductionWorker("", 0);
        Console.Write("Введите имя сотрудника: ");
        worker.Name = Console.ReadLine();
        Console.Write("Введите номер сотрудника: ");
        worker.EmployeeNumber = int.Parse(Console.ReadLine());
        Console.Write("Введите номер смены (1 - дневная, 2 - вечерняя): ");
        worker.Shift = int.Parse(Console.ReadLine());
        Console.Write("Введите почасовую ставку оплаты труда: ");
        worker.HourlyRate = double.Parse(Console.ReadLine());
        Console.WriteLine("\nДанные сотрудника:");
        Console.WriteLine("Имя сотрудника: " + worker.Name);
        Console.WriteLine("Номер сотрудника: " + worker.EmployeeNumber);
        Console.WriteLine("Номер смены: " + (worker.Shift == 1 ? "Дневная" : "Вечерняя"));
        Console.WriteLine("Почасовая ставка оплаты труда: " + worker.HourlyRate);
    }
}
*/

//////////////////////////////////////////////////////////////////////////////////////////////////

*/
 

public class Person
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
}

public class Customer : Person
{
    public int CustomerNumber { get; set; }
    public bool MailingList { get; set; }
}
class Program
{
    static void Main()
    {
        Customer customer = new Customer();

        Console.Write("Введите имя клиента: ");
        customer.Name = Console.ReadLine();

        Console.Write("Введите адрес клиента: ");
        customer.Address = Console.ReadLine();

        Console.Write("Введите телефонный номер клиента: ");
        customer.PhoneNumber = Console.ReadLine();

        Console.Write("Введите номер клиента: ");
        customer.CustomerNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Желает ли клиент быть в списке рассылки? (true/false): ");
        customer.MailingList = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("\nДанные клиента:");
        Console.WriteLine("Имя клиента: " + customer.Name);
        Console.WriteLine("Адрес клиента: " + customer.Address);
        Console.WriteLine("Телефонный номер клиента: " + customer.PhoneNumber);
        Console.WriteLine("Номер клиента: " + customer.CustomerNumber);
        Console.WriteLine("На списке рассылки: " + customer.MailingList);
    }
}
*/

//////////////////////////////////////////////////////////////////////////////////////////////////

*/
using System;

class ShiftSupervisor : Employee
{
    public double AnnualSalary { get; set; }
    public double AnnualProductionBonus { get; set; }

    public ShiftSupervisor(string name, int employeeNumber)
    {
    }
}
public class Employee
{
    public string Name { get; set; }
    public int EmployeeNumber { get; set; }
}
class Program
{
    static void Main()
    {
        ShiftSupervisor supervisor = new ShiftSupervisor("", 0);

        Console.Write("Введите имя начальника смены: ");
        supervisor.Name = Console.ReadLine();

        Console.Write("Введите номер начальника смены: ");
        supervisor.EmployeeNumber = int.Parse(Console.ReadLine());

        Console.Write("Введите годовой оклад начальника смены: ");
        supervisor.AnnualSalary = double.Parse(Console.ReadLine());

        Console.Write("Введите годовую производственную премию начальника смены: ");
        supervisor.AnnualProductionBonus = double.Parse(Console.ReadLine());

        // Вывод данных на экран
        Console.WriteLine("\nДанные начальника смены: ");
        Console.WriteLine("Имя начальника смены: " + supervisor.Name);
        Console.WriteLine("Номер начальника смены: " + supervisor.EmployeeNumber);
        Console.WriteLine("Годовой оклад начальника смены: " + supervisor.AnnualSalary);
        Console.WriteLine("Годовая производственная премия: " + supervisor.AnnualProductionBonus);
    }
}