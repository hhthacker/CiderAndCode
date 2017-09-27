app.controller("pickApplesController", ["$http", "$scope", function ($http, $scope) {
    $scope.bushel = {};
    $scope.user = [];

    $http.get("/api/users/list")
        .then(function (result) {
            $scope.users = result.data;
        });

    $scope.pickApples = function () {
        let bushel = $scope.bushel;
        console.log("bushel", bushel);
        $http.post("/api/PickApples",
            {
                Type: bushel.appleType,
                NumberOfBushels: bushel.numberOfBushels,
                UserId: bushel.userId
            })
            .catch(error => console.log(error));
            };

}]); 