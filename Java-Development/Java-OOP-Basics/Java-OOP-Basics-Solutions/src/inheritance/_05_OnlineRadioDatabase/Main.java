package inheritance._05_OnlineRadioDatabase;

import inheritance._05_OnlineRadioDatabase.exceptions.InvalidSongException;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        Playlist playlist = new Playlist();
        int n = Integer.parseInt(reader.readLine());
        for (int i = 0; i < n; i++) {
            try {
                String[] songData = reader.readLine().split(";");
                String artistName = songData[0];
                String songName = songData[1];
                String[] songLength = songData[2].split(":");
                int songMinutes = Integer.parseInt(songLength[0]);
                int songSeconds = Integer.parseInt(songLength[1]);
                Song song = new Song(artistName, songName, songMinutes, songSeconds);
                String result = playlist.addSong(song);
                System.out.println(result);
            } catch (InvalidSongException e) {
                System.out.println(e.getMessage());
            } catch (NumberFormatException e) {
                System.out.println("Invalid song length.");
            }
        }

        System.out.printf("Songs added: %d%n", playlist.getSongsCount());
        System.out.println(playlist);
    }
}
