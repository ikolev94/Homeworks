import java.util.ArrayList;
import java.util.Scanner;

public class LongestIncreasingSequence {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] numbersAsStrings = scanner.nextLine().split(" ");
        int[] numbers = new int[numbersAsStrings.length + 1];
        for (int i = 0; i < numbersAsStrings.length; i++) {
            numbers[i] = Integer.parseInt(numbersAsStrings[i]);
        }
        numbers[numbersAsStrings.length] = 0;
        ArrayList<String> seq = new ArrayList<>();
        for (int i = 0; i < numbers.length - 1; i++) {
            if (numbers[i] < numbers[i + 1]) {
                StringBuilder sb = new StringBuilder();
                int count = i;
                while (true) {
                    sb.append(numbers[count] + " ");
                    count++;
                    if (!(count < numbers.length - 1 && numbers[count - 1] < numbers[count])) {
                        break;
                    }
                }
                seq.add(sb.toString().trim());
                i = count - 1;
            } else {
                seq.add(numbers[i] + "");
            }

        }
        int maxLenght = 0;
        int count = 0;
        for (int i = 0; i < seq.size(); i++) {
            String s = seq.get(i);
            int length = s.length() - s.replace(" ", "").length();
            if (maxLenght < length) {
                maxLenght = length;
                count = i;
            }
            System.out.println(s);
        }
        System.out.println("Longest: " + seq.get(count));

    }
}
