//Java program to draw a Koch Snowflake
//*************************************
//* Programmer: Micah Cain            *
//* Class:      CS 301                *
//* Semester:   Fall 2010             *
//*************************************
import java.awt.*;
import javax.swing.*;

public class Koch extends JApplet
{
	int level = 0;
	int max = 0;

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
		JOptionPane.showMessageDialog(null, "You must enter a numeric value!");
		}
		
	}

	public void paint(Graphics g)
	{
		g.setColor(Color.white);
		g.fillRect(0,0,800,600);
		g.setColor(Color.black);
		Point pointOne = new Point(360, 300); //build the triangle
		Point pointTwo = new Point(520, 300);
		Point pointThree = new Point(440, 160);
		
		if (max == 0)
		{
		g.drawLine(pointOne.x, pointOne.y, pointTwo.x, pointTwo.y);
		g.drawLine(pointTwo.x, pointTwo.y, pointThree.x, pointThree.y);
		g.drawLine(pointThree.x, pointThree.y, pointOne.x, pointOne.y);
		}
		else
		{		
		drawKoch(g, level, max, pointOne, pointTwo);// call drawKoch for each of the three sides
		drawKoch(g, level, max, pointTwo, pointThree);
		drawKoch(g, level, max, pointThree, pointOne);
		}
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