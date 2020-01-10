using System;

namespace rht
{
  public class LynkedList
  {
    // linked list implementation from 
    // https://stackoverflow.com/questions/3823848/creating-a-very-simple-linked-list
    // and
    // https://stackoverflow.com/questions/20087194/c-sharp-singly-linked-list-implementation?noredirect=1&lq=1


    // create a node that defines itself by its data and the next node in the list
    public class Node
    {
      public Node next = null;
      public object data;
    }

    // head is the pointer that refers to the current node in the list
    // sometimes also called root
    private Node head;
    
    public Node First 
    {
      get
      {
        return head;
      }
    }

    public Node Last
    {
      get
      {
        Node current = head;
        if (current == null)
        {
          return null;
        }
        // keep traversing the list while there is another item to find the end of the list
        while (current.next !=null)
        {
          current = current.next;
        }
        // return the node that doesn't have any next eg whose next property is null
        return current;
      }
    }
    public void Append(object value)
    {
      Node nodeToAdd = new Node
      {
        data = value
      };
      if (head == null)
      {
        // if the list is empty
        head = nodeToAdd;
      }
      else
      {
        // when you get to the end of the list through the Last getter, set this node to add as the 'next' node at the tail of the list
        Last.next = nodeToAdd;
      }
    }

    public void Delete(Node nodeToDelete)
    {
      if (head == nodeToDelete)
      {
        // when node to delete is head node next node becomes head
        head = nodeToDelete.next;
        // unset the link to the 'next'
        nodeToDelete.next = null;
      }
      else
      {
        // when have to traverse list to find node go until next is null aka end of list
        // setting pointer 'current' to beginning of list
        Node current = head;
        while (current.next != null)
        {
          if (current.next == nodeToDelete)
          // next node is target for deletion
          {
            // set the link between the node before and after the node to be deleted
            current.next = nodeToDelete.next;
            // unset the link of the current node hence removing it from the list
            nodeToDelete.next = null;
            // end the while loop because we have accomplished the function
            break;
          }
          // reset pointer to next item in list to keep searching until item is found
          current = current.next;
          
        }
      }
    }
    public void PrintAllNodes()
    {
      Node current = head;
      // print all nodes until there is no next to set as current eg end of list
      while (current != null)
      {
        Console.WriteLine(current.data);
        current = current.next;
      }
    }

    public void AddFirst(object data)
    {
      
      Node nodeToFirst = new Node();

      nodeToFirst.data = data;
      nodeToFirst.next = head;
      // set pointer to this node
      head = nodeToFirst;
    }

    public void AddLast(object data)
    {
      if (head == null)
      {
        // when there is an empty list
        head = new Node();
        head.data = data;

        // last node is only node so there is no next
        head.next = null;
      }
      else
      {
        // when there are items in list

        Node nodeToLast = new Node();
        nodeToLast.data = data;

        // get the current node referred to by its pointer 'head'
        Node current = head;
        while (current.next != null)
        {
          // while there is another item in list set 
          current = current.next;
        } 

        current.next = nodeToLast;
      }
    }
  } 
}
