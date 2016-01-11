function arrayManipulator(arr) {

    function compareNubs(a,b) {
        return a - b;
    }

    var sortedNubs =[];
    for (var i = 0; i < arr.length; i++) {
        var obj = arr[i];
        if (!isNaN(obj)) {
            sortedNubs.push(Number(obj));
        }
    }
    sortedNubs.sort(compareNubs);

    console.log('Min number: '+ sortedNubs[0]);
    console.log('Min number: '+ sortedNubs[sortedNubs.length - 1]);
    console.log(sortedNubs);

}
var test = ["Pesho", 2, "Gosho", 12, 2, "true", 9, undefined, 0, "Penka", { bunniesCount : 10}, [10, 20, 30, 40]];
arrayManipulator(test);