package inheritance._05_OnlineRadioDatabase;

import java.util.ArrayList;
import java.util.List;

public class Playlist {
    private List<Song> songs;

    public Playlist() {
        this.songs = new ArrayList<>();
    }

    public String addSong(Song song) {
        songs.add(song);

        return "Song added.";
    }

    public int getSongsCount() {
        return this.songs.size();
    }

    @Override
    public String toString() {
        long totalSeconds = 0;
        for (Song song : songs) {
            totalSeconds += song.getSeconds();
            totalSeconds += song.getMinutes() * 60;
        }

        return String.format("Playlist length: %dh %dm %ds",
                totalSeconds / 3600,
                (totalSeconds % 3600) / 60,
                totalSeconds % 60);
    }
}