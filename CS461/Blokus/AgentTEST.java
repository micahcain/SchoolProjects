//*****************************************************************************
//
//    AgentMARU.java
//    Author:   Micah Cain
//    Date:     3.10.2012
//
//    Agent1 uses the BlokusIO interface to play a game of Blokus.
//    Agent1 implements a recursive MinMax strategy that rates moves based
//    upon a calculated value of the strengths of the best moves at each
//    level for a specified number of levels.  The strengths are judged by:
//         1.  Length of possible move
//         2.  Distance from the center of the board
//    It is designed to play against opponents implementing other strategies.
//
//*****************************************************************************

   import java.io.*;

    public class AgentTEST {
      String AgentName;
      int BoardSize = 400;
      int levels = 3;
      int[][] BestMoveTable = new int[BoardSize][4];
   
      BlokusIO T = new BlokusIO();
       
       public AgentTEST(String name) {
         AgentName = name;
      }
   
       public void move() {
       
         String line = T.getBoard(AgentName);      
         
         String board = line.substring(0,400);
         int CurrentPlayer = Integer.parseInt(line.substring(400,403));
         int time = Integer.parseInt(line.substring(403,406));
      	
         int start = 0;
         int length = 0;
         int direction = 0;
      	   
      // Calculate Play
      
      //first move
      
         if (board.charAt(0)==' ' && CurrentPlayer==0) {
            start=0;
            direction=2;
            length=7;
         }
         else if (board.charAt(19)==' ' && CurrentPlayer==1) {
            start=19;
            direction=2;
            length=7;
         }
         else if (board.charAt(399)==' ' && CurrentPlayer==2) {
            start=399;
            length=7;
            direction=0;
         }
         else if (board.charAt(380)==' ' && CurrentPlayer==3) {
            start=380;
            length=7;
            direction=0;
         }
         else {
         
         //all other moves
         
            //find the lengths of all possible moves
            int MinMaxPossible[][] = new int[BoardSize][4];
            int MinMaxValue[][] = new int[BoardSize][4];
            MinMaxPossible = buildPossibleTable(board, CurrentPlayer);
            MinMaxValue = buildValueTable(MinMaxPossible, board, CurrentPlayer);
         	
         	//find the best possible move
            BestMoveTable = calcBestMove(board, CurrentPlayer, 3);
            printBestMoveTable();
         					
            int largest = 0;
            start = -1;
            length = 0;
            direction = 0;
         	
            for (int i=0; i<BoardSize; i++) {
               for (int j=0; j<4; j++) {
                  if (BestMoveTable[i][j] > largest) {
                     start = i;
                     length = (MinMaxValue[i][j]) / 100;
                     direction = j;
                     largest = BestMoveTable[i][j];
                  }
               }
            }
         }
         if (start >= 0)
            T.putMove(AgentName, start, length, direction);
         else
            T.putMove(AgentName, 0, 0, 0);
      }
          
       public static void main(String args[]) {
         AgentTEST A = new AgentTEST("TEST");
      
      // Play Forever
         while (true){
            A.move();
         }
      } 
   
       public int[][] calcBestMove(String board, int CurrentPlayer, int levels) {
         int[][] MoveTable = new int[BoardSize][4];	//my final board
         int[][] MoveTable1 = new int[BoardSize][4];  //me 
			int[][] MoveTable2 = new int[BoardSize][4];	//if the next player is as smart as me, it will make this move
         int[][] MoveTable3 = new int[BoardSize][4];
         int[][] MoveTable4 = new int[BoardSize][4];
         int[][] MoveTable5 = new int[BoardSize][4];	//me again
      
         if (levels>1) {
            MoveTable1 = calcBestMove(board, CurrentPlayer, levels-1);
            board = placeMove(MoveTable, board, CurrentPlayer); 
            MoveTable2 = calcBestMove(board, (CurrentPlayer+1)%4, levels-1);
            board = placeMove(MoveTable, board, (CurrentPlayer+1)%4); 
            MoveTable3 = calcBestMove(board, (CurrentPlayer+2)%4, levels-1);
            board = placeMove(MoveTable, board, (CurrentPlayer+2)%4); 
            MoveTable4 = calcBestMove(board, (CurrentPlayer+3)%4, levels-1);
            board = placeMove(MoveTable, board, (CurrentPlayer+3)%4);
            MoveTable5 = calcBestMove(board, (CurrentPlayer+4)%4, levels-1);
         
         //Evaluate them
         
            int largest = 0;
            for (int i=0; i<BoardSize; i++) {
               for (int j=0; j<4; j++) {
                  if (MoveTable5[i][j] > largest) {
                     largest = MoveTable5[i][j];
                  }
               }
            }
         
            for (int i=0; i<BoardSize; i++) {
               for (int j=0; j<4; j++) {
                  if (MoveTable1[i][j] > 0) {
                     MoveTable[i][j] = MoveTable1[i][j] + largest;
                  }
                  else {
                     MoveTable[i][j] = 0;
                  }
               }
            }
         }
         else {
            MoveTable = calcBestNextMove(board, CurrentPlayer, levels);
         }
         return MoveTable;
      }
      
       public String placeMove(int[][] MoveTable, String Board, int CurrentPlayer) {
      
         int largest = 0;
         int start = -1;
         int length = 0;
         int direction = 0;
      
         for (int i=0; i<BoardSize; i++) {
            for (int j=0; j<4; j++) {
               if (MoveTable[i][j] > largest) {
                  start = i;
                  length = BestMoveTable[i][j] / 100;
                  direction = j;
                  largest = BestMoveTable[i][j];
               }
            }
         }
       
         int CurrentPosition = start;
         for (int i=0; i<length; i++) {  
            if (CurrentPosition==0)
               Board=String.valueOf(CurrentPlayer)+Board.substring(CurrentPosition+1,BoardSize);
            else
               Board=Board.substring(0,CurrentPosition)+String.valueOf(CurrentPlayer)+Board.substring(CurrentPosition+1,BoardSize);
            if (direction==0) {
               CurrentPosition = CurrentPosition - 20;
            }  
            else if (direction==1) {
               CurrentPosition++;
            }
            else if (direction==2) {
               CurrentPosition = CurrentPosition + 20;
            }
            else if (direction==3) {
               CurrentPosition--;
            }
         }
         return Board;
      }
   
       public int[][] calcBestNextMove(String board, int CurrentPlayer, int levels) {
         int[][] MoveTable = new int[BoardSize][4];
       	//recursively predict just the best next move  
         int MinMaxPossible[][] = new int[BoardSize][4];
         int MinMaxValue[][] = new int[BoardSize][4];
         
         MinMaxPossible = buildPossibleTable(board, CurrentPlayer);
         //printMinMaxPossibleTable(MinMaxPossible);
         MinMaxValue = buildValueTable(MinMaxPossible, board, CurrentPlayer);
         //printMinMaxValueTable(MinMaxValue);
            	
         for (int i=0; i<BoardSize; i++) {
            for (int j=0; j<4; j++) {
               MoveTable[i][j] = MinMaxValue[i][j];
            }
         }
         
         return MoveTable;
      }
   
       public void printBestMoveTable() {
      
         for (int i=0; i<BoardSize; i++) {
            System.out.print(i+"  ");
            for(int j=0; j<4; j++) {
               System.out.print(BestMoveTable[i][j]);
            }
            System.out.println();
         }
      }
   
       public void printMinMaxPossibleTable(int[][] MinMaxPossible) {
      
         for (int i=0; i<BoardSize; i++) {
            System.out.print(i+"  ");
            for(int j=0; j<4; j++) {
               System.out.print(MinMaxPossible[i][j]);
            }
            System.out.println();
         }
      }
      
       public void printMinMaxValueTable(int[][] MinMaxValue) {
      
         for (int i=0; i<BoardSize; i++) {
            System.out.print(i+"  ");
            for(int j=0; j<4; j++) {
               System.out.print(MinMaxValue[i][j]);
            }
            System.out.println();
         }
      }
   
       public boolean adjacent(int start, String board, int CurrentPlayer) {
         boolean valid = true;
         if ((start-20>=0) && ((start-20)%20==start%20) && (board.charAt(start-20)==String.valueOf(CurrentPlayer).charAt(0))) {
            valid = false;
         }	
         if ((start-1>=0) && ((start-1)/20==start/20) && (board.charAt(start-1)==String.valueOf(CurrentPlayer).charAt(0))) {
            valid = false;
         }	
         if ((start+1<BoardSize) && ((start+1)/20==start/20) && (board.charAt(start+1)==String.valueOf(CurrentPlayer).charAt(0))) {
            valid = false;
         }	
         if ((start+20<BoardSize) && ((start+20)%20==start%20) && (board.charAt(start+20)==String.valueOf(CurrentPlayer).charAt(0))) {
            valid = false;
         }	
         return valid;		
      }
       
       public int[][] buildValueTable(int[][] MinMaxPossible, String board, int CurrentPlayer) {
         int[][] MinMaxValue = new int[BoardSize][4];
         
         for (int i=0; i<BoardSize; i++) {
            for(int j=0; j<4; j++) {
               MinMaxValue[i][j] = 0;
            }
         }
      
         int r = 0;      
         for (int i=0; i<BoardSize; i++) {
            for(int j=0; j<4; j++) {
               if (MinMaxPossible[i][j]==0) {
               
               //Calculate values for every direction
               
                  if (j==0)
                     r = i-20-1;
                  else if (j==1)
                     r = i-20+1;
                  else if (j==2)
                     r = i+20-1;
                  else if (j==3)
                     r = i+20+1;	
                  for (int k=0; k<4; k++) {
                     int length = longest(r, k, board, CurrentPlayer);
                     MinMaxValue[r][k] = longest(r, k, board, CurrentPlayer)*100;
                  
                  	//Add a factor for closeness to center
                  	//This will generate a "fudge" with a value roughly from 0-94
                  	
                     int CurrentSquare = r;
                     for (int l=0; l<length; l++) {
                        MinMaxValue[r][k] += (int)(13.44 - (Math.pow( Math.pow((CurrentSquare%20)-9.5, 2) + Math.pow((CurrentSquare/20)-9.5, 2), 0.5))); 
                        System.out.println(MinMaxValue[r][k]);
                        if (j==0)
                           CurrentSquare = CurrentSquare - 20;
                        else if (j==1)
                           CurrentSquare = CurrentSquare + 1;
                        else if (j==2)
                           CurrentSquare = CurrentSquare + 20;
                        else if (j==3)
                           CurrentSquare = CurrentSquare - 1;
                     }
                  }
               }
            }
         }
         return MinMaxValue;
      }
   	 
       public int longest(int start, int direction, String board, int CurrentPlayer) {
         
       //must calculate which values are still available
       
         int[] number = {0, 1, 1, 5, 5, 3, 3, 3};
         String testBoard = board;
         for (int i=0; i<BoardSize; i++) {
            if (testBoard.charAt(i)==(String.valueOf(CurrentPlayer)).charAt(0)) {
            //find direction
               int dir = 0;
               if (i+20<BoardSize && testBoard.charAt(i+20)==(String.valueOf(CurrentPlayer)).charAt(0))
                  dir = 2;
               else
                  dir = 1;
            //find its length	
               int length = 0;
               int CurrentPosition = i;
               while (length<7 && testBoard.charAt(CurrentPosition)==(String.valueOf(CurrentPlayer)).charAt(0)) {
                  if (CurrentPosition==0)
                     testBoard=" "+testBoard.substring(CurrentPosition+1,BoardSize);
                  else
                     testBoard=testBoard.substring(0,CurrentPosition)+" "+testBoard.substring(CurrentPosition+1,BoardSize);
                  length++;
                  if (dir==2)
                     CurrentPosition += 20;
                  else {
                     if (CurrentPosition/20 != (CurrentPosition+1)/20) {
                        break;
                     }
                     CurrentPosition += 1;
                  }
                  if (CurrentPosition >= BoardSize) 
                     break;
               }
               number[length]--;
            }
         }  
      	
         //largest still available is
      	
         int largest=0;
         for (int i=7; i>=0; i--) {
            if (number[i] > 0) {
               largest = i;
               break;
            }
         }      	
      
         boolean valid = true;
         int length = 1;
         for (int i=0; i<largest-1; i++) {
            if (direction==0) {
               start = start-20;
               if (start<0 || board.charAt(start)!=' ' || !adjacent(start, board, CurrentPlayer)) valid = false;
            }
            else if (direction==1) {
               start = start+1;
               if ((start-1)/20 != start/20 || board.charAt(start)!=' ' || !adjacent(start, board, CurrentPlayer)) valid = false;
            }
            else if (direction==2) {
               start=start+20;
               if (start>BoardSize-1 || board.charAt(start)!=' ' || !adjacent(start, board, CurrentPlayer)) valid = false;
            }
            else if (direction==3) {
               start=start-1;
               if ((start+1)/20 != start/20 || board.charAt(start)!=' ' || !adjacent(start, board, CurrentPlayer)) valid = false;
            }
            if (!valid)
               break;
            length++;
         }
         
      	//try to use the largest still available
      	
         while (length > 0 && number[length] == 0)
            length--;	
      	
         return length;
      }
   		 
       public int[][] buildPossibleTable(String board, int CurrentPlayer) {
         int[][] MinMaxPossible = new int [BoardSize][4];
         
         for (int i=0; i<BoardSize; i++) {
            for(int j=0; j<4; j++) {
               MinMaxPossible[i][j] = -1;
            }
         }
      
         int start = 0;
         boolean valid = false;
         for (int i=0; i<BoardSize; i++) {
            if (((int)board.charAt(i)-(int)'0')==CurrentPlayer) {
               
               int TestPosition = i;
               valid = false;
             
            //find a possible
                  
            	//find an empty
                  
               if (((TestPosition-20-1)/20==(TestPosition-20)/20) && (TestPosition-20-1>0) && (board.charAt(TestPosition-20-1)==' ')) {
                  
               	//is it adjacent to same color?
                  
                  start=TestPosition-20-1;
                  if (adjacent(start, board, CurrentPlayer)) {
                     MinMaxPossible[i][0] = 0;
                  }
               }	
               if (((TestPosition-20+1)/20==(TestPosition-20)/20) && (TestPosition-20+1>0) && (board.charAt(TestPosition-20+1)==' ')) {
                  start=TestPosition-20+1;
                  if (adjacent(start, board, CurrentPlayer)) {
                     MinMaxPossible[i][1] = 0;
                  }
               }	
               if (((TestPosition+20-1)/20==(TestPosition+20)/20) && (TestPosition+20-1<BoardSize) && (board.charAt(TestPosition+20-1)==' ')) {
                  start=TestPosition+20-1;
                  if (adjacent(start, board, CurrentPlayer)) {
                     MinMaxPossible[i][2] = 0;
                  }
               }	
               if (((TestPosition+20+1)/20==(TestPosition+20)/20) && (TestPosition+20+1<BoardSize) && (board.charAt(TestPosition+20+1)==' ')) {
                  start=TestPosition+20+1;
                  if (adjacent(start, board, CurrentPlayer)) {
                     MinMaxPossible[i][3] = 0;
                  }
               }      
            }
         }
         return MinMaxPossible;		 
      }
   }
