import java.util.*;

public class _3_ExamScore {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        for (int i = 0; i < 3; i++) {
            scanner.nextLine();
        }
        TreeMap<Integer, TreeMap<String, Double>> examScores = new TreeMap<>();
        String inputLine = scanner.nextLine();
        while(!inputLine.contains("-")) {
            inputLine = inputLine.replaceAll("\\s+", " ");
            inputLine = inputLine.substring(1, inputLine.length() - 1);
            String[] inputArgs = inputLine.split("\\|");
            String name = inputArgs[0].trim();
            int score = Integer.parseInt(inputArgs[1].trim());
            double grade = Double.parseDouble(inputArgs[2].trim());

            if(!examScores.containsKey(score)) {
                TreeMap<String, Double> studentScores = new TreeMap<>();
                studentScores.put(name, grade);
                examScores.put(score, studentScores);
            } else {
                examScores.get(score).put(name, grade);
            }

            inputLine = scanner.nextLine();
        }

        for (Map.Entry<Integer, TreeMap<String, Double>> entry : examScores.entrySet()) {
            System.out.print(entry.getKey() + " -> ");
            double sumGrade = 0;
            double studentCounter = 0;
            List<String> students = new ArrayList<>();
            for (Map.Entry<String, Double> entry2 : entry.getValue().entrySet()) {
                sumGrade += entry2.getValue();
                studentCounter++;
                students.add(entry2.getKey());
            }
            System.out.printf("%s; avg=%.2f\n", students, sumGrade/studentCounter);
        }
    }
}
