(function () {
    'use strict';

    app.controller("MainController", function ($scope, $location) {
        console.log("maincontroller sendo processada")

        $scope.isSignInRoute = function () {
            console.log("maincontroller" + $location.path())
            return $location.path() === "/SignIn"
        }
    });
})();
