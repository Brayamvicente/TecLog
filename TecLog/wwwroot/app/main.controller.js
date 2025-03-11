(function () {
    "use strict";

    angular.module('teste', ['ngRoute']).controller("MainController", function ($scope,$location) {

            $scope.goToSignIn = function () {
                $location.path('/SignIn')
            };
        })
})();