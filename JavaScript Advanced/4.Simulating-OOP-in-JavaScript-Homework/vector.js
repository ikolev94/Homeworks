var Vector = (function () {
    "use strict";
    function Vector(components) {
        this.setComponents(components);
    }

    Vector.prototype.getComponents = function () {
        return this._components;
    };

    Vector.prototype.setComponents = function (components) {
        if (!components || !components.length) {
            throw new Error('Invalid components');
        }
        this._components = components;
    };

    Vector.prototype.add = function (vectorToAdd) {
        if (this.getComponents().length !== vectorToAdd.getComponents().length) {
            throw new Error('Vectors components number must be equal');
        }
        return new Vector(this.getComponents().map(function (num, index) {
            return num + vectorToAdd.getComponents()[index];
        }));

    };

    Vector.prototype.subtract = function (vectorToSubtract) {
        if (this.getComponents().length !== vectorToSubtract.getComponents().length) {
            throw new Error('Vectors components number must be equal');
        }
        return new Vector(this.getComponents().map(function (num, index) {
            return num - vectorToSubtract.getComponents()[index];
        }));
    };

    Vector.prototype.dot = function (vectorToDot) {
        if (this.getComponents().length !== vectorToDot.getComponents().length) {
            throw new Error('Vectors components number must be equal');
        }
        var sum = 0;
        this.getComponents().forEach(function (e, index) {
            sum += e * vectorToDot.getComponents()[index];
        });
        return sum;
    };

    Vector.prototype.norm = function () {
        var result = 0;
        this.getComponents().forEach(function (e) {
            result += e * e;
        });
        return Math.sqrt(result);
    };

    Vector.prototype.toString = function () {
        return this.getComponents().join(', ');
    };

    return Vector;
}());

var a = new Vector([1, 2, 3]);
var b = new Vector([4, 5, 6]);
var c = new Vector([1, 1, 1, 1, 1, 1, 1, 1, 1, 1]);
console.log(a.toString());
console.log(c.toString());

// The following throw errors
//var wrong = new Vector();
//var anotherWrong = new Vector([]);
var result = a.add(b);
console.log(result.toString());
//a.add(c);
result = a.subtract(b);
console.log(result.toString());
result = a.dot(b);
console.log(result);

console.log(a.norm());
console.log(b.norm());
console.log(c.norm());
console.log(a.add(b).norm());