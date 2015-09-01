import java.util.Scanner;

public class PointsInsideFigure {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        float x = scanner.nextFloat();
        float y = scanner.nextFloat();
        boolean outside = false;
        if (x < 12.5 || x > 22.5) {
            outside = true;
        } else if (y < 6 || y > 13.5) {
            outside = true;
        } else if ((x > 17.5 && x < 20) && y > 8.5) {
            outside = true;
        }

        System.out.printf(" %s ", outside ? "Outside" : "Inside");
    }
}
