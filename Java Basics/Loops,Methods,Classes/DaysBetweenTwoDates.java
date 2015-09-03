import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;
import java.util.Scanner;

public class DaysBetweenTwoDates {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        LocalDate start = LocalDate.parse(scanner.nextLine(), DateTimeFormatter.ofPattern("d-MM-yyyy"));
        LocalDate end = LocalDate.parse(scanner.nextLine(), DateTimeFormatter.ofPattern("d-MM-yyyy"));
        System.out.println(ChronoUnit.DAYS.between(start, end));
    }
}
