
public class OrderedLinkedList<T> extends LinkedListClass<T>
{
        //Default constructor
    public OrderedLinkedList()
    {
        super();
    }

        //Method to determine whether searchItem is in
        //the list.
        //Postcondition: Returns true if searchItem is found
        //               in the list; false otherwise.
    public boolean search(T searchItem)
    {
        LinkedListNode<T> current; //variable to traverse
                                   //the list
        boolean found;

        current = first;  //set current to point to the first
                          //node in the list

        found = false;    //set found to false

        while (current != null && !found ) //search the list
        {
            Comparable<T> temp = (Comparable<T>) current.info;

            if (temp.compareTo(searchItem) >= 0)
                found = true;
            else
                current = current.link; //make current point to
                                        //the next node
        }

        if (found)
           found = current.info.equals(searchItem);

        return found;
    }

        //Method to insert insertItem in the list.
        //Postcondition: first points to the new list,
        //       insertItem is inserted at the proper place
        //       in the list, and count is incremented by 1.
    public void insert(T insertItem)
    {
        LinkedListNode<T> current;  //variable to traverse
                                    //the list
        LinkedListNode<T> trailCurrent;    //variable just
                                           //before current
        LinkedListNode<T> newNode;  //variable to create a node

        boolean  found;

        newNode =
            new LinkedListNode<T>(insertItem, null); //create
                                                     //the node

        if (first == null)  //Case 1
        {
           first = newNode;
           last = newNode;
           count++;
        }
        else
        {
            trailCurrent = first;
            current = first;
            found = false;

            while (current != null && !found) //search the list
            {
                Comparable<T> temp =
                         (Comparable<T>) current.info;

                if (temp.compareTo(insertItem) >= 0)
                   found = true;
                else
                {
                   trailCurrent = current;
                   current = current.link;
                }
            }

            if (current == first)   //Case 2
            {
                newNode.link = first;
                first = newNode;
                count++;
            }
            else          //Case 3
            {
                trailCurrent.link = newNode;
                newNode.link = current;

                if (current == null)
                    last = newNode;

                count++;
            }
        }//end else
    }//end insert

        //Method to insert newItem in the list.
        //Because the resulting list is sorted, newItem is
        //inserted at the proper place.
        //This method uses the method insert to insert newItem.
        //Postcondition: first points to the new list
        //               and newItem is inserted at the
        //               proper place. Also,
        //               last points to the last node and
        //               count is incremented by 1.
	 
	 public void insertFirst(T newItem)
    {
        insert(newItem);
    }

        //Method to insert newItem in the list.
        //Because the resulting list is sorted, newItem is
        //inserted at the proper place.
        //This method uses the method insert to insert newItem.
        //Postcondition: first points to the new list
        //               and newItem is inserted at the
        //               proper place. Also,
        //               last points to the last node and
        //               count is incremented by 1.
    public void insertLast(T newItem)
    {
        insert(newItem);
    }//end insertLast

 	
	public void mergeList(OrderedLinkedList<T> l1, OrderedLinkedList<T> l2)
	{
		LinkedListNode<T> current1 = l1.first;
		first = new LinkedListNode<T>();
		LinkedListNode<T> current2 = first;
		LinkedListNode current3 = l2.first;		
		
		while (current1.link != null || current3.link != null) 
		{
			if(current1.link != null)
			{
			current2.info = (T)current1.info;
			current2.link = new LinkedListNode<T>();
			current1 = current1.link;
			current2 = current2.link;
			}
			
			if (current3.link != null)
			{
			current2.info = (T)current3.info;
			current2.link = new LinkedListNode<T>();
			current3 = current3.link;
			current2 = current2.link;
			}
		
		}
		
		}  
	  
	     //Method to delete deleteItem from the list.
        //Postcondition: If found, the node containing
        //               deleteItem is deleted from the
        //               list. Also, first points to the first
        //               node, last points to the last
        //               node of the updated list, and count
        //               is decremented by 1.
    public void deleteNode(T deleteItem)
    {
        LinkedListNode<T> current;      //variable to traverse
                                        //the list
        LinkedListNode<T> trailCurrent; //variable just before
                                        //current
        boolean found;

        if (first == null)    //Case 1; list is empty.
            System.err.println("Cannot delete from an "
                             + "empty list.");
        else
        {
            if (first.info.equals(deleteItem)) //Case 2
            {
                first = first.link;

                if (first == null)
                    last = null;
                count--;
            }
            else  //search the list for the node with
                  //the given info
            {
                found = false;
                trailCurrent = first; //set trailCurrent to
                                      //point to the first node
                current = first.link; //set current to point
                                      //to the second node

                while (current != null && !found)
                {
                    Comparable<T> temp =
                             (Comparable<T>) current.info;

                    if (temp.compareTo(deleteItem) >= 0)
                        found = true;
                    else
                    {
                        trailCurrent = current;
                        current = current.link;
                    }
                }//end while

                if (current == null)   //Case 4
                    System.out.println("Item to be deleted is "
                                     + "not in the list.");
                else
                    if (current.info.equals(deleteItem)) //item
                                 //to be deleted is in the list
                    {
                        if (first == current)    //Case 2
                        {
                            first = first.link;

                            if (first == null)
                                last = null;

                            count--;
                        }
                        else                    //Case 3
                        {
                            trailCurrent.link = current.link;

                            if (current == last)
                                last = trailCurrent;

                            count--;
                        }
                    }
                    else                   //Case 4
                        System.out.println("Item to be deleted "
                                         + "is not in the list.");
            }
        }//end else
    }//end deleteNode
}