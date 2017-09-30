public class nodeTest {
Node A = new Node();
}

public static void main (String[] args)
{
A.value = "A";
A.link1 = new Node();
A.link1.value = "B";
A.link2 = new Node();
A.link2.value = "C";
A.link1.link1 = new Node();
A.link1.link1.value = "D";
A.link1.link2 = new Node();
A.link1.link2.value = "E";
A.link2.link1 = A.link1.link2;
A.link2.link2 = A.link1.link1:

Node currentlink = A.link1;
System.out.print( currentlink.link2.value );
System.out.print( currentlink.link1.value );
}