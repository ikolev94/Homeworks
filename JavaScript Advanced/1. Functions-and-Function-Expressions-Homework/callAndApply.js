function printArgsInfo() {
    for (var i = 0; i < arguments.length; i++) {
        console.log(arguments[i] + '(' + typeof arguments[i] + ')');
    }
}

//printArgsInfo.apply();
//printArgsInfo.call();
//printArgsInfo.call(this, 2, 3, 'hey');
//printArgsInfo.apply(this, [2, 3, 'hey']);