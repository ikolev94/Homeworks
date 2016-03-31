(function () {
    var app = angular.module('app', []);

    app.controller('imageCtrl', ['$scope', function ($scope) {
        $scope.image = 'http://joomlaworks.net/images/demos/galleries/abstract/7.jpg'
    }])
}());
