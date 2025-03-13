(function () {
    'use strict';
        
    app.config(["$routeProvider", "$locationProvider", function ($routeProvider, $locationProvider) { 
        $locationProvider.html5Mode(true).hashPrefix('');
        $routeProvider
            .when('/SignIn', {
                templateUrl: '/views/signin.html',
                controller: 'SignInController'
            })
            .otherwise({ redirectTo: '/' });
    }]);
}) ();