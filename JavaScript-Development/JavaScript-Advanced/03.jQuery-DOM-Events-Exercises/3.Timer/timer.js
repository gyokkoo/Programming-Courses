function timer() {
    let secondsElement = $("#seconds");
    let minutesElement = $("#minutes");
    let hoursElement = $("#hours");
    let startBtn = $("#start-timer");
    let stopBtn = $("#stop-timer");
    let timer = undefined;

    startBtn.click(function () {
        if (!timer) {
            timer = setInterval(step, 1000);
        }
    });

    stopBtn.click(function () {
        clearInterval(timer);
        timer = undefined;
    });
    let totalSeconds = 0;

    function step() {
        totalSeconds++;
        secondsElement.text(formatTime(totalSeconds % 60));
        let mins = totalSeconds / 60;
        minutesElement.text(formatTime(mins % 60));
        let hours = totalSeconds / 3600;
        hoursElement.text(formatTime(hours));
    }

    function formatTime(num) {
        return pad(Math.floor(num));
    }

    function pad(num) {
        if (num <= 9) {
            num = `0${num}`;
        }
        return num;
    }
}