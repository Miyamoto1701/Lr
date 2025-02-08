List<string> fruit = ["Melon", "Orange", "Apple"];
Console.WriteLine("Сколько элементов добавить?");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    fruit.Add(item: Console.ReadLine());
}
for (int i = 0; i < fruit.Count; i++)
{
    Console.WriteLine($"{i + 1} - {fruit[i]}");
}

Dictionary<int, int> order = new()
{
    {1, 230},
    {2, 430},
    {3, 150}
};
Console.WriteLine("Сколько элементов добавить?");
int count = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < count; i++)
{
    Console.WriteLine("Введите номер закза");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите стоимость закза");
    int cost = Convert.ToInt32(Console.ReadLine());
    order.Add(number, cost);
}
for (int i = 0; i < order.Count; i++)
{
    Console.WriteLine($"Заказ {i + 1} - Стоимость {order[i + 1]}");
}
Console.WriteLine($"Количество заказов {order.Count}");