import java.util.Scanner;

public class FormattingNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int a = scanner.nextInt();
        float b = scanner.nextFloat();
        float c = scanner.nextFloat();

        String aToHex = Integer.toHexString(a).toUpperCase();
        int aToBinary = Integer.parseInt(Integer.toBinaryString(a));

        System.out.printf("|%-10s|%010d|%10.2f|%-10.3f|",aToHex,aToBinary,b,c);
    }
}
