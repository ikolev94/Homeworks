var Person = (function () {
    function Person(firstName, secondName, age) {
        this.firstName = firstName;
        this.lastName = secondName;
        this.age = age;
    }

    Person.prototype.toString = function () {
        return this.firstName + ' ' + this.lastName + ' (age ' + this.age + ')';
    };

    return Person;
}());

function groupBy(criteria) {
    selectedOnes = [];

    people.forEach(function (person) {
        if (selectedOnes.indexOf(person[criteria]) === -1) {
            selectedOnes.push(person[criteria]);
        }
    });

    selectedOnes.sort().forEach(function (c) {
        var output = [];
        people.forEach(function (person) {
            if (person[criteria] === c) {
                output.push(person.toString())
            }
        });

        console.log('Group ' + c + ' [' + output.join(', ') + ']');
    });

}

var people = [
    new Person("Scott", "Guthrie", 38),
    new Person("Scott", "Johns", 36),
    new Person("Scott", "Hanselman", 39),
    new Person("Jesse", "Liberty", 57),
    new Person("Jon", "Skeet", 38)
];

groupBy('age');
console.log();
groupBy('lastName');
console.log();
groupBy('firstName');