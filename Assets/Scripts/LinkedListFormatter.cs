using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LinkedListFormatter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ListNode head = new ListNode(1);
        head.Next = new ListNode(2);
        head.Next.Next = new ListNode(3);
        head.Next.Next.Next = new ListNode(4);
        head.Next.Next.Next.Next = new ListNode(5);
        head.Next.Next.Next.Next.Next = new ListNode(6);

        string printListNode = PrintListNode(head);
        Debug.Log(printListNode);
    }

    // Update is called once per frame
    void Update()
    {

    }
    string PrintListNode(ListNode head)
    {
        if (head == null) return "Empty List";

        List<string> elements = new List<string>();
        ListNode current = head;

        while (current != null)
        {
            elements.Add(current.value.ToString());
            current = current.Next;
        }
        return string.Join("->", elements);
    }
}

public class ListNode
{
    //public, private, protected, interval, protected internal, private protected
    public int value;
    public ListNode Next;

    public ListNode(int value)
    {
        this.value = value;
        this.Next = null;
    }
}

