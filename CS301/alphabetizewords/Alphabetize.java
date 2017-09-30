// Purpose: An exercise using Scanner, ArrayList, and Collections.sort.
//          Read words, sort them, print them.
// Author : Fred Swartz - 10 Feb 2005 - Placed in public domain.

package alphabetizewords;

import java.util.*;

public class Alphabetize {

    public static void main(String[] args) {
        //... Declare variables.
        Scanner           in    = new Scanner(System.in);
        ArrayList<String> words = new ArrayList<String>();

        //... Read input one word at a time.
        System.out.println("Enter words.  End with EOF (CTRL-Z then Enter)");
        System.out.println("      or click Close Input in NetBeans.");

        //... Read input one word at a time, adding it to an array list.
        while (in.hasNext()) {
            words.add(in.next());
        }

        //... Sort the words.
        Collections.sort(words);

        //... Print the sorted list.
        System.out.println("\n\nSorted words\n");
        for (String word : words) {
            System.out.println(word);
        }
    }
}
