import java.awt.*;
import javax.swing.*;
public class Koch{
	public static void koch(int n, double size)
	{
		if (n == 0) StdDraw.goForward(size);
		else
		{
			koch(n-1, size);
			StdDraw.rotate(60);
			koch(n-1, size);
			StdDraw.rotate(-120);
			koch(n-1, size);
			StdDraw.rotate(60);
			koch(n-1, size);
		}
	}
	
	public static void main ( String[] args)
	{
		int N = Integer.parseInt(args[0]);
		int width = 512;
		int height = (int)(2 * width / Math.sqrt(3));
		double size = width / Math.pow(3.0, N);
		
		StdDraw.create(width, height);
		StdDraw.go(0, width * Math.sqrt(3) / 2);
		StdDraw.penDown();
		koch(N, size);
		StdDraw.rotate(-120);
		koch(N, size);
		StdDraw.rotate(-120);
		koch(N, size);
		StdDraw.show();
		}
	}