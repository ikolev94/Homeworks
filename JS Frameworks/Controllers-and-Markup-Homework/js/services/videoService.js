app.factory('videoService', ['$http', 'BAAS', function ($http, BAAS) {

    var factory = {};

    factory.getAllVideos = function getAllVideos(success, error) {
        $http.get(BAAS.VIDEOS_URL, {headers: BAAS.HEADERS})
            .success(function (data) {
                success(data);
            }).error(error);
    };

    factory.getVideoById = function getVideoById(id, success, error) {
        $http.get(BAAS.VIDEOS_URL + id, {headers: BAAS.HEADERS})
            .success(function (data) {
                success(data);
            }).error(error);
    };

    factory.addVideo = function addVideo(data, success, error) {
        $http.post(BAAS.VIDEOS_URL, data, {headers: BAAS.HEADERS})
            .success(function (info) {
                success(info)
            }).error(error);
    };

    factory.updateVideo = function updateVideo(data, error) {
        $http.put(BAAS.VIDEOS_URL + data._id, data, {headers: BAAS.HEADERS})
            .error(error);
    };

    return factory;
}]);