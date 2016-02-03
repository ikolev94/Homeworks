function funcTest() {
    var a = 12;
    testContext();
}

function testContext() {
    console.log(this);
}
//funcTest();
//testContext();
//var a = new testContext();
