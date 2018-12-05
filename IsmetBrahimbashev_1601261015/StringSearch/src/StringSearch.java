
import java.util.Arrays;
 
public class StringSearch {
	
	public static void main(String args[]){
		
	
		String[] strMonths = new String[]{"January", "February", "March", "April", "May"};
		
	
		String strFind1 = "March";
		String strFind2 = "December";
		
		boolean contains = false;
		
		for(int i=0; i < strMonths.length; i++){
			

			if(strMonths[i].equals(strFind1)){
 
			
				contains = true;
				break;
				
			}
		}
		
		if(contains){
			System.out.println("String array contains String " + strFind1);
		}else{
			System.out.println("String array does not contain String " + strFind1);
		}
		
		
		
		contains = Arrays.asList(strMonths).contains(strFind1);
		System.out.println("Does String array contain " + strFind1 + "? " + contains);
		
		contains = Arrays.asList(strMonths).contains(strFind2);
		System.out.println("Does String array contain " + strFind2 + "? " + contains);
 
	}
}
 
