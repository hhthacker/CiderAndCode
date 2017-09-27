app.config(["$routeProvider", function ($routeProvider) {
    $routeProvider
        .when("/pickapples",
        {
            templateUrl: "/app/views/PickApples/PickApples.html",
            controller: "pickApplesController"
        })
        .when("/viewbushels",
        {
            templateUrl: "/app/views/ViewBushels/ViewBushels.html",
            controller: "viewBushelsController"
        });
}]);