
//вариант 17 сред уровень

Product[] products = new Product[3];
for (int i = 0; i < products.Length; i++)
{
    Console.Write("Введите наименование продукта: ");
    products[i].name = Console.ReadLine()!;
    Console.Write("Введите дату производства: ");
    products[i].data =DateOnly.Parse (Console.ReadLine()!);
    Console.Write("Введите срок годности в днях: ");
    products[i].time = int.Parse(Console.ReadLine()!);
    Console.Write("Введите цену: ");
    products[i].price = decimal.Parse(Console.ReadLine()!);
    Console.Write("Введите № серии: ");
    products[i].number = int.Parse(Console.ReadLine()!);
    Console.WriteLine();
}
for (int i = 0; i < products.Length; i++)
{
    if (products[i].time == 5) products[i].Print();
}

struct Product
{
    public string name;
    public DateOnly data;
    public int time;
    public decimal price;
    public int number;
    public void Print()
    {
        Console.WriteLine($"Наименование продукта: {name} , Дата производства: {data} , Срок годности: {time} дней , Цена: {price} , № Серии: {number} " );
    }
}
