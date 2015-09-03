import java.util.Scanner;

public class AngleUnitConverter {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int times = scanner.nextInt();
        scanner.nextLine();
        for (int i = 0; i < times; i++) {
            String[] inputParams = scanner.nextLine().split(" ");
            double numberToConvert = Double.parseDouble(inputParams[0]);
            String measure = inputParams[1];
            if (measure.equals("deg")) {
                double numberInRadians = degreesToRadiansConverter(numberToConvert);
                System.out.printf("%.6f rad\n", numberInRadians);
            } else {
                double numberInDegrees = radiansToDegreesConverter(numberToConvert);
                System.out.printf("%.6f deg\n", numberInDegrees);
            }
        }
    }

    private static double degreesToRadiansConverter(double degrees) {
        return Math.PI * degrees / 180.0;
    }

    private static double radiansToDegreesConverter(double radians) {
        return 180.0 * radians / Math.PI;
    }
}
