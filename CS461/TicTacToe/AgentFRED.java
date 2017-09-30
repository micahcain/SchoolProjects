//*****************************************************************************
//
//    Agent5.java
//    Author:   Scott Anderson
//    Date:     01/17/2007
//
//    Agent5 uses the TicTacToeIO interface to play a game of TicTacToe.
//    Agent5 implements a random strategy, that is, it moves randomly
//    into any available position regardless of current board positions.
//    It is designed to play against opponents implementing other strategies.
//
//*****************************************************************************

   import java.io.*;

    public class AgentFRED {
      String AgentName;
      TicTacToeIO T = new TicTacToeIO();
       
       public AgentFRED(String name) {
         AgentName = name;
      }
   
       public void move() {
       
      // Get Current Board and Marker(X or O)
         String line = T.getBoard(AgentName);      
         String board = line.substring(0,9);
         String marker = line.substring(9,10);
      
      // Calculate Play
         int position = 0;
         while (board.charAt(position)=='X' || board.charAt(position)=='O') position=(int)(Math.random()*8+0.5);
         T.putMove(AgentName, position);
      }
          
       public static void main(String args[]) {
         AgentFRED A = new AgentFRED("FRED");
      
      // Play Forever
         while (true){
            A.move();
         }
      } 
   
   }

