package polynomials;

import java.text.DecimalFormat;

public class Node{
      private DecimalFormat precision = new DecimalFormat("#.####");
      public double coef;
      public int expo;
      Node next;

      public Node(double coef, int expo, Node next){
         this.coef = coef;
         this.expo = expo;
         this.next = next;
      }
      
      public String toString(){
         String form = precision.format(Math.abs(coef));

         if(expo == 0){ 
             return form ;
         }else if(expo == 1){ 
             return form + "*x";
         }else{
            return form +"*x^" + expo;
         }
      }

   }
