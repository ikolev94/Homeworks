'use strict';

var app = angular.module('videoSystem', ['ngRoute', 'videoSystem.home', 'videoSystem.addVideo'])
    .constant('BAAS', {
        "VIDEOS_URL": 'https://baas.kinvey.com/appdata/kid_W1D-ZR7pCl/videos',
        "HEADERS": {
            'Authorization': 'Basic cXVlc3Q6cXVlc3Q=',
            'Content-Type': 'application/json'
        }
    })
    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.otherwise({redirectTo: '/home'});
    }]);