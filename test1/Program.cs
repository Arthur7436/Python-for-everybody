using System;
using System.Transactions;

public class Node
{
    public int Value { get; }
    public Node Next { get; set; }

    public Node(int value)
    {
        Value = value;
        Next = null;
    }
}

public class LinkedList
{
    public Node Head { get; private set; }

    // Method to add a node to the beginning of the list
    public void AddFirst(int value)
    {
        // Create a new Node instance with the provided value
        Node newNode = new Node(value);

        // Point the newNode's Next property to the current Head
        newNode.Next = Head;

        // Reassign the Head to be the newNode
        Head = newNode;
    }

    public void AddLast(int value)
    {
        Node newNode = new Node(value);
        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void RemoveFirst(int value)
    {
        Node newNode = new Node(value);
        if (Head == null)
        {
            System.Console.WriteLine("The linked list is empty");
        }
        else
        {
            Node current = Head;
            while (current.Next != null)
            {
                if (current.Next == newNode)
                {
                    current.Next = Head;
                    return;
                }
                return;
            }
        }
    }


    public void PrintList()
    {
        Node current = Head;

        while (current != null)
        {
            System.Console.WriteLine(current.Value);
            current = current.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        LinkedList myList = new LinkedList();

        // Use AddFirst to add elements to the list
        myList.AddFirst(1);
        myList.AddFirst(2);
        myList.AddFirst(3);
        myList.AddFirst(4);

        myList.AddLast(100);
        myList.RemoveFirst(100);


        // Assuming a Print method exists to print all elements
        // This will print: 3 2 1
        myList.PrintList();
    }
}
