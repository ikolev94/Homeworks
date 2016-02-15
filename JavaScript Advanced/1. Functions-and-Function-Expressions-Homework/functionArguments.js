function printArgsInfo() {
    "use strict";
    var i;
    for (i = 0; i < arguments.length; i++) {
        console.log(arguments[i] + '(' + typeof arguments[i] + ')');
    }
}

//printArgsInfo.apply();
//printArgsInfo.call();
//printArgsInfo.call(this, 2, 3, 'hey');
//printArgsInfo.apply(this, [2, 3, 'hey']);

//printArgsInfo("some string", [1, 2], ["string", "array"], ["mixed", 2, false, "array"], {name: "Peter", age: 20});
//printArgsInfo(2, 3, 2.5, -100.5564, false);
//printArgsInfo(null, undefined, "", 0, [], {});