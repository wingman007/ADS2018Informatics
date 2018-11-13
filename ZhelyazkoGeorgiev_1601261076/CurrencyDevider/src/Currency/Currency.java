package Currency;

import java.util.Scanner;

public class Currency {

	
	// function to count and print currency notes.
	public static void countCurrency(int amount)
	{
		int[] notes = {100, 50, 20, 10, 5, 2, 1};
		int[] noteCounter = new int[7];
		
		// counting notes
		for(int i=0; i < 7; i++){
			if(amount >= notes[i]){
				noteCounter[i] = amount / notes[i];
				amount -= noteCounter[i] * notes[i];
			}
		}
		// printing notes;
		System.out.println("Currency Devider: ");
		for(int i=0;i < 7; i++){
			if(noteCounter[i] != 0){
				System.out.println(notes[i] + " : " + noteCounter[i]);
			}
		}
	}
	
	// main method.
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.println("Please type a currency number you would wish to be devided.3");
		int amount = sc.nextInt();
		sc.nextLine();
		countCurrency(amount);
		
	}

}
