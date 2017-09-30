public class linkedlist
{
	static Node first;
	
	public static void main(String[] args)
	{
		populate();
	}
	
	public static void populate()
	{
		Node current = first;
		int num = 1;
		
		while(num <= 30)
		{
			if (first == null) {
				first = new Node();
				current = first;
			}
			else {
				current.link = new Node();
				current = current.link;
			}
				
			current.value = num;
			num++;
		}
		
		print();
	}
	
	public static void print()
	{
		Node current = first;
		while (current != null)
		{
			System.out.println(current.value);
			current = current.link;
		}
	}
}