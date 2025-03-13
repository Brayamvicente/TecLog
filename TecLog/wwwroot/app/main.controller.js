(function () {
    'use strict';

    app.controller("MainController",['$scope','$location','$http','API_BASE_URL', function ($scope, $location, $http, API_BASE_URL) {
        $scope.Login = {};
        $scope.msgRetorno = '';

        $scope.isSignInRoute = function () {
            console.log($location.path());
            return $location.path() === "/SignIn"
        }

        $scope.fazerLogin = function () {
            console.log($scope.Login)
            console.log(API_BASE_URL);
            $http.post('Auth/Login', $scope.Login,API_BASE_URL)
                .then(function (response) {
                    if (response.status === 200) {
                        $scope.msgRetorno = 'Usuario Logado';
                    }
                response.data;
            }).catch(function (error) {
                if (error.status === 401 || error.status === 400){
                    $scope.msgRetorno = 'Usuario e/ou senha incorretos';
                }
                else if(error.status === 404){
                    $scope.msgRetorno = 'Usuario não encontrado';
                }
            });
        }
    }]);
})();
