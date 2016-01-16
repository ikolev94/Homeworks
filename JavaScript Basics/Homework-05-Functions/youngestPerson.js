function findYoungestPerson(array) {
    var youngestOne = array.filter(function (person) {
        return person.hasSmartphone
    }).sort(function (a, b) {
        return a.age - b.age
    })[0];

    console.log('The youngest person is ' + youngestOne.firstname + ' ' + youngestOne.lastname)
}

var people = [
    {firstname: 'George', lastname: 'Kolev', age: 32, hasSmartphone: false},
    {firstname: 'Vasil', lastname: 'Kovachev', age: 40, hasSmartphone: true},
    {firstname: 'Bay', lastname: 'Ivan', age: 81, hasSmartphone: true},
    {firstname: 'Baba', lastname: 'Ginka', age: 40, hasSmartphone: false}];

findYoungestPerson(people);