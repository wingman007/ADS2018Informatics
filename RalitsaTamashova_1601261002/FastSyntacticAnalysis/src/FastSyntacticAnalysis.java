import java.util.HashMap;
import java.util.Map;
import java.util.Stack;

/**
 * Created by Ralitsa Tamashova on 12.11.2018 г..
 */
public class FastSyntacticAnalysis {

    public static void main(String[] args) {

        String input = "{}({)[/**/]";
        int len = input.length();

        Stack<String> open = new Stack<>();
        Map<String, String> brackets = new HashMap<>();
        brackets.put("(", ")");
        brackets.put("{", "}");
        brackets.put("[", "]");
        brackets.put("/*", "*/");

        String charI;

        for (int i = 0; i < len; i++) {
            charI = String.valueOf(input.charAt(i));
            if (charI.equals("/") || charI.equals("*")) {
                charI = charI + String.valueOf(input.charAt(i+1));
                i++;
            }
            if (brackets.containsKey(charI)) {
                open.add(charI);
            }
            else if (charI.equals(brackets.get(open.peek()))) {
                open.pop();
            }
        }

        if (open.empty()) {
            System.out.println("YES");
        }
        else System.out.println("NO");
    }
}
