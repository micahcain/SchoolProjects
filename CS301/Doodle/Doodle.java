//***************************************************************
//
//  title:   Doodle
//  author:  Micah Cain
//  date:    9-17-09
//
//  The doodle program allows people to draw freehand pictures in
//  a window using the mouse.  There are eight choices of color. 
//  The image cannot be saved or printed.
//***************************************************************

	import java.awt.*;
	import java.awt.event.*;
   import java.awt.Color;
   import java.awt.Graphics;
   import java.awt.Rectangle;
   import java.awt.event.MouseEvent;
   import java.awt.event.MouseListener;
   import java.awt.event.MouseMotionListener;
   import java.awt.event.ActionListener;
   import javax.swing.*;
   import javax.swing.JOptionPane;
   import java.awt.Button;

   public class Doodle extends    JApplet
                    	  implements MouseListener, MouseMotionListener, ActionListener
   {
   
      private int       myLastX;          // previous mouse location
      private int       myLastY;
		private int       x;
		private int       y;
      private int       randomVar;       // is the color random?
		private int       lineThickness = 1;// how thick is the line?
   
      private Color     myCurrentColor;   // current drawing color
   
      private Rectangle myRedPalette;     // palette
      private Rectangle myBlackPalette;
      private Rectangle myBluePalette;
      private Rectangle myGreenPalette;
      private Rectangle myOrangePalette;
      private Rectangle myYellowPalette;
      private Rectangle myGreyPalette;
      private Rectangle myRandomPalette;
		
		private Button clearButton;          //Buttons
		private Button thickness;
		

		
	
		
   
   //---------- init ---------------------------------------------
   // Initialize the mouse pointer and create the palette.
   
      public void init ()
      {	
			Container c = getContentPane();
			BorderLayout b = new BorderLayout(800,560);
			GridLayout grid = new GridLayout(0,2);
			JPanel bottom = new JPanel();
			bottom.setLayout(grid);
			c.setLayout(b);
			this.setSize(801,500);
			
			clearButton = new Button("Clear");			
			clearButton.addActionListener(this);
			
			
			thickness = new Button("Line Thickness");
			thickness.addActionListener(this);
			
			bottom.add(clearButton);
			bottom.add(thickness);
			c.add(bottom, BorderLayout.SOUTH);
			
			
	   // set last mouse position
         myLastX = 0;
         myLastY = 0;
      
      // initialize drawing color
         randomVar = 1;
				
      
      // create palette
         myRedPalette   = new Rectangle (  0, 425, 100, 50);
         myBlackPalette = new Rectangle ( 100, 425, 100, 50);
         myBluePalette = new Rectangle  ( 200 ,425,100, 50);
         myGreenPalette = new Rectangle ( 300 ,425, 100, 50);
         myOrangePalette = new Rectangle (400, 425, 100, 50);
         myYellowPalette = new Rectangle (500,425, 100, 50);
         myGreyPalette = new Rectangle (600,425,100,50);
         myRandomPalette = new Rectangle (700, 425, 100, 50);
      
         addMouseListener(this);
         addMouseMotionListener(this);
      }
				
   
   //---------- paint --------------------------------------------
   // Draw the palette
   //
   // Note: when the drawing window is resized or covered, the
   // image may be lost because paint cannot redraw it.
   
      public void paint (Graphics g) {
		
		super.paint(g);
		g.setColor(Color.white);
		g.fillRect(0,0,801,500);	
		
		
		// create a random color for the random palette
			int randOne =   ((int)(Math.random() * 256));
			int randTwo =   ((int)(Math.random() * 256));
			int randThree = ((int)(Math.random() * 256));
			Color rand = new Color(randOne, randTwo, randThree);
			
			g.setColor(Color.red);
         g.fillRect(myRedPalette.x, myRedPalette.y,
               myRedPalette.width, myRedPalette.height);
         g.setColor(Color.black);
         g.fillRect(myBlackPalette.x, myBlackPalette.y,
               myBlackPalette.width, myBlackPalette.height);
         g.setColor(Color.blue);
         g.fillRect(myBluePalette.x, myBluePalette.y,
               myBluePalette.width, myBluePalette.height);
         g.setColor(Color.green);
         g.fillRect(myGreenPalette.x, myGreenPalette.y,
               myGreenPalette.width, myGreenPalette.height);
         g.setColor(Color.orange);
         g.fillRect(myOrangePalette.x, myOrangePalette.y,
               myOrangePalette.width, myOrangePalette.height);
         g.setColor(Color.yellow);
         g.fillRect(myYellowPalette.x, myYellowPalette.y,
               myYellowPalette.width, myYellowPalette.height);
         g.setColor(Color.gray);
         g.fillRect(myGreyPalette.x, myGreyPalette.y,
               myGreyPalette.width, myGreyPalette.height);
			g.setColor(rand);
			g.fillRect(myRandomPalette.x, myRandomPalette.y,
							myRandomPalette.width, myRandomPalette.height);
         g.drawString("Color Palette", 360, 420);
      
      }
		
	//---------actionEvent-------------------------------------------
	//Handles the clearing of the canvas when the clear button is
	//pressed as well as the changing of the line thickness
	
	public void actionPerformed(ActionEvent event)
	{
		Object obj = event.getSource();

		if(obj == clearButton)
		{
			setBackground(Color.white);
			Graphics g = getGraphics();
			g.setColor(Color.white);
			g.fillRect(0,0,801,406);
		}
		
		if(obj == thickness)
		{
			try
			{
				lineThickness = Integer.parseInt(((JOptionPane.showInputDialog("Enter number for line thickness: "))));
			}
			catch (Exception e)
			{
				JOptionPane.showMessageDialog(null, "You must enter a numeric value to change the line thickness!");
			}
		}						
	}
		
   
   //---------- mousePressed ---------------------------------------
   // Reset the mouse location and select a color from the
   // palette.
   
      public void mousePressed(MouseEvent e)
      {
         x = e.getX();
         y = e.getY();
      
      // reset last mouse position
         myLastX = x;
         myLastY = y;
      
      // select a color
         if (myRedPalette.contains(x,y))
         {
            myCurrentColor = Color.red;
            randomVar = 0;
         }
         if (myBlackPalette.contains(x,y))
         {
            myCurrentColor = Color.black;
            randomVar = 0;
         }
         if (myBluePalette.contains(x,y))
         {
            myCurrentColor = Color.blue;
            randomVar = 0;
         }
         if (myGreenPalette.contains(x,y))
         {
            myCurrentColor = Color.green;
            randomVar = 0;
         }
         if (myOrangePalette.contains(x,y))
         {
            myCurrentColor = Color.orange;
            randomVar = 0;
         }	
         if (myYellowPalette.contains(x,y))
         {
            myCurrentColor = Color.yellow;
            randomVar = 0;
         }	
         if (myGreyPalette.contains(x,y))
         {
            myCurrentColor = Color.gray;
            randomVar = 0;
         }
         if (myRandomPalette.contains(x,y))
            if (randomVar == 1)
               randomVar = 0;
            else
               randomVar = 1;
      }
   
   //---------- mouseDragged --------------------------------------
   // Draw the doodle.
   
      public void mouseDragged(MouseEvent e)
      {
         x = e.getX();
         y = e.getY();
         int randomColorOne = (int)(Math.random() * 256);
         int randomColorTwo = (int)(Math.random() * 256);
         int randomColorThree = (int)(Math.random() * 256);
			int thick = 0;
			
			Color randomColor = new Color(randomColorOne, randomColorTwo, randomColorThree);
			Graphics g = getGraphics();
			g.setColor(randomColor);
			
			if (randomVar == 1)
			{
         	g.setColor(randomColor);
				g.fillRect(myRandomPalette.x, myRandomPalette.y,
							myRandomPalette.width, myRandomPalette.height);
				g.drawString("Color Palette", 360, 420);
							}
         else
			{
         	g.setColor(myCurrentColor);
				g.drawString("Color Palette", 360, 420);
			}
			
			
      if ((myLastX + thick <=800) && (myLastY + thick <= 398) && (myLastX <= 800)
		 			&& (myLastY <= 398) && (x + thick <= 800) && (x <= 800)
		 			&& (y <= 398) && (800 - (myLastX + thick) <= 800) && (398 - myLastY <= 398) &&
		 			(800 - (x + thick) <= 800) && (398 - y <= 398))
    
		 {      
			   while (thick <= lineThickness)
				{     
					
					{
					g.drawLine(myLastX + thick, myLastY , x + thick, y );
					g.drawLine(800 - (myLastX + thick), myLastY, 800 - (x + thick), y);
					g.drawLine(myLastX + thick, 398 - myLastY, x + thick, 398 - y);
					g.drawLine(800 - (myLastX + thick), 398 - myLastY, 800 - (x + thick), 398 - y);
					thick++;
					}
						
				}
					myLastX = x;
            	myLastY = y;
		 		
		}
		}
      public void mouseReleased(MouseEvent e) {}
      public void mouseClicked(MouseEvent e) 
      {
        x = e.getX();
        y = e.getY();
      
         Graphics g = getGraphics();
      
         if ((x <= 800 && y <= 398) && (e.getClickCount() == 2))
			{
         	g.drawRect(x,y,10,10);
				
			}
      }
	// Unused methods from "MouseListener"
      public void mouseEntered(MouseEvent e) {}
      public void mouseExited(MouseEvent e) {}
		
		
      public void mouseMoved(MouseEvent e) 
		{
			x = e.getX();
         y = e.getY();
		}
   }
