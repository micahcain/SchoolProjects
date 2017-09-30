/*     
Problem:

There are five consecutive houses, each of a different
color and inhabited by men of different nationalities. They each
own a different pet, have a different favorite drink and drive a
different car.

1.   The Englishman lives in the red house.
2.   The Spaniard owns the dog.
3.   Coffee is drunk in the green house.
4.   The Ukrainian drinks tea.
5.   The green house is immediately to the right of the ivory house.
6.   The Porsche driver owns snails.
7.   The Masserati is driven by the man who lives in the yellow house.
8.   Milk is drunk in the middle house.
9.   The Norwegian lives in the first house on the left.
10.  The man who drives a Saab lives in the house next to the man
     with the fox.
11.  The Masserati is driven by the man in the house next to the
     house where the horse is kept.
12.  The Honda driver drinks orange juice.
13.  The Japanese drives a Jaguar.
14.  The Norwegian lives next to the blue house.

The problem is: Who owns the Zebra?  Who drinks water?
*/

/* Solution, based on one by M. H. van Emden, with further explanatory
   comments by Robert Keller.

   Each house is structured like this:

       [Color, Nationality, Car, Drink, Pet]

   A Solution is a list of 5 houses of the above form.
*/


zebraOwner(Solution, X)   :- member([_, X, _, _, zebra],          Solution).

waterDrinker(Solution, X) :- member([_, X, _, water, _],          Solution).


clue1(Solution)  :- member( [red,englishman,_,_,_],               Solution).

clue2(Solution)  :- member( [_,spaniard,_,_,dog],                 Solution).

clue3(Solution)  :- member( [green,_,_,coffee,_],                 Solution).

clue4(Solution)  :- member( [_,ukranian,_,tea,_],                 Solution).

clue5(Solution)  :- left_right( [ivory,_,_,_,_], [green,_,_,_,_], Solution).

clue6(Solution)  :- member( [_,_,porsche,_,snails],               Solution).

clue7(Solution)  :- member( [yellow,_,masserati,_,_],             Solution).

clue8(Solution)  :- [_,_,[_,_,_,milk,_],_,_]                    = Solution.

clue9(Solution)  :- [[_,norwegian,_,_,_],_,_,_,_]               = Solution.

clue10(Solution) :- next_to( [_,_,saab,_,_],     [_,_,_,_,fox],   Solution).

clue11(Solution) :- next_to( [_,_,masserati,_,_],[_,_,_,_,horse], Solution).

clue12(Solution) :- member( [_,_,honda,orange_juice,_],           Solution).

clue13(Solution) :- member( [_,japanese,jaguar,_,_],              Solution).

clue14(Solution) :- next_to( [_,norwegian,_,_,_],[blue,_,_,_,_],  Solution).


% solve(Solution) creates the list of houses as a solution.
% In the Solution created, there are just two variables that are not bound,
% one for a pet and the other for a drink. Those are bound in the answer
% predicates to whatever pet or drink, respectively, is specified.  That
% is why we can get an answer for 'zebra' or 'water' even though those
% are never mentioned in the clues.  We could get the same answer
% regardless of what the type of pet or drink is, so long as it is
% not one of the other four mentioned.

solve(Solution) :-
		   clue8(Solution),	% Clues 8 and 9 are earlier
		   clue9(Solution),	% because they constrain more
		   clue1(Solution),     % making solution take less 
		   clue2(Solution),	% time and memory.
		   clue3(Solution),
		   clue4(Solution),
		   clue5(Solution),
		   clue6(Solution),
		   clue7(Solution),
		   clue10(Solution),
		   clue11(Solution),
		   clue12(Solution),
		   clue13(Solution),
		   clue14(Solution),
                   true.       
   

% member(X, L) is true when X is a member of list L.

member(X, [X|_]).

member(X, [_|L]) :- member(X, L).


% left_right(L, R, X) is true when L is to the immediate left of R in list X

left_right(L, R, [L, R | _]).

left_right(L, R, [_ | X]) :- left_right(L, R, X).


% next_to(X, Y, L) is true when X and Y are next to each other in list L

next_to(X, Y, L) :- left_right(X, Y, L).

next_to(X, Y, L) :- left_right(Y, X, L).


:- nl,
   write('The zebra is owned by the '),
   solve(Solution),
   zebraOwner(Solution, X),
   write(X),
   write('.'),
   nl,
   nl.

:- nl,
   write('Water is drunk by the '),
   solve(Solution),
   waterDrinker(Solution, X),
   write(X),
   write('.'),
   nl,
   nl.



   