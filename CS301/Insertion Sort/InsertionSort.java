//Program to execute an insertion sort on a linked list.

import java.util.*;

public class InsertionSort
{
    static Scanner console = new Scanner(System.in);

    public static void main(String[] args)
    {
        OrderedLinkedList<Integer> sortTest = new OrderedLinkedList<Integer>();
        Integer num;
		  
        System.out.println("Enter your most favorite numbers. End input with -999.");

        num = console.nextInt();
        while (num != -999)
        {
            sortTest.insertLast(num);
            num = console.nextInt();
        }
		  
		  sortTest.insertSort();
		  System.out.print(sortTest.first.info + " ");
		  System.out.print(sortTest.first.link.info + " ");
		  System.out.print(sortTest.first.link.link.info + " ");
		  sortTest.print();
		  
  	}
	
}

