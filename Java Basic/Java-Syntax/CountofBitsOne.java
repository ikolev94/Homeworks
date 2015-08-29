import java.util.Scanner;

public class CountofBitsOne {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();

        String nToBin = Integer.toBinaryString(n);
        int countOfBits = 0;
        for (char c : nToBin.toCharArray()) {
            if (c=='1'){
                countOfBits++;
            }
        }
        System.out.printf("%010d\n", Integer.parseInt(nToBin));
        System.out.print(countOfBits);
    }
}
