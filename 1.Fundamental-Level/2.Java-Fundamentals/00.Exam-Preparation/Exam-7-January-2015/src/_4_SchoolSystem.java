import java.util.*;

public class _4_SchoolSystem {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());

        TreeMap<String, TreeMap<String, List<Double>>> students = new TreeMap<>();
        for (int i = 0; i < n; i++) {
            String[] lineArgs = scanner.nextLine().split(" ");
            String name = lineArgs[0] + " " + lineArgs[1];
            String subject = lineArgs[2];
            double score = Double.parseDouble(lineArgs[3]);

            if(!students.containsKey(name)) {
                students.put(name, new TreeMap<>());
                List<Double> scores = new ArrayList<>();
                scores.add(score);
                students.get(name).put(subject, scores);
            } else {
                if(!students.get(name).containsKey(subject)) {
                    List<Double> scores = new ArrayList<>();
                    scores.add(score);
                    students.get(name).put(subject, scores);
                } else {
                    List<Double> oldScores = students.get(name).get(subject);
                    oldScores.add(score);
                    students.get(name).put(subject, oldScores);
                }
            }
        }

        for (Map.Entry<String, TreeMap<String, List<Double>>> entry : students.entrySet()) {
            System.out.print(entry.getKey() + ": [");
            List<String> output = new ArrayList<>();
            for (Map.Entry<String, List<Double>> entry2 : entry.getValue().entrySet()) {
                double sum = 0;
                for (int i = 0; i < entry2.getValue().size(); i++) {
                    sum += entry2.getValue().get(i);
                }
                double average = sum / entry2.getValue().size();
                output.add(String.format("%s - %.2f", entry2.getKey(), average));
            }
            System.out.print(String.join(", ", output) + "]\n");
        }
    }
}
