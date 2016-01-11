function arrayManipulator(arr) {

    function compareNubs(a, b) {
        return a - b;
    }

    function popular(array) {
        if (array.length == 0) return [null, 0];
        var n = max = 1, maxNum = array[0], pv, cv;

        for (var i = 0; i < array.length; i++, pv = array[i - 1], cv = array[i]) {
            if (pv == cv) {
                if (++n >= max) {
                    max = n;
                    maxNum = cv;
                }
            } else n = 1;
        }

        return [maxNum];
    }

    var sortedNubs = [];
    for (var i = 0; i < arr.length; i++) {
        var obj = arr[i];
        if (!isNaN(obj)) {
            sortedNubs.push(Number(obj));
        }
    }
    sortedNubs.sort(compareNubs);

    console.log('Min number: ' + sortedNubs[0]);
    console.log('Min number: ' + sortedNubs[sortedNubs.length - 1]);
    console.log('Most frequent number: ' + popular(sortedNubs));
    console.log(sortedNubs);

}
var test = ["Pesho", 2, "Gosho", 12, 2, 2, "true", 9, undefined, 0, "Penka", {bunniesCount: 10}, [10, 20, 30, 40]];
arrayManipulator(test);