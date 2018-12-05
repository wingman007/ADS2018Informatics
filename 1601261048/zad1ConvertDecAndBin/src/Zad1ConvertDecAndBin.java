import java.util.Scanner;

class zad1ConvertDecAndBin {
    
    public static void main(String[] args){

        Scanner in = new Scanner(System.in);
        System.out.println("От каква бройна система да превърне и в каква? \n Изберете число. \n 1. От десетична в двоична. \n 2. От двоична в десетична.");
        System.out.print("Избор: ");
        int checker = in.nextInt();
        if (checker == 1){ 
            System.out.println("Въведи десетично число: ");
            int numberDec;
            numberDec = in.nextInt();
            String binary = "";
            
            while(numberDec > 0){
                binary += numberDec % 2;
                numberDec = Math.abs(numberDec)/2;
                
            }
            
            StringBuilder binary2 = new StringBuilder();
            binary2.append(binary);
            binary2 = binary2.reverse();

            System.out.println("Вашето число в двоичен вид е: " + binary2 + "\n");
        }else if(checker == 2){
            System.out.println("Въведи двоично число: ");
            String number;            
            number = in.next();
            int sum = 0;
            int index = 0;
            for(int i = number.length()-1;i >= 0; i--, index ++){
                int loc = number.charAt(index) - 48;
                sum = (int) (sum + ((Math.pow(2, i) * loc)));
            }
         
            System.out.println("Вашето число в десетичен вид е: " + sum + "\n");
        }else{
            System.out.println("Не си въвел от посочените!");
        }
    }

}