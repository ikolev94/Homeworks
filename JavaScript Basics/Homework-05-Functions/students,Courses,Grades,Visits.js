function solve(input) {
    var courses = {};
    input.forEach(function (line) {
        var lineArgs = line.trim().split(/\s?\|\s?/g);
        var name = lineArgs[0].trim();
        var course = lineArgs[1].trim();
        var grade = Number(lineArgs[2]);
        var visits = Number(lineArgs[3]);

        if (!courses[course]) {
            courses[course] = {
                'avgGrade': 0,
                'avgVisits': 0,
                'students': [],
                'count': 0
            };
        }
        courses[course]['avgGrade'] += grade;
        courses[course]['avgVisits'] += visits;
        courses[course]['count']++;
        if (courses[course]['students'].indexOf(name) == -1) {
            courses[course]['students'].push(name);
        }

    });

    var sortKeys = Object.keys(courses).sort();
    var sortCourses = {};
    for (var i = 0; i < sortKeys.length; i++) {
        var currentCourse = sortKeys[i];
        sortCourses[currentCourse] = courses[currentCourse];
        sortCourses[currentCourse].students.sort();
        sortCourses[currentCourse].avgGrade = Number((sortCourses[currentCourse].avgGrade
        / sortCourses[currentCourse].count).toFixed(2));
        sortCourses[currentCourse].avgVisits = Number((sortCourses[currentCourse].avgVisits
        / sortCourses[currentCourse].count).toFixed(2));
        delete sortCourses[currentCourse].count;
    }

    console.log(JSON.stringify(sortCourses));
}
//
//solve([
//    'Peter Nikolov | PHP  | 5.50 | 8',
//    'Maria Ivanova | Java | 5.83 | 7',
//    'Ivan Petrov   | PHP  | 3.00 | 2',
//    'Ivan Petrov   | C#   | 3.00 | 2',
//    'Peter Nikolov | C#   | 5.50 | 8',
//    'Maria Ivanova | C#   | 5.83 | 7',
//    'Ivan Petrov   | C#   | 4.12 | 5',
//    'Ivan Petrov   | PHP  | 3.10 | 2',
//    'Peter Nikolov | Java | 6.00 | 9'
//]);