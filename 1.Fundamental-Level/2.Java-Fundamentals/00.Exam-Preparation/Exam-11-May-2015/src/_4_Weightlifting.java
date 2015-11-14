import java.util.*;

public class _4_Weightlifting {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());

        TreeMap<String, TreeMap<String, Long>> workout = new TreeMap<>();
        for (int i = 0; i < n; i++) {
            String[] lineArgs = scanner.nextLine().split(" ");
            String player = lineArgs[0];
            String exercise = lineArgs[1];
            long weight = Long.parseLong(lineArgs[2]);

            if(!workout.containsKey(player)) {
                workout.put(player, new TreeMap<>());
                workout.get(player).put(exercise, weight);
            } else {
                if(!workout.get(player).containsKey(exercise)) {
                    workout.get(player).put(exercise, weight);
                } else {
                    weight += workout.get(player).get(exercise);
                    workout.get(player).put(exercise, weight);
                }
            }
        }

        for (Map.Entry<String, TreeMap<String, Long>> entry : workout.entrySet()) {
            System.out.print(entry.getKey() + " : ");
            List<String> output = new ArrayList<>();
            for (Map.Entry<String,Long> entry2 : entry.getValue().entrySet()) {
                output.add(entry2.getKey() + " - " + entry2.getValue() + " kg");
            }
            System.out.println(String.join(", ", output));
        }
    }
}
