/*     */ import java.awt.Color;
/*     */ import java.awt.Container;
/*     */ import java.awt.Font;
/*     */ import java.io.File;
/*     */ import java.io.FileReader;
/*     */ import javax.swing.JFrame;
/*     */ import javax.swing.JTextArea;
/*     */ import javax.swing.JTextField;
/*     */ 
/*     */ public class TicTacToe extends JFrame
/*     */ {
/*   7 */   private TicTacToeIO TTTIO = new TicTacToeIO();
/*     */   private JTextField Area0;
/*     */   private JTextField Area1;
/*     */   private JTextField Area2;
/*     */   private JTextField Area3;
/*     */   private JTextField Area4;
/*     */   private JTextField Area5;
/*     */   private JTextField Area6;
/*     */   private JTextField Area7;
/*     */   private JTextField Area8;
/*     */   private JTextField Name1;
/*     */   private JTextField Name2;
/*     */   private JTextField Name3;
/*     */   private JTextField Score1;
/*     */   private JTextField Score2;
/*     */   private JTextField Score3;
/*     */   private JTextArea Standings;
/*     */   private static final int delay = 1000000000;
/*  12 */   private final int drawLimit = 25;
/*  13 */   private final int NumberOfGames = 10;
/*  14 */   private final int NumberOfIterations = 10;
/*     */   private static final int NumberOfPlayers = 2;
/*  16 */   String[] Players = new String[2];
/*  17 */   int[] Wins = new int[2];
/*  18 */   int[] Losses = new int[2];
/*  19 */   int[] Ties = new int[2];
/*  20 */   String Player1 = this.Players[0];
/*  21 */   String Player2 = this.Players[1];
/*  22 */   String Player3 = "DRAWS";
/*  23 */   int Player1Total = 0;
/*  24 */   int Player2Total = 0;
/*  25 */   int draws = 0;
/*  26 */   char[] newPlay = new char[9];
/*  27 */   char[] oldPlay = new char[9];
/*  28 */   boolean winner1 = false;
/*  29 */   boolean winner2 = false;
/*  30 */   char CurrentPlayer = '1';
/*  31 */   char CurrentLastPlayer = '2';
/*  32 */   int CurrentMainPlayer = 0;
/*  33 */   int CurrentSecondaryPlayer = 1;
/*     */   FileReader reader;
/*     */   File delete;
/*  36 */   char mark = ' ';
/*     */ 
/*     */   public TicTacToe()
/*     */   {
/*  40 */     this.Players[0] = "FRED";
/*  41 */     this.Players[1] = "TEST";
/*     */ 
/*  50 */     setTitle("TicTacToe Battleground");
/*  51 */     setSize(700, 700);
/*  52 */     Container pane = getContentPane();
/*  53 */     pane.setBackground(new Color(0, 0, 0));
/*  54 */     pane.setLayout(null);
/*  55 */     this.Area0 = new JTextField(5);
/*  56 */     this.Area0.setSize(100, 100);
/*  57 */     this.Area0.setLocation(10, 10);
/*  58 */     this.Area0.setEditable(false);
/*  59 */     this.Area1 = new JTextField(5);
/*  60 */     this.Area1.setSize(100, 100);
/*  61 */     this.Area1.setLocation(120, 10);
/*  62 */     this.Area1.setEditable(false);
/*  63 */     this.Area2 = new JTextField(5);
/*  64 */     this.Area2.setSize(100, 100);
/*  65 */     this.Area2.setLocation(230, 10);
/*  66 */     this.Area2.setEditable(false);
/*  67 */     this.Area3 = new JTextField(5);
/*  68 */     this.Area3.setSize(100, 100);
/*  69 */     this.Area3.setLocation(10, 120);
/*  70 */     this.Area3.setEditable(false);
/*  71 */     this.Area4 = new JTextField(5);
/*  72 */     this.Area4.setSize(100, 100);
/*  73 */     this.Area4.setLocation(120, 120);
/*  74 */     this.Area4.setEditable(false);
/*  75 */     this.Area5 = new JTextField(5);
/*  76 */     this.Area5.setSize(100, 100);
/*  77 */     this.Area5.setLocation(230, 120);
/*  78 */     this.Area5.setEditable(false);
/*  79 */     this.Area6 = new JTextField(5);
/*  80 */     this.Area6.setSize(100, 100);
/*  81 */     this.Area6.setLocation(10, 230);
/*  82 */     this.Area6.setEditable(false);
/*  83 */     this.Area7 = new JTextField(5);
/*  84 */     this.Area7.setSize(100, 100);
/*  85 */     this.Area7.setLocation(120, 230);
/*  86 */     this.Area7.setEditable(false);
/*  87 */     this.Area8 = new JTextField(5);
/*  88 */     this.Area8.setSize(100, 100);
/*  89 */     this.Area8.setLocation(230, 230);
/*  90 */     this.Area8.setEditable(false);
/*  91 */     this.Standings = new JTextArea();
/*  92 */     this.Standings.setSize(340, 648);
/*  93 */     this.Standings.setLocation(340, 10);
/*  94 */     this.Standings.setEditable(false);
/*  95 */     pane.add(this.Area0);
/*  96 */     this.Area0.setFont(new Font("Arial", 1, 90));
/*  97 */     pane.add(this.Area1);
/*  98 */     this.Area1.setFont(new Font("Arial", 1, 90));
/*  99 */     pane.add(this.Area2);
/* 100 */     this.Area2.setFont(new Font("Arial", 1, 90));
/* 101 */     pane.add(this.Area3);
/* 102 */     this.Area3.setFont(new Font("Arial", 1, 90));
/* 103 */     pane.add(this.Area4);
/* 104 */     this.Area4.setFont(new Font("Arial", 1, 90));
/* 105 */     pane.add(this.Area5);
/* 106 */     this.Area5.setFont(new Font("Arial", 1, 90));
/* 107 */     pane.add(this.Area6);
/* 108 */     this.Area6.setFont(new Font("Arial", 1, 90));
/* 109 */     pane.add(this.Area7);
/* 110 */     this.Area7.setFont(new Font("Arial", 1, 90));
/* 111 */     pane.add(this.Area8);
/* 112 */     this.Area8.setFont(new Font("Arial", 1, 90));
/* 113 */     pane.add(this.Standings);
/* 114 */     this.Name1 = new JTextField(10);
/* 115 */     this.Name1.setSize(210, 100);
/* 116 */     this.Name1.setLocation(10, 340);
/* 117 */     this.Name1.setEditable(false);
/* 118 */     this.Name2 = new JTextField(10);
/* 119 */     this.Name2.setSize(210, 100);
/* 120 */     this.Name2.setLocation(10, 450);
/* 121 */     this.Name2.setEditable(false);
/* 122 */     this.Name3 = new JTextField(10);
/* 123 */     this.Name3.setSize(210, 100);
/* 124 */     this.Name3.setLocation(10, 560);
/* 125 */     this.Name3.setEditable(false);
/* 126 */     this.Score1 = new JTextField(10);
/* 127 */     this.Score1.setSize(100, 100);
/* 128 */     this.Score1.setLocation(230, 340);
/* 129 */     this.Score1.setEditable(false);
/* 130 */     this.Score2 = new JTextField(10);
/* 131 */     this.Score2.setSize(100, 100);
/* 132 */     this.Score2.setLocation(230, 450);
/* 133 */     this.Score2.setEditable(false);
/* 134 */     this.Score3 = new JTextField(10);
/* 135 */     this.Score3.setSize(100, 100);
/* 136 */     this.Score3.setLocation(230, 560);
/* 137 */     this.Score3.setEditable(false);
/* 138 */     pane.add(this.Name1);
/* 139 */     this.Name1.setFont(new Font("Arial", 1, 40));
/* 140 */     pane.add(this.Name2);
/* 141 */     this.Name2.setFont(new Font("Arial", 1, 40));
/* 142 */     pane.add(this.Name3);
/* 143 */     this.Name3.setFont(new Font("Arial", 1, 40));
/* 144 */     pane.add(this.Score1);
/* 145 */     this.Score1.setFont(new Font("Arial", 1, 40));
/* 146 */     pane.add(this.Score2);
/* 147 */     this.Score2.setFont(new Font("Arial", 1, 40));
/* 148 */     pane.add(this.Score3);
/* 149 */     this.Score3.setFont(new Font("Arial", 1, 40));
/* 150 */     setVisible(true);
/* 151 */     setDefaultCloseOperation(3);
/* 152 */     printStandings();
/*     */ 
/* 154 */     int iteration = 1;
/* 155 */     while (iteration <= 10) {
/* 156 */       this.CurrentPlayer = '1';
/* 157 */       this.CurrentLastPlayer = '2';
/* 158 */       this.CurrentMainPlayer = 0;
/* 159 */       this.CurrentSecondaryPlayer = 1;
/* 160 */       while (this.CurrentMainPlayer < 1) {
/* 161 */         this.CurrentSecondaryPlayer = (this.CurrentMainPlayer + 1);
/* 162 */         while (this.CurrentSecondaryPlayer < 2) {
/* 163 */           this.Player1Total = 0;
/* 164 */           this.Player2Total = 0;
/* 165 */           this.draws = 0;
/* 166 */           this.Player1 = this.Players[this.CurrentMainPlayer];
/* 167 */           this.Player2 = this.Players[this.CurrentSecondaryPlayer];
/* 168 */           this.CurrentPlayer = '1';
/* 169 */           this.CurrentLastPlayer = '2';
/* 170 */           while ((this.draws < 25) && (((this.Player1Total < 10) && (this.Player2Total < 10)) || ((this.Player1Total == 10) && (this.Player2Total == 9)) || ((this.Player2Total == 10) && (this.Player1Total == 9)))) {
/* 171 */             if (this.CurrentLastPlayer == '1') {
/* 172 */               this.CurrentLastPlayer = '2';
/* 173 */               this.CurrentPlayer = '2';
/* 174 */               TicTacToeIO.putBoard(this.Players[this.CurrentSecondaryPlayer], "         ", 'X');
/*     */             }
/*     */             else {
/* 177 */               this.CurrentLastPlayer = '1';
/* 178 */               this.CurrentPlayer = '1';
/* 179 */               TicTacToeIO.putBoard(this.Players[this.CurrentMainPlayer], "         ", 'X');
/*     */             }
/* 181 */             this.mark = 'X';
/* 182 */             this.Name1.setText(this.Player1);
/* 183 */             this.Name2.setText(this.Player2);
/* 184 */             this.Name3.setText(this.Player3);
/* 185 */             this.Score1.setText(" " + this.Player1Total);
/* 186 */             this.Score2.setText(" " + this.Player2Total);
/* 187 */             this.Score3.setText(" " + this.draws);
/* 188 */             for (int i = 0; i <= 8; i++) this.oldPlay[i] = ' ';
/* 189 */             for (int i = 0; i <= 8; i++) this.newPlay[i] = ' ';
/* 190 */             this.Area0.setText(" " + this.newPlay[0]);
/* 191 */             this.Area1.setText(" " + this.newPlay[1]);
/* 192 */             this.Area2.setText(" " + this.newPlay[2]);
/* 193 */             this.Area3.setText(" " + this.newPlay[3]);
/* 194 */             this.Area4.setText(" " + this.newPlay[4]);
/* 195 */             this.Area5.setText(" " + this.newPlay[5]);
/* 196 */             this.Area6.setText(" " + this.newPlay[6]);
/* 197 */             this.Area7.setText(" " + this.newPlay[7]);
/* 198 */             this.Area8.setText(" " + this.newPlay[8]);
/* 199 */             this.winner1 = false;
/* 200 */             this.winner2 = false;
/*     */ 
/* 202 */             while ((!this.winner1) && (!this.winner2)) {
/* 203 */               if (this.CurrentPlayer == '1') {
/* 204 */                 char move = this.TTTIO.getMove(this.Players[this.CurrentMainPlayer]);
/* 205 */                 if (this.newPlay[(move - '0')] == ' ') this.newPlay[(move - '0')] = this.mark; else
/* 206 */                   this.winner2 = true;
/*     */               }
/*     */               else {
/* 209 */                 char move = this.TTTIO.getMove(this.Players[this.CurrentSecondaryPlayer]);
/* 210 */                 if (this.newPlay[(move - '0')] == ' ') this.newPlay[(move - '0')] = this.mark; else {
/* 211 */                   this.winner1 = true;
/*     */                 }
/*     */               }
/* 214 */               this.Area0.setText(" " + this.newPlay[0]);
/* 215 */               this.Area1.setText(" " + this.newPlay[1]);
/* 216 */               this.Area2.setText(" " + this.newPlay[2]);
/* 217 */               this.Area3.setText(" " + this.newPlay[3]);
/* 218 */               this.Area4.setText(" " + this.newPlay[4]);
/* 219 */               this.Area5.setText(" " + this.newPlay[5]);
/* 220 */               this.Area6.setText(" " + this.newPlay[6]);
/* 221 */               this.Area7.setText(" " + this.newPlay[7]);
/* 222 */               this.Area8.setText(" " + this.newPlay[8]);
/*     */ 
/* 225 */               if ((!this.winner1) && (!this.winner2)) {
/* 226 */                 if ((this.newPlay[0] == 'X') && (this.newPlay[1] == 'X') && (this.newPlay[2] == 'X')) {
/* 227 */                   if (this.CurrentPlayer == '1')
/* 228 */                     this.winner1 = true;
/*     */                   else
/* 230 */                     this.winner2 = true;
/* 231 */                 } else if ((this.newPlay[3] == 'X') && (this.newPlay[4] == 'X') && (this.newPlay[5] == 'X')) {
/* 232 */                   if (this.CurrentPlayer == '1')
/* 233 */                     this.winner1 = true;
/*     */                   else
/* 235 */                     this.winner2 = true;
/* 236 */                 } else if ((this.newPlay[6] == 'X') && (this.newPlay[7] == 'X') && (this.newPlay[8] == 'X')) {
/* 237 */                   if (this.CurrentPlayer == '1')
/* 238 */                     this.winner1 = true;
/*     */                   else
/* 240 */                     this.winner2 = true;
/* 241 */                 } else if ((this.newPlay[0] == 'X') && (this.newPlay[3] == 'X') && (this.newPlay[6] == 'X')) {
/* 242 */                   if (this.CurrentPlayer == '1')
/* 243 */                     this.winner1 = true;
/*     */                   else
/* 245 */                     this.winner2 = true;
/* 246 */                 } else if ((this.newPlay[1] == 'X') && (this.newPlay[4] == 'X') && (this.newPlay[7] == 'X')) {
/* 247 */                   if (this.CurrentPlayer == '1')
/* 248 */                     this.winner1 = true;
/*     */                   else
/* 250 */                     this.winner2 = true;
/* 251 */                 } else if ((this.newPlay[2] == 'X') && (this.newPlay[5] == 'X') && (this.newPlay[8] == 'X')) {
/* 252 */                   if (this.CurrentPlayer == '1')
/* 253 */                     this.winner1 = true;
/*     */                   else
/* 255 */                     this.winner2 = true;
/* 256 */                 } else if ((this.newPlay[0] == 'X') && (this.newPlay[4] == 'X') && (this.newPlay[8] == 'X')) {
/* 257 */                   if (this.CurrentPlayer == '1')
/* 258 */                     this.winner1 = true;
/*     */                   else
/* 260 */                     this.winner2 = true;
/* 261 */                 } else if ((this.newPlay[2] == 'X') && (this.newPlay[4] == 'X') && (this.newPlay[6] == 'X')) {
/* 262 */                   if (this.CurrentPlayer == '1')
/* 263 */                     this.winner1 = true;
/*     */                   else
/* 265 */                     this.winner2 = true;
/*     */                 }
/* 267 */                 if ((this.newPlay[0] == 'O') && (this.newPlay[1] == 'O') && (this.newPlay[2] == 'O')) {
/* 268 */                   if (this.CurrentPlayer == '1')
/* 269 */                     this.winner1 = true;
/*     */                   else
/* 271 */                     this.winner2 = true;
/*     */                 }
/* 273 */                 else if ((this.newPlay[3] == 'O') && (this.newPlay[4] == 'O') && (this.newPlay[5] == 'O')) {
/* 274 */                   if (this.CurrentPlayer == '1')
/* 275 */                     this.winner1 = true;
/*     */                   else
/* 277 */                     this.winner2 = true;
/* 278 */                 } else if ((this.newPlay[6] == 'O') && (this.newPlay[7] == 'O') && (this.newPlay[8] == 'O')) {
/* 279 */                   if (this.CurrentPlayer == '1')
/* 280 */                     this.winner1 = true;
/*     */                   else
/* 282 */                     this.winner2 = true;
/* 283 */                 } else if ((this.newPlay[0] == 'O') && (this.newPlay[3] == 'O') && (this.newPlay[6] == 'O')) {
/* 284 */                   if (this.CurrentPlayer == '1')
/* 285 */                     this.winner1 = true;
/*     */                   else
/* 287 */                     this.winner2 = true;
/* 288 */                 } else if ((this.newPlay[1] == 'O') && (this.newPlay[4] == 'O') && (this.newPlay[7] == 'O')) {
/* 289 */                   if (this.CurrentPlayer == '1')
/* 290 */                     this.winner1 = true;
/*     */                   else
/* 292 */                     this.winner2 = true;
/* 293 */                 } else if ((this.newPlay[2] == 'O') && (this.newPlay[5] == 'O') && (this.newPlay[8] == 'O')) {
/* 294 */                   if (this.CurrentPlayer == '1')
/* 295 */                     this.winner1 = true;
/*     */                   else
/* 297 */                     this.winner2 = true;
/* 298 */                 } else if ((this.newPlay[0] == 'O') && (this.newPlay[4] == 'O') && (this.newPlay[8] == 'O')) {
/* 299 */                   if (this.CurrentPlayer == '1')
/* 300 */                     this.winner1 = true;
/*     */                   else
/* 302 */                     this.winner2 = true;
/* 303 */                 } else if ((this.newPlay[2] == 'O') && (this.newPlay[4] == 'O') && (this.newPlay[6] == 'O'))
/* 304 */                   if (this.CurrentPlayer == '1')
/* 305 */                     this.winner1 = true;
/*     */                   else
/* 307 */                     this.winner2 = true;
/*     */               }
/* 309 */               if (this.winner1) this.Player1Total += 1;
/* 310 */               if (this.winner2) this.Player2Total += 1;
/*     */ 
/* 313 */               boolean DrawTest = false;
/* 314 */               if ((!this.winner1) && (!this.winner2)) {
/* 315 */                 DrawTest = true;
/* 316 */                 for (int i = 0; i <= 8; i++) {
/* 317 */                   if ((this.newPlay[i] == 'X') || (this.newPlay[i] == 'O')) continue; DrawTest = false;
/*     */                 }
/*     */               }
/* 319 */               if (DrawTest) this.draws += 1;
/*     */ 
/* 322 */               this.Score1.setText(" " + this.Player1Total);
/* 323 */               this.Score2.setText(" " + this.Player2Total);
/* 324 */               this.Score3.setText(" " + this.draws);
/*     */ 
/* 326 */               if ((this.winner1) || (this.winner2) || (DrawTest))
/*     */               {
/*     */                 break;
/*     */               }
/* 330 */               String board = "";
/* 331 */               for (int i = 0; i <= 8; i++) this.oldPlay[i] = this.newPlay[i];
/* 332 */               for (int i = 0; i <= 8; i++) board = board + this.newPlay[i];
/* 333 */               if (this.CurrentPlayer == this.CurrentLastPlayer) this.mark = 'O'; else
/* 334 */                 this.mark = 'X';
/* 335 */               if (this.CurrentPlayer == '1') {
/* 336 */                 this.CurrentPlayer = '2';
/* 337 */                 TicTacToeIO.putBoard(this.Players[this.CurrentSecondaryPlayer], board, this.mark);
/*     */               }
/*     */               else {
/* 340 */                 this.CurrentPlayer = '1';
/* 341 */                 TicTacToeIO.putBoard(this.Players[this.CurrentMainPlayer], board, this.mark);
/*     */               }
/*     */             }
/*     */           }
/*     */ 
/* 346 */           if (this.draws >= 25) {
/* 347 */             this.Ties[this.CurrentMainPlayer] += 1;
/* 348 */             this.Ties[this.CurrentSecondaryPlayer] += 1;
/*     */           }
/* 350 */           else if ((this.Player1Total >= 10) && (this.Player2Total >= 10)) {
/* 351 */             this.Ties[this.CurrentMainPlayer] += 1;
/* 352 */             this.Ties[this.CurrentSecondaryPlayer] += 1;
/*     */           }
/* 354 */           else if (this.Player1Total >= 10) {
/* 355 */             this.Wins[this.CurrentMainPlayer] += 1;
/* 356 */             this.Losses[this.CurrentSecondaryPlayer] += 1;
/*     */           }
/*     */           else {
/* 359 */             this.Wins[this.CurrentSecondaryPlayer] += 1;
/* 360 */             this.Losses[this.CurrentMainPlayer] += 1;
/*     */           }
/*     */ 
/* 363 */           printStandings();
/* 364 */           this.CurrentSecondaryPlayer += 1;
/*     */         }
/* 366 */         this.CurrentMainPlayer += 1;
/*     */       }
/* 368 */       iteration++;
/*     */     }
/*     */   }
/*     */ 
/*     */   public void printStandings()
/*     */   {
/* 375 */     String[] SortPlayers = new String[2];
/* 376 */     int[] SortWins = new int[2];
/* 377 */     int[] SortLosses = new int[2];
/* 378 */     int[] SortTies = new int[2];
/* 379 */     for (int i = 0; i < 2; i++) {
/* 380 */       SortPlayers[i] = this.Players[i];
/* 381 */       SortWins[i] = this.Wins[i];
/* 382 */       SortLosses[i] = this.Losses[i];
/* 383 */       SortTies[i] = this.Ties[i];
/*     */     }
/*     */ 
/* 386 */     int n = 0;
/* 387 */     while (n < 2) {
/* 388 */       int j = 1;
/* 389 */       while (j > n)
/*     */       {
/* 392 */         if (calcStanding(SortWins[j], SortTies[j]) > calcStanding(SortWins[(j - 1)], SortTies[(j - 1)])) {
/* 393 */           int TempInt = SortWins[(j - 1)];
/* 394 */           SortWins[(j - 1)] = SortWins[j];
/* 395 */           SortWins[j] = TempInt;
/* 396 */           TempInt = SortLosses[(j - 1)];
/* 397 */           SortLosses[(j - 1)] = SortLosses[j];
/* 398 */           SortLosses[j] = TempInt;
/* 399 */           TempInt = SortTies[(j - 1)];
/* 400 */           SortTies[(j - 1)] = SortTies[j];
/* 401 */           SortTies[j] = TempInt;
/* 402 */           String TempString = SortPlayers[(j - 1)];
/* 403 */           SortPlayers[(j - 1)] = SortPlayers[j];
/* 404 */           SortPlayers[j] = TempString;
/*     */         }
/* 406 */         j--;
/*     */       }
/* 408 */       n++;
/*     */     }
/* 410 */     String StandingString = "";
/* 411 */     StandingString = StandingString + " STANDINGS\n";
/* 412 */     StandingString = StandingString + " NAME\tWINS\tLOSSES\tTIES\n";
/* 413 */     for (int i = 0; i < 2; i++) {
/* 414 */       StandingString = StandingString + " " + SortPlayers[i] + "\t" + SortWins[i] + "\t" + SortLosses[i] + "\t" + SortTies[i] + "\n";
/*     */     }
/* 416 */     this.Standings.setText(StandingString);
/*     */   }
/*     */ 
/*     */   public int calcStanding(int wins, int ties) {
/* 420 */     return wins * 2 + ties;
/*     */   }
/*     */ 
/*     */   public static void main(String[] args)
/*     */   {
/* 637 */     TicTacToe TTT = new TicTacToe();
/*     */   }
/*     */ }

/* Location:           C:\Users\Micah\Documents\CS461\
 * Qualified Name:     TicTacToe
 * JD-Core Version:    0.6.0
 */