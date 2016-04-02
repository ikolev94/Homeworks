app.factory('videoService', ['$http', 'BAAS', function ($http, BAAS) {

    var factory = {};

    factory.getAllVideos = function getAllVideos(success, error) {
        $http.get(BAAS.VIDEOS_URL, {headers: BAAS.HEADERS})
            .success(function (data) {
                success(data);
            }).error(error);
    };

    factory.addVideo = function (data, success, error) {
        $http.post(BAAS.VIDEOS_URL, data, {headers: BAAS.HEADERS})
            .success(function (info) {
                success(info)
            }).error(error);
    };

    return factory;
}]);