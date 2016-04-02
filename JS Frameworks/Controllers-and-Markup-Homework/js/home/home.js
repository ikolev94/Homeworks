'use strict';

angular.module('videoSystem.home', ['ngRoute'])

    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/home', {
            templateUrl: 'js/home/home.html',
            controller: 'HomeCtrl'
        });
    }])

    .controller('HomeCtrl', ['$scope', 'videoService', function ($scope, videoService) {
        videoService.getAllVideos(
            function (data) {
                $scope.videos = data;
            },
            function (error, status, headers, config) {
                console.log(status, error);
            });

    }]);