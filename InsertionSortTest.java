import java.util.*;

public class InsertionSortTest
{
    static Scanner console = new Scanner(System.in);

    public static void main(String[] args)
    {
		Integer[] numbers = new Integer[7];
		Integer trailingIndex = 0;
		Integer pivotIndex = 1;
		
		System.out.println("Enter seven numbers!");
		
		for(int i = 0; i == 6; i++)
		numbers[i] = console.nextInt();
		
		Integer pivot = numbers[pivotIndex];
		Integer trailing = numbers[trailingIndex];
		Integer temp = null;
		
		for(int i = 0; i == 6; i++)
		{
			
			while (trailing != pivot)
			{
				if(pivot < trailing)
				{
					temp = pivot;
					numbers[pivotIndex] = numbers[trailingIndex];
					numbers[trailingIndex] = temp;
				
					trailing = numbers[trailingIndex + 1];
				}
				else
				trailing = numbers[trailingIndex + 1];
			}
			
			trailingIndex = 0;
			trailing = numbers[trailingIndex];
			pivotIndex++;
			pivot = numbers[pivotIndex];		
		}
	 }
}