function templateFormat(args) {
    let result = '';
    result += '<?xml version="1.0" encoding="UTF-8"?>\n';
    result += '<quiz>\n';
    for (let i = 0; i < args.length; i += 2) {
        let question = args[i];
        let answer = args[i + 1];

        result += getQuestion(question);
        result += getAnswer(answer);
    }
    result += '</quiz>';
    console.log(result);
    function getQuestion(question) {
        return`\t<question>\n\t\t${question}\n\t</question>\n`;
    }

    function getAnswer(answer) {
        return`\t<answer>\n\t\t${answer}\n\t</answer>\n`;
    }
}

templateFormat(["Dry ice is a frozen form of which gas?",
    "Carbon Dioxide",
    "What is the brightest star in the night sky?",
    "Sirius"]
);
