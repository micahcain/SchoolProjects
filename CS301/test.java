import java.awt.*;
import javax.swing.*;

public class test
{

public static void main(String[] args)
{
	int level = Integer.parseInt(JOptionPane.showInputDialog("Enter a number por favor!"));
	System.out.println(fact(level));
	
}


public static double fact(double i){

if (i == 1)
return 1;
else
{
System.out.println("i = " + i);
double f = i * fact(i - 1);

return f;
}
}
}