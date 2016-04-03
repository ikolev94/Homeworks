'use strict';

angular.module('videoSystem.addVideo', ['ngRoute'])

    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/add-video', {
            templateUrl: 'js/addVideo/addVideo.html',
            controller: 'AddVideoCtrl'
        });
    }])
    .controller('AddVideoCtrl', ['$scope', '$location', 'videoService', function ($scope, $location, videoService) {

        function validateVideo(video) {
            if (!video.title || !video.length || !video.category) {
                $scope.invalidVideo = 'Invalid input';
                return false;
            }
            if (!/(https?|ftp):\/\/(-\.)?([^\s\/?\.#-]+\.?)+(\/[^\s]*)?$/.test(video.picture)) {
                $scope.invalidVideo = 'Invalid Image src';
                return false;
            }
            return true;
        }

        $scope.addVideo = function (data) {
            if (validateVideo(data)) {
                data.comments = [];
                data.comments.push(
                    {
                        "username": "LOrka",
                        "data": new Date(),
                        "content": "NAI Qkoto !!! le",
                        "picture": "http://www.eurogeosurveys.org/wp-content/uploads/2014/02/default_profile_pic.jpg"
                    });
                videoService.addVideo(data, function (s) {
                    console.log(s);
                    $location.path('/home');
                }, function (error) {
                    console.log('FAIL to add video');
                    $location.path('/home');
                })
            }
        }

    }]);


