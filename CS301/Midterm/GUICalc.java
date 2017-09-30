import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class GUICalc extends JFrame
{
private JButton PlusB;

private PlusBHandler PlusHandler;

public GUICalc()
{

//create Calculate Button
PlusB = new JButton("+");
PlusHandler = new PlusBHandler();
PlusB.addActionListener(PlusHandler); 

//Set the title of the window
setTitle("GUI Calculator");

//Get the container
Container pane = getContentPane();

//Set the layout
pane.setLayout(new GridLayout(2,2));

//Place all items created
pane.add(PlusB);

//set the size of the window and display it
setSize(100,100);
setVisible(true);
setDefaultCloseOperation(EXIT_ON_CLOSE);
}

private class PlusBHandler implements ActionListener
{
public void actionPerformed(ActionEvent e)
{
System.out.println("Hello");
}
}

public static void main(String[] args)
{
GUICalc rectObject = new GUICalc();
}
}