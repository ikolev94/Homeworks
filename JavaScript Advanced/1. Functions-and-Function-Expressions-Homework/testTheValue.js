function funcTest() {
    "use strict";
    var a = 12;
    testContext();
}

function testContext() {
    "use strict";
    console.log(this);
}
//funcTest();
//testContext();
//var a = new testContext();
