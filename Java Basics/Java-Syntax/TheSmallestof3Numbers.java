import java.util.Scanner;

public class TheSmallestof3Numbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double firstNum = scanner.nextDouble();
        double secNum = scanner.nextDouble();
        double thirdNum = scanner.nextDouble();

        double smallest = Math.min(Math.min(firstNum, secNum), thirdNum);
        System.out.println(smallest);
    }
}
