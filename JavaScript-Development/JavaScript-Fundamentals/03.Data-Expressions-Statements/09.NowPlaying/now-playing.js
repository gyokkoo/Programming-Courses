function nowPlaying(args) {
    let artistName = args[0];
    let trackName = args[1];
    let duration = args[2];

    console.log(`Now Playing: ${trackName} - ${artistName} [${duration}]`);
}

nowPlaying(['Number One', 'Nelly', '4:09']);