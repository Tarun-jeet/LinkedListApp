using System;

class Node
{
    
    public int Data; // Data stored in the node
    public Node Next; // Pointer to the next node

    public Node(int data)
    {
        Data = data;
        Next = null; // Initialize next as null
    }
}

class LinkedList
{
    private Node head; // Head of the linked list

    // Method to insert a new node at a specific index
    public void Insert(int index, int data)
    {
        Node newNode = new Node(data); // Create a new node

        if (index == 0) // Inserting at the head
        {
            newNode.Next = head; // Point new node to the current head
            head = newNode; // Update head to new node
        }
        else
        {
            Node current = head;
            for (int i = 0; i < index - 1; i++)
            {
                if (current == null) // If index is out of bounds
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Index out of bounds!!");
            
                    return;
                }
                current = current.Next; // Move to the next node
            }
            newNode.Next = current.Next; // Link new node to the next node
            current.Next = newNode; // Link current node to the new node
        }
        Console.WriteLine("Inserted successfully.");
    }

    // Method to delete a node at a specific index
    public void Delete(int index)
    {
        if (head == null) // If the list is empty
        {
            Console.WriteLine("List is empty.");
            return;
        }

        if (index == 0) // Deleting the head
        {
            head = head.Next; // Update head to the next node
        }
        else
        {
            Node current = head;
            for (int i = 0; i < index - 1; i++)
            {
                if (current == null || current.Next == null) // If index is out of bounds
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Index out of bounds!!");
                    Console.WriteLine(" ");
                    return;
                }
                current = current.Next; // Move to the next node
            }
            current.Next = current.Next?.Next; // Bypass the node to be deleted
        }
        Console.WriteLine("Deleted successfully.");
    }

    // Method to display the linked list
    public void Display()
    {
        Node current = head;
        if (current == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        Console.Write("Linked List: ");
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList linkedList = new LinkedList();
        while (true)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. Delete");
            Console.WriteLine("3. Display");
            Console.WriteLine("4. Exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": // Insert
                    Console.Write("Enter index to insert: ");
                    int insertIndex = int.Parse(Console.ReadLine());
                    Console.Write("Enter value to insert: ");
                    int insertValue = int.Parse(Console.ReadLine());
                    linkedList.Insert(insertIndex, insertValue);
                    break;

                case "2": // Delete
                    Console.Write("Enter index to delete: ");
                    int deleteIndex = int.Parse(Console.ReadLine());
                    linkedList.Delete(deleteIndex);
                    break;

                case "3": // Display
                    linkedList.Display();
                    break;

                case "4": // Exit
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}