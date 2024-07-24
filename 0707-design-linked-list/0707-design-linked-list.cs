

public class MyLinkedList
{
    Node? root = null;

    Node? tail = null;
    int count = 0;

    public void Print()
    {
        Node curr = root;
        int cnt=0;
        while(curr is not null)
        {
            cnt++;
            curr=curr.Next;
        }
    }
    public int Get(int index)
    {
        if (root is null || count <= index)
            return -1;
        if (count != Count())
            Console.WriteLine("Get");
        Node current = root;
        while (index-- > 0)
        {
            current = current.Next;
        }
        return current.Value;
    }

    public void AddAtHead(int val)
    {
        Node newNode = new Node(val);
        newNode.Next = root;
        count++;
        tail ??= newNode;
        root = newNode;

    }
    public int Count()
    {
        Node current = root;
        int cnt = 0;
        while (current is not null)
        {
            cnt++;
            current = current.Next;
        }
        return cnt;
    }
    public void AddAtTail(int val)
    {
        Node newNode = new Node(val);
        count++;
        if (count == 31)
            Console.WriteLine("AddAtTail" + " " + Count());
        if (count == 1)
            root = tail = newNode;
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }

    }

    public void AddAtIndex(int index, int val)
    {
        if (count < index)
            return;
        int ind = index;
        if (index == 0)
        {
            AddAtHead(val);
            return;
        }
        if (index == count)
        {
            AddAtTail(val);
            return;
        }
        count++;
        Node newNode = new Node(val);
        Node current = root;
        while (--index > 0)
        {
            current = current.Next;
        }
        newNode.Next = current.Next;
        current.Next = newNode;

    }

    public void DeleteAtIndex(int index)
    {
        if (count <= index)
            return;
        count--;
        Node current = root;
        int ind = index;
        bool yes = false;

        if (index == count)
            yes = true;
        if (index == 0)
        {
            root = root.Next;
            if (yes)
                tail = root;
            return;

        }
      
        while (--index > 0)
        {
            current = current.Next;
        }
        current.Next = current.Next?.Next;
        if (yes)
            tail = current;


    }
}
public class Node
{
    public Node(int value)
    {
        Value = value;
        Next = null;
    }
    public int Value { get; set; }
    public Node? Next { get; set; }

}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */