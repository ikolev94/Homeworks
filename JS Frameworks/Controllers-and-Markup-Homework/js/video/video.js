'use strict';

angular.module('videoSystem.video', ['ngRoute'])

    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/video/:id', {
            templateUrl: 'js/video/video.html',
            controller: 'VideoCtrl'
        });
    }])

    .controller('VideoCtrl', ['$scope', '$routeParams', '$rootScope', 'videoService',
        function ($scope, $routeParams, $rootScope, videoService) {
            var videoIsChanged = false;
            $scope.newComment = {};
            $scope.addComment = function (video) {
                $scope.newComment.date = new Date();
                $scope.newComment.picture = $scope.newComment.picture
                    || 'http://simpleicon.com/wp-content/uploads/user1.png';
                video.comments.push($scope.newComment);
                $scope.newComment = {};
                videoIsChanged = true;
            };

            videoService.getVideoById($routeParams['id'],
                function (data) {
                    $scope.video = data;
                },
                function (error, status, headers, config) {
                    console.log(status, error);
                });

            $scope.$on('$locationChangeStart', function () {
                if (videoIsChanged) {
                    videoService.updateVideo($scope.video, function (error) {
                        console.log(error);
                    })
                }
            });
        }]);