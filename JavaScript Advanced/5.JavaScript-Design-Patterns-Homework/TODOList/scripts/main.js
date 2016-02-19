(function () {
    require.config({
        paths: {
            'notie': 'libs/notie',
            'container': 'container',
            'item': 'item',
            'section': 'section'
        }
    })
}());

require(['container'], function (Container) {
    var list = new Container();
    list.addToDom();
});

//var todoList = todoList || {},
//    list = new todoList.Container();
//
//list.addToDom();
