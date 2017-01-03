package inheritance._05_OnlineRadioDatabase;

import inheritance._05_OnlineRadioDatabase.exceptions.InvalidArtistNameException;
import inheritance._05_OnlineRadioDatabase.exceptions.InvalidSongMinutesException;
import inheritance._05_OnlineRadioDatabase.exceptions.InvalidSongNameException;
import inheritance._05_OnlineRadioDatabase.exceptions.InvalidSongSecondsException;

public class Song {
    private String artistName;
    private String name;
    private int minutes;
    private int seconds;

    public Song(String artistName, String name, int minutes, int seconds) {
        this.setArtistName(artistName);
        this.setName(name);
        this.setMinutes(minutes);
        this.setSeconds(seconds);
    }

    public int getMinutes() {
        return minutes;
    }

    public int getSeconds() {
        return seconds;
    }

    private void setArtistName(String artistName) {
        if (artistName == null || artistName.trim().length() < 3 || 20 < artistName.trim().length()) {
            throw new InvalidArtistNameException();
        }

        this.artistName = artistName;
    }

    private void setName(String name) {
        if (name == null || name.trim().length() < 3 || 30 < name.trim().length()) {
            throw new InvalidSongNameException();
        }

        this.name = name;
    }

    private void setMinutes(int minutes) {
        if (minutes < 0 || 14 < minutes) {
            throw new InvalidSongMinutesException();
        }

        this.minutes = minutes;
    }

    private void setSeconds(int seconds) {
        if (seconds < 0 || 59 < seconds) {
            throw new InvalidSongSecondsException();
        }

        this.seconds = seconds;
    }
}