//Java program to draw a Koch Snowflake
//*************************************
//* Programmer: Micah Cain            *
//* Class:      CS 301                *
//* Semester:   Fall 2010             *
//*************************************
import java.awt.*;
import javax.swing.*;

public class Koch2 extends JApplet
{
	int level = 0;
	int max;

	public void init()
	{
		this.setSize(800,600);
		
		String levelStr = JOptionPane.showInputDialog
                         ("Enter the recursion depth:");
		
		try
		{
   		level = Integer.parseInt(levelStr);
   		max = level;
   		level = 1;
		}
		catch (Exception e)
		{
         System.exit(0);
		   //JOptionPane.showMessageDialog(null, "You must enter a numeric value!");
		}
		
	}
   
   

	public void paint(Graphics g)
	{
		g.setColor(Color.red);
		g.fillRect(0,0,800,600);
		g.setColor(Color.black);
		Point pointOne = new Point(150,150); //build the triangle
		Point pointTwo = new Point(150,450);
		Point pointThree = new Point(550,450);
		Point pointFour= new Point(550,150);
		Point pointFive = new Point(360, 300); //build the triangle
		Point pointSix = new Point(520, 300);
		Point pointSeven = new Point(440, 160);
		
		drawKoch(g, level,max, pointOne, pointTwo);// call drawKoch for each of the three sides
		drawKoch(g, level,max, pointTwo, pointThree);
		drawKoch(g, level,max, pointThree, pointFour);
		drawKoch(g, level,max, pointFour, pointOne);
		
		drawKoch(g, level, max, pointFive, pointSix);// call drawKoch for each of the three sides
		drawKoch(g, level, max, pointSix, pointSeven);
		drawKoch(g, level, max, pointSeven, pointFive);
      
      init();
      paint(g);
	}
	
	private void drawKoch(Graphics g, int lev, int max, Point point1, Point point5)
	{
		
		int deltaX = point5.x - point1.x; // distance between the two points in terms of x & y
		int deltaY = point5.y - point1.y;
		
		Point point2 = new Point((int)(point1.x + deltaX / 3),(int)( point1.y + deltaY / 3)); // the first point
		
		Point point3 = new Point((int)(.5 * (point1.x + point5.x) + Math.sqrt(3) * (point1.y - point5.y) / 6), // the second point
												(int)(.5 * (point1.y + point5.y) + Math.sqrt(3) * (point5.x - point1.x) / 6));
		
		Point point4 = new Point(point1.x + 2 * deltaX / 3, point1.y + 2 * deltaY / 3); //the third point
		
		if (lev < max)
		{
		
		//function calls for the next set of points & lines
		drawKoch(g, lev + 1, max, point1, point2);
		drawKoch(g, lev + 1, max, point2, point3);
		drawKoch(g, lev + 1, max, point3, point4);
		drawKoch(g, lev + 1, max, point4, point5);
		}
		
		if (lev == max)
		{
		// draw the lines
		g.drawLine(point1.x, point1.y, point2.x, point2.y);
		g.drawLine(point2.x, point2.y, point3.x, point3.y);
		g.drawLine(point3.x, point3.y, point4.x, point4.y);
		g.drawLine(point4.x, point4.y, point5.x, point5.y);
		}
	}
}