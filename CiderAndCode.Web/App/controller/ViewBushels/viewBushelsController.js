app.controller("viewBushelsController", ["$http", "$scope", function ($http, $scope) {
    $scope.thief = [];
    $scope.bushel = [];

    $http.get("/api/Bushels/list")
        .then(function (result) {
            $scope.bushels = result.data;
        });

    $scope.stealApples = function (id) {
        console.log(id, "id");
        $http.delete(`/api/Bushels/${id}`)
            .catch(error => console.log(error));
        $scope.show = false;
    };


}]);