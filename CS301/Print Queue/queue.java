import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.event.*;
import java.util.*;
import java.io.*;
import java.util.StringTokenizer;
import java.util.Iterator;
import java.util.LinkedList;
import java.util.Queue;

public class queue
{

	private queue()
	{
		int arrayLen = getFileLength();
		String[] fileData = new String[arrayLen];
		fileData = fillArray(fileData);
		executePrinter(fileData);
	}

	private String[] fillArray(String[] fileData)
	{
		try
		{
			BufferedReader file = new BufferedReader(new FileReader("QueueIn.txt"));
			for(int i = 0; i < fileData.length; i++)
			{
				fileData[i] = file.readLine();
			}
			file.close();		
		}
		catch (IOException e)
		{
			JOptionPane.showMessageDialog(null, "File was not found.\nComplain to the IT department.");
			System.exit(1);
		}		
		return fileData;
	}

	private int getFileLength()
	{
		int i = 0;
		String placeHolder = "";
		try
		{
			 BufferedReader checkFile = new BufferedReader(new FileReader("QueueIn.txt"));
			 
			 while (checkFile.ready())
			 {
			 	placeHolder = checkFile.readLine();
			 	i++;
			 }
			 checkFile.close();
		}
		catch (IOException e)
		{
			JOptionPane.showMessageDialog(null, "File was not found.\nComplain to the IT department.");
			System.exit(1);
		}
		return i;
	 }
	 
private void executePrinter(String[] queue)
{
	queueNode[] printQu = new queueNode[queue.length];
	queueNode printer = new queueNode;
	
	
}
	 public static void main(String[] args)
   {
     queue Printer = new queue();
   }
	
	private class queueNode
			{
				int jobNumber;
				int time;
			}
	
}
	
