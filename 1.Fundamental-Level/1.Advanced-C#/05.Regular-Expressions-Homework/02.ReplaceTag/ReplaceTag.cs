using System;
using System.Text.RegularExpressions;
/*
Write a program that replaces in a HTML document given as string all the tags <a href=…>…</a> with corresponding tags [URL href=…]…[/URL]. Print the result on the console. 
The value of the href attribute can be enclosed in single or double quotes. The opening quotes must be the same as the closing closed (e.g. this is invalid: href='softuni.bg").
Examples:
Input	               
"<ul>
 <li>
  <a href="http://softuni.bg">SoftUni</a>
 </li>
</ul>"	
 Output 
 <ul>
 <li>
  [URL href=http://softuni.bg]SoftUni[/URL]
 </li>
</ul>

 */
class ReplaceTag
{
    static void Main()
    {
        Console.Title = "Problem 2.	Replace <a> tag";

        string htmlText = @"<ul>
 <li>
  <a href=http://softuni.bg>SoftUni</a>
 </li>
</ul>";

        /*
        string htmlText = @"<ul>
 <li>
  <a href='http://softuni.bg'>SoftUni</a>
 </li>
</ul>";
        */
        string pattern = @"<a.*href=(.*|\n)>(.*|\n)<\/a>";

        string replacement = @"[URL href=$1]$2[/URL]";

        Regex regex = new Regex(pattern);

        Console.WriteLine(regex.Replace(htmlText, replacement));
    }
}
