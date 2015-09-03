import java.util.ArrayList;
import java.util.Scanner;

public class SymmetricNumbersInRange {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int start = scanner.nextInt();
        int end = scanner.nextInt();
        ArrayList<String> output = new ArrayList<>();
        for (int i = start; i <= end; i++) {
            String numberAsString = Integer.toString(i);
            char firstDigit = numberAsString.charAt(0);
            char lastDigit = numberAsString.charAt(numberAsString.length() - 1);
            if (firstDigit == lastDigit) {
                output.add(numberAsString);
            }
        }
        System.out.println(String.join(" ",output));
    }
}
