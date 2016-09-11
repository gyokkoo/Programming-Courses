function extractCapitalLetterWords(arr) {
    let text = arr.join(",");
    let words = text.split(/\W+/).filter(x => x != "");
    let capitalWords = words.filter(x => x.toUpperCase() == x);

    console.log(capitalWords.join(", "));
}

extractCapitalLetterWords([
    'We start by HTML, CSS, JavaScript, JSON and REST. Later we touch some PHP, MySQL and SQL.',
    'Later we play with C#, EF, SQL Server and ASP.NET MVC. Finally, we touch some Java, Hibernate and Spring.MVC.',
]);