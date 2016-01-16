function clone(obj) {
    return JSON.parse(JSON.stringify(obj));
}

function compareObjects(obj, objCopy) {
    console.log('obj == b --> ' + (obj == objCopy));
}

var obj = {name: 'Tesla', age: 12};
var deepCopy = clone(obj);
compareObjects(obj, deepCopy);

var shallowCopy = obj;
compareObjects(obj, shallowCopy);