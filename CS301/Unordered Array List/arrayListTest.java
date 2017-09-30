    public class arrayListTest {
   
       public static void main(String args[]) {
      	int number;
			int count;
      
         UnorderedArrayList<Integer> UAL = new UnorderedArrayList<Integer>(100);
			UnorderedArrayList<String> SUAL = new UnorderedArrayList<String>(50);
			
			UAL.insertEnd(12);
			for(count = 0; count < 20; count++)
			{
				number = (int)(Math.random() * 101);
				UAL.insertEnd(number);
			}
			
			UAL.insertEnd(50);
			UAL.insertEnd(12);
			
			UAL.print();
			
			UAL.removeAt(10);
			
			UAL.removeAll(12);
			
			UAL.removeAll((int)(Math.random() * 101));
			
			UAL.print();
			
			System.out.println("The minimum value is " + UAL.min());
			System.out.println("The maximum value is " + UAL.max());
			
			SUAL.insertEnd("Micah");
			SUAL.insertEnd("Jake");
			SUAL.insertEnd("Lacy");
			SUAL.insertEnd("Allena");
			SUAL.insertEnd("Ryan");
			SUAL.insertEnd("The Great Bob Dole");
			
			System.out.println(SUAL.min() + " " + SUAL.max());

			SUAL.removeAt((int)(Math.random() * 6));
			
			SUAL.print();
     }
   
   }