
package searchkey;

import com.sun.corba.se.impl.util.PackagePrefixChecker;
import java.util.Scanner;

public class SearchKey {

    public static void main(String[] args) {
      Node root = new Node(6);
      //left
      Node n5 = new Node(5);
      Node n3 = new Node(3);
      Node n1 = new Node(1);
      //right
      Node n10 = new Node(10);
      Node n8 = new Node(8);
      Node n7 = new Node(7);
      //
      Node n13 = new Node(13);
      //
      Node n11 = new Node(11);
      Node n12 = new Node(12);
      //
      Node n14 = new Node(14);
      
      root.leftNode = n5;
      root.rightNode = n10;
      n5.leftNode = n3;
      n10.leftNode = n8;
      n10.rightNode = n13;
      n3.leftNode = n1;
      n8.leftNode = n7;
      n13.leftNode = n11;
      n13.rightNode = n14;
      n11.rightNode = n12;
      
      Node current = root;
      System.out.print("Укажете номер(key) за да го потърси в дървото. \n Ще изреди всички елементи до мястото, \n до което намери номера или не го намери: ");
      int key;
      Scanner in;
      do{
        try{
            in = new Scanner(System.in);
            key = in.nextInt();
        }catch(Exception e){
            System.out.print("Не сте въвели коректно номер. Въведете отново: ");
            key = 0;
        }
      }while(key < 1);
      //System.out.println("Въведохте: " + key + "\n");
      while(current != null && current.value != key){
          System.out.println(current.value);
          if(key < current.value){
            System.out.println("Движение наляво");
            current = current.leftNode;
          }else{
              System.out.println("Движение надясно");
              current = current.rightNode;
          }   
      }
      if (current == null){
          System.out.println("Не е намерено числото");
      }else{
          System.out.println("Числото " + current.value + " е намерено");
      }
    }
}
