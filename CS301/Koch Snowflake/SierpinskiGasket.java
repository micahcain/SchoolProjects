//Java program to draw a SierpinskiGasket

import java.awt.*;
import javax.swing.*;

public class SierpinskiGasket extends JApplet
{
	int level = 0;

	public void init()
	{
		this.setSize(600,600);
		
		String levelStr = JOptionPane.showInputDialog
                         ("Enter the recursion depth: ");

		level = Integer.parseInt(levelStr);
		
	}

	public void paint(Graphics g)
	{
		
		Point pointOne = new Point(100, 290);
		Point pointTwo = new Point(500, 290);
		Point pointThree = new Point(300, 50);

		drawSierpinski(g, level, pointOne, pointTwo, pointThree);
		g.drawString("" + level , 290 , 215);
	}

	private void drawSierpinski(Graphics g, int lev, Point p1, Point p2, Point p3)
	{
		Point midP1P2;
		Point midP2P3;
		Point midP3P1;

		if (lev >= 0)
		{
			g.drawLine(p1.x, p1.y, p2.x, p2.y);
			g.drawLine(p2.x, p2.y, p3.x, p3.y);
			g.drawLine(p3.x, p3.y, p1.x, p1.y);

			midP1P2 = midPoint(p1, p2);
			midP2P3 = midPoint(p2, p3);
 			midP3P1 = midPoint(p3, p1);

			drawSierpinski(g, lev - 1, p1, midP1P2, midP3P1);
			drawSierpinski(g, lev - 1, p2, midP2P3, midP1P2);
			drawSierpinski(g, lev - 1, p3, midP3P1, midP2P3);
		}
	}

	private Point midPoint(Point pOne, Point pTwo)
	{
		Point mid = new Point((pOne.x + pTwo.x) / 2,
		                      (pOne.y + pTwo.y) / 2 );

		return mid;
	}
}
