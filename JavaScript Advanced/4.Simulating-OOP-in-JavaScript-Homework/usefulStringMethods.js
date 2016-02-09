String.prototype.startsWith = function (substring) {
    var regex = new RegExp('^' + substring);
    return regex.test(this);
};

String.prototype.endsWith = function (substring) {
    var regex = new RegExp(substring + '$');
    return regex.test(this);
};

String.prototype.left = function (count) {
    var result = '';
    if (count > this.length) {
        count = this.length;
    }
    for (var i = 0; i < count; i++) {
        result += this[i];
    }
    return result;
};

String.prototype.right = function (count) {
    var result = '';
    if (count > this.length) {
        count = this.length;
    }
    var length = this.length;
    var start = length - count;
    for (var i = start; i < length; i++) {
        result += this[i];
    }
    return result;
};

String.prototype.padLeft = function (count, character) {
    var result = '',
        length = count - this.length,
        i;
    character = character || ' ';

    if (length < 0) {
        result = this + '';
        return result;
    }

    for (i = 0; i < length; i++) {
        result += character;
    }
    return result + this;
};

String.prototype.padRight = function (count, character) {
    var result = this + '',
        length = count - this.length,
        i;
    character = character || ' ';

    if (length < 0) {
        return result;
    }

    for (i = 0; i < length; i++) {
        result += character;
    }

    return result;
};

String.prototype.repeat = function (count) {
    var result = '';
    for (var i = 0; i < count; i++) {
        result += this;
    }
    return result;
};

var example = "This is an example string used only for demonstration purposes.";
//console.log(example.startsWith("This"));
//console.log(example.startsWith("this"));
//console.log(example.startsWith("other"));
//console.log(example.endsWith("poses."));
//console.log(example.endsWith("example"));
//console.log(example.startsWith("something else"));
//console.log(example.left(9));
//console.log(example.left(90));
//console.log(example.right(9));
//console.log(example.right(90));
//var example2 = "abcdefgh";
//console.log(example2.left(5).right(2));
var hello = "hello";
//console.log(hello.padLeft(5));
//console.log(hello.padLeft(10));
//console.log(hello.padLeft(5, "."));
//console.log(hello.padLeft(10, "."));
//console.log(hello.padLeft(2, "."));
//console.log(hello.padRight(5));
//console.log(hello.padRight(10));
//console.log(hello.padRight(5, "."));
//console.log(hello.padRight(10, "."));
//console.log(hello.padRight(2, "."));
var character = "*";
console.log(character.repeat(5));
// Alternative syntax
console.log("~".repeat(3));
// Another combination
console.log("*".repeat(5).padLeft(10, "-").padRight(15, "+"));
