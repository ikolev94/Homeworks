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
            function (error, status) {
                console.log(status, error);
            });

        $scope.getDate = function (d) {
            if (d) {
                $scope.filterBy = {date: {}};
                $scope.filterBy.date = d.toISOString();
            }
        };

        $scope.formatDate = function (date) {
            $scope.filterBy.date = date.toISOString();
        }

    }]);