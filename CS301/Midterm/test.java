public class test {

public static void main (String args[]) {
recursion(1);
}

public static int recursion(int i) {

if (i==1)
return 0;
else {
System.out.println(i + recursion(i - 1));
return i+recursion(i-1);
}
}
}

