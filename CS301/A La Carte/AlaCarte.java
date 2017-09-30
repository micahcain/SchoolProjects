//Bent Twig Café
//This program offers users a list of 
//menu choices and generates a bill based on
//user selections. A day end report can
//be generated to display total sales and
//tax collected at a given time.

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.event.*;
import java.util.*;
import java.io.*;

public class AlaCarte extends JFrame implements ActionListener
{
 	int arrayLen = getFileLength("Menu.txt");
	
	String[] yourChoicesItems = new String[arrayLen];
	String[] unsortedMenu = new String[arrayLen];
	double[] yourChoicesPrices = new double[arrayLen];
									 
	private static final double STATE_TAX = .06;
	private static final double LOCAL_TAX = .01;
	
	private double salesTotal;
	private double taxTotal;
	
	private String password;
	
   private JList yourChoices;
   private JTextArea  bill;

   private Container pane;
	private JPanel lowerPane = new JPanel();

   private AlaCarte()
   {
      super("Bent Twig Café");
		
		getMenu();
		sortMenu();

         //Get the content pane and set its background color
         //and layout manager.
      pane = getContentPane();
      pane.setBackground(new Color(200, 200, 200));
      pane.setLayout(new BorderLayout(5, 5));
		lowerPane.setLayout(new GridLayout(2,0));
          //Create a label and place it at NORTH. Also
          //set the font of this label.
      JLabel yourChoicesJLabel = new JLabel("Choose Wisely",null,JLabel.CENTER);
      pane.add(yourChoicesJLabel,BorderLayout.NORTH);
      yourChoicesJLabel.setFont(new Font("Dialog",Font.BOLD,20));

          //Create a list and place it at WEST. Also
          //set the font of this list.
  		DefaultListModel model = new DefaultListModel();  
		model.setSize(150);   
		yourChoices = new JList(model);
		displayMenu(model);
		yourChoices.setSize(100,450);
      pane.add(new JScrollPane (yourChoices),BorderLayout.WEST);
      yourChoices.setFont(new Font("Courier",Font.BOLD,14));

          //Create a text area and place it at EAST. Also
          //set the font of this text area.
      bill = new JTextArea();
      pane.add(bill,BorderLayout.CENTER);
      bill.setFont(new Font("Courier",Font.PLAIN,12));

          //Create a button and place it in the SOUTH region and
          //add an action listener.
      JButton checkOutButton = new JButton("Selection Completed");
		JButton managersConsoleButton = new JButton("Manager's Console");
      lowerPane.add(checkOutButton);
		lowerPane.add(managersConsoleButton);
		pane.add(lowerPane, BorderLayout.EAST);
      checkOutButton.addActionListener(this);
		managersConsoleButton.addActionListener(this);

      setSize(875,675);
      setVisible(true);
      setDefaultCloseOperation(EXIT_ON_CLOSE);
		
	
   }  
	
	private void displayMenu(DefaultListModel model)
	{
		for (int i = 0; i < yourChoicesItems.length; i++)
		{
			model.add(i, yourChoicesItems[i] + " $" + String.format("%.2f", yourChoicesPrices[i]));
		}
	}
	private int getFileLength(String fileName)
	{
		int i = 0;
		String placeHolder = "";
		try
		{
			 BufferedReader file = new BufferedReader(new FileReader(fileName));
			 
			 while (file.ready())
			 {
			 	placeHolder = file.readLine();
			 	i++;
			 }
			 file.close();
		}
		catch (IOException e)
		{
			JOptionPane.showMessageDialog(null, "File was not found.\nComplain to the IT department.");
			System.exit(1);
		}	

		return i;
	}	
	
	public void getMenu()
	{
	
		int i = 0;
		try
		{
			 BufferedReader menuFile = new BufferedReader(new FileReader("menu.txt"));
			 
			 while (menuFile.ready())
			 {
			 	unsortedMenu[i] = menuFile.readLine();
			 	i++;
			 }
			 menuFile.close();
		}
		catch (IOException e)
		{
			JOptionPane.showMessageDialog(null, "Menu file was not found.\nComplain to the IT department.");
			System.exit(0);
		}	
	}	
	
	public void sortMenu()
	{
		Arrays.sort(unsortedMenu);
		
		for (int j = 0; j < unsortedMenu.length; j++)
		{
			String current = unsortedMenu[j];
			StringTokenizer token = new StringTokenizer(current,"*");
			yourChoicesItems[j] = token.nextToken();
			yourChoicesPrices[j] = Double.parseDouble(token.nextToken());			
		}
	}
	      //Method to display the order and the total cost.
   private void displayBill()
   {
      int[] listArray = yourChoices.getSelectedIndices();
      double tax;
      double subTotal = 0;
      double total;
		int fileLen = getFileLength("receipt.txt");
		String[] receiptMessage = new String[fileLen];
		int messageNumber = (int)(Math.random() * fileLen);
		
		if (listArray.length == 0)
		JOptionPane.showMessageDialog(null, "You can't buy nothing man!");
		else
		{		
		try
		{
		BufferedReader messageFile = new BufferedReader(new FileReader("receipt.txt"));
		
		for (int i = 0; i < fileLen; i++)
		{
			receiptMessage[i] = messageFile.readLine();
		}
		messageFile.close();
		}
		catch (IOException e)
		{
		JOptionPane.showMessageDialog(null, "Message file was not found.\nComplain to the IT department.");
		} 

         //Set the text area to non-edit mode and start
         //with an empty string.
      bill.setEditable(false);
      bill.setText("");

          //Calculate the cost of the items ordered.
      for (int index = 0; index < listArray.length; index++)
          subTotal = subTotal
                     + yourChoicesPrices[listArray[index]];

      tax = (LOCAL_TAX * subTotal) + (STATE_TAX * subTotal);
      total = subTotal + tax;

          //Display the costs.
      bill.append("\tTRANSACTION REPORT: BENT TWIG\n\n");
      bill.append("--------------- Welcome ----------------\n\n");

      for (int index = 0; index < listArray.length; index++)
      {
         bill.append(yourChoicesItems[listArray[index]] + "\n");
      }

      bill.append("\n");
      bill.append("SUB TOTAL\t\t$"
                 + String.format("%.2f", subTotal) + "\n");
      bill.append("STATE TAX      \t\t$"
                 + String.format("%.2f", subTotal * STATE_TAX) + "\n");
		bill.append("LOCAL TAX      \t\t$"
                 + String.format("%.2f", subTotal * LOCAL_TAX) + "\n");
      bill.append("TOTAL    \t\t$"
                 + String.format("%.2f", total) + "\n\n");
      bill.append(receiptMessage[messageNumber] + "\n\n");

          //Reset list array.
      yourChoices.clearSelection();
		
		salesTotal = salesTotal + subTotal;
		taxTotal = taxTotal + tax;

      repaint();
		}
   }

   public void actionPerformed(ActionEvent event)
   {
      if(event.getActionCommand().equals("Selection Completed"))
         displayBill();
		else if (event.getActionCommand().equals("Manager's Console"))
				checkPWordAndOpen();	
	}
	
	private void checkPWordAndOpen()
	{
		password = (String)JOptionPane.showInputDialog("Enter the manager's password :");
		
		try
		{
		if (password.compareTo("password") == 0)
		{
			bill.setEditable(false);
      	bill.setText("");
			bill.append("           MANAGER'S DAY END REPORT\n\n");
      	bill.append("SALES TOTAL FOR THE DAY\t\t$"
                 + String.format("%.2f", salesTotal) + "\n");
			bill.append("TAX COLLECTED FOR THE DAY\t$"
                 + String.format("%.2f", taxTotal) + "\n");
					  
			repaint();
			salesTotal = 0;
			taxTotal = 0;
		}
		else
			JOptionPane.showMessageDialog(null, "The password you entered is incorrect\nThe correct password is \"password\"");
		}
		catch (NullPointerException e)
		{
		}
	}

   public static void main(String[] args)
   {
      AlaCarte alc = new AlaCarte();
   }
}