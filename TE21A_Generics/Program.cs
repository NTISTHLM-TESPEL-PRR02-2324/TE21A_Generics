List<int> numbers = new() { 5, 6, 7, 7 };
Stack<int> numbers2 = new();
Dictionary<string, string> teachers = new();
Queue<int> numbersQueue = new();
Dictionary<string, Action> actions = new();

Enemy g = new Enemy();

// numbers.Push(8);
// numbers.Push(45);
// numbers.Push(98);
// numbers.Push(665);

// int y = numbers.Pop();



// teachers.Add("Micke", "Bäst");

// Console.WriteLine(teachers["Micke"]);


actions.Add("hi", SayHello);

actions["hi"]();

static void SayHello()
{
  Console.WriteLine("hello!");
}



// Console.WriteLine(numbers[2]);

// numbers.Insert(2, 99);


// numbersQueue.Enqueue(8);
// numbersQueue.Enqueue(2);
// numbersQueue.Enqueue(89);

// int t = numbersQueue.Dequeue();

// Console.WriteLine(t);

Console.ReadLine();

Node<string> node = new();

node.content

class Node<T>
{
  public T content;
  Node<T> neighbor;
}