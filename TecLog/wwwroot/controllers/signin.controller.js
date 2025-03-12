(function () {
    'use strict';

    app.controller("SignInController", function ($scope, $location) {

        $scope.isSignInRoute() = function () {
            return $location.path() === "/SignIn"
        }
    });
})();