package polynomials;
import java.util.*;
import java.text.*;

public class Polynomials{
   private Node head;
   
   public Polynomials(){
      head = null;
   }

   public void add(double coef, int expo){
      
        if(head == null || expo < head.expo){
           head = new Node(coef, expo, head);
           return;
        }
      
        Node cur = head;
        Node prev = null;

        while( cur != null && expo > cur.expo){
           prev = cur;
           cur = cur.next;
        }
        if( cur == null || expo != cur.expo ){
          prev.next = new Node(coef, expo, cur);
        }
    }
   
   public String toString(){    
        
      StringBuilder sbPl = new StringBuilder();
      StringBuilder sbMulti = new StringBuilder();
      StringBuilder sbDiv = new StringBuilder();

      for(Node tmp = head; tmp != null; tmp = tmp.next){
        if(tmp.coef < 0 ){
           sbPl.append(" - " + tmp.toString());
           sbMulti.append(" * (-" + tmp.toString() + ")");
           sbDiv.append(" / " + "(-" + tmp.toString() + ")" );

        }else{
           sbPl.append(" + " + tmp.toString());
           sbMulti.append(" * " + tmp.toString());
           sbDiv.append(" / " + tmp.toString());

        }
      }
      //return sbPl.toString();
      return sbMulti.toString();
      //return sbDiv.toString();
   }
   
   public double eval(double value)
   {
       double resultPl = 0;
       double resultMulti = 1;
       double resultDiv = 1;
      for(Node tmp = head; tmp != null; tmp = tmp.next)
      {
         resultPl += tmp.coef * Math.pow(value, tmp.expo);
         resultMulti *= tmp.coef * Math.pow(value, tmp.expo);
         resultDiv /= tmp.coef * Math.pow(value, tmp.expo);
      }
      //return resultPl;
      return resultMulti;
      //return resultDiv;
   }


   public static void main(String[] args)
   {
      Polynomials poly = new Polynomials();
      int x = 1;
      
      System.out.print("Полином: ");
      poly.add(5, 0);
      poly.add(2, 3);
      //poly.add(0, 0);
      System.out.print(poly);
      System.out.println( );
      
      System.out.print("Ако x = "+ x + ": " + poly + " = " + poly.eval(x));
      //System.out.println(poly.eval(x));
      System.out.println( );

   }

}