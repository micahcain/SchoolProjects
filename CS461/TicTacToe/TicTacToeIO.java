/*     */ import java.io.BufferedReader;
/*     */ import java.io.BufferedWriter;
/*     */ import java.io.File;
/*     */ import java.io.FileNotFoundException;
/*     */ import java.io.FileReader;
/*     */ import java.io.FileWriter;
/*     */ import java.io.IOException;
/*     */ import java.io.PrintStream;
/*     */ 
/*     */ public class TicTacToeIO
/*     */ {
/*     */   String AgentName;
/*     */ 
/*     */   public TicTacToeIO()
/*     */   {
/*   9 */     this.AgentName = "TEST";
/*     */   }
/*     */ 
/*     */   public TicTacToeIO(String name) {
/*  13 */     this.AgentName = name;
/*     */   }
/*     */ 
/*     */   public String getBoard(String AgentName) {
/*  17 */     String line = "ERRORERROR";
/*  18 */     String FileName = AgentName + "BD.txt";
/*  19 */     String SignalName = AgentName + "SB.txt";
/*     */     while (true)
/*     */     {
/*  40 */       File sf = new File(SignalName);
/*  41 */       if (sf.exists()) {
/*  42 */         sf.delete();
/*  43 */         break;
/*     */       }
/*     */     }
/*     */     while (true)
/*     */     {
/*     */       try
/*     */       {
/*  50 */         FileReader reader = new FileReader(FileName);
/*  51 */         BufferedReader in = new BufferedReader(reader);
/*  52 */         line = in.readLine();
/*  53 */         in.close();
/*  54 */         reader.close();
/*  55 */         if (line == null)
/*     */           continue;
/*  57 */         File delete = new File(FileName);
/*  58 */         delete.delete();
/*  59 */         break;
/*     */ 
/*  68 */         continue; } catch (FileNotFoundException e) { continue;
/*     */       }
/*     */       catch (IOException e)
/*     */       {
/*  67 */         System.out.println("IO Error2");
/*     */       }
/*     */     }
/*  70 */     return line;
/*     */   }
/*     */ 
/*     */   public static void putBoard(String AgentName, String board, char mark) {
/*  74 */     String FileName = AgentName + "BD.txt";
/*  75 */     String SignalName = AgentName + "SB.txt";
/*     */     while (true) {
/*     */       try
/*     */       {
/*  79 */         FileWriter writer = new FileWriter(FileName);
/*  80 */         BufferedWriter out = new BufferedWriter(writer);
/*  81 */         out.write(board);
/*  82 */         out.write(mark);
/*  83 */         out.close();
/*  84 */         writer.close();
/*     */       }
/*     */       catch (IOException e)
/*     */       {
/*  89 */         System.out.println("IO Error3");
/*     */       }
/*     */ 
/*     */     }
/*     */ 
/*     */     while (true)
/*     */     {
/*     */       try
/*     */       {
/* 126 */         File sf = new File(SignalName);
/* 127 */         sf.createNewFile();
/*     */       }
/*     */       catch (IOException e)
/*     */       {
/* 133 */         System.out.println("IO Error5");
/*     */       }
/*     */     }
/*     */   }
/*     */ 
/*     */   public char getMove(String AgentName) {
/* 139 */     String line = " ";
/* 140 */     String FileName = AgentName + "MV.txt";
/* 141 */     String SignalName = AgentName + "SM.txt";
/*     */     while (true)
/*     */     {
/* 163 */       File sf = new File(SignalName);
/* 164 */       if (sf.exists()) {
/* 165 */         sf.delete();
/* 166 */         break;
/*     */       }
/*     */     }
/*     */     while (true)
/*     */     {
/*     */       try
/*     */       {
/* 173 */         System.out.println("Waiting " + FileName);
/* 174 */         FileReader reader = new FileReader(FileName);
/* 175 */         BufferedReader in = new BufferedReader(reader);
/* 176 */         line = in.readLine();
/* 177 */         in.close();
/* 178 */         reader.close();
/* 179 */         if (line == null)
/*     */           continue;
/* 181 */         File delete = new File(FileName);
/* 182 */         delete.delete();
/* 183 */         break;
/*     */ 
/* 197 */         continue;
/*     */       }
/*     */       catch (NullPointerException e)
/*     */       {
/* 188 */         System.out.println("Null Pointer Error");
/*     */ 
/* 197 */         continue; } catch (FileNotFoundException e) { continue;
/*     */       }
/*     */       catch (IOException e)
/*     */       {
/* 196 */         System.out.println("IO Error7");
/*     */       }
/*     */     }
/* 199 */     return line.charAt(0);
/*     */   }
/*     */ 
/*     */   public static void putMove(String AgentName, int position) {
/* 203 */     String line = "ERRORERROR";
/* 204 */     String FileName = AgentName + "MV.txt";
/* 205 */     String SignalName = AgentName + "SM.txt";
/*     */     while (true) {
/*     */       try
/*     */       {
/* 209 */         FileWriter writer = new FileWriter(FileName);
/* 210 */         BufferedWriter out = new BufferedWriter(writer);
/* 211 */         out.write(String.valueOf(position));
/* 212 */         out.close();
/* 213 */         writer.close();
/*     */       }
/*     */       catch (IOException e)
/*     */       {
/* 218 */         System.out.println("IO Error8");
/*     */       }
/*     */ 
/*     */     }
/*     */ 
/*     */     while (true)
/*     */     {
/*     */       try
/*     */       {
/* 255 */         File sf = new File(SignalName);
/* 256 */         sf.createNewFile();
/*     */       }
/*     */       catch (IOException e)
/*     */       {
/* 261 */         System.out.println("IO Error10");
/*     */       }
/*     */     }
/*     */   }
/*     */ }

/* Location:           C:\Users\Micah\Documents\CS461\
 * Qualified Name:     TicTacToeIO
 * JD-Core Version:    0.6.0
 */