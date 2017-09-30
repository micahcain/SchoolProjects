//Program to test various operations on an ordered linked list
//32 76 34 89 86 12 190 21 5 55 -999

import java.util.*;

public class TestProgOrderedLinkedList
{
    static Scanner console = new Scanner(System.in);

    public static void main(String[] args)
    {
        OrderedLinkedList<Integer> list1
                 = new OrderedLinkedList<Integer>();  //Line 1
					  
		  OrderedLinkedList<Integer> list2
                 = new OrderedLinkedList<Integer>();
		  OrderedLinkedList<Integer> list3
		  			  = new OrderedLinkedList<Integer>();

        Integer num;                                  //Line 2

        System.out.println("Enter numbers for list 1 "
                         + "ending with -999");       //Line 3

        num = console.nextInt();                      //Line 4

        while (num != -999)                           //Line 5
        {
            list1.insert(num);                      //Line 6
            num = console.nextInt();                  //Line 7
        }
		  
		  System.out.println("Enter numbers for list 2 "
                         + "ending with -999");       //Line 3

        num = console.nextInt();                      //Line 4

        while (num != -999)                           //Line 5
        {
            list2.insert(num);                      //Line 6
            num = console.nextInt();                  //Line 7
        }
		  
		  list3.mergeList(list1, list2);
		  
		  list3.print();

  	}
	
}

