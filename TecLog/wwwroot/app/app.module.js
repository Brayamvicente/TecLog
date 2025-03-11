(function () {
    'use strict';

    var app = angular.module('teste', ['ngRoute']);

    console.log("agora vai")

    console.log(app);

    app.config(["$routeProvider", "$locationProvider", function ($routeProvider, $locationProvider) {

        console.log("O config() começou!");

        $locationProvider.hashPrefix('');

        console.log("AngularJS config!");

        $routeProvider
            .when('/SignIn', {
                templateUrl: '/views/signin.html',
                controller: 'SignInController'
            })
            .otherwise({ redirectTo: '/SignIn' });


    }]);
})();