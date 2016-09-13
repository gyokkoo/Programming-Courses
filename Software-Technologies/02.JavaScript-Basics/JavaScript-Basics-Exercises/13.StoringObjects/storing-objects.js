function storingObjects(args) {
    class Student {
        constructor(name, age, grade) {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }
    }

    let students = [];
    for (let i = 0; i < args.length; i++) {
        let tokens = args[i].split(" -> ");
        let name = tokens[0];
        let age = tokens[1];
        let grade = tokens[2];

        students.push(new Student(name, age, grade));
        // students.push({Name: name, Age: age, Grade: grade});
    }

    for (let student of students) {
        console.log(`Name: ${student.Name}`);
        console.log(`Age: ${student.Age}`);
        console.log(`Grade: ${student.Grade}`);
    }
}

storingObjects(['Pesho -> 13 -> 6.00', 'Ivan -> 12 -> 5.57']);