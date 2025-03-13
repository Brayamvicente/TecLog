(function () {
    'use strict';

    app.controller("SignInController",['$scope','$location','$http','API_BASE_URL','$timeout', function ($scope, $location, $http, API_BASE_URL, $timeout) {
        $scope.Usuario = {};
        $scope.msgRetornoReg = '';
        
        $scope.RegistraUsuario = function () {
            console.log($scope.Usuario);
            $http.post('Usuario/Registro', $scope.Usuario,API_BASE_URL)
                .then(function (response) {
                    if (response.status === 204) {
                        $scope.msgRetornoReg = 'Usuario cadastrado com sucesso!';
                        
                        $timeout(function () {
                            $location.path('/index.html')
                        }, 5000);
                        
                    }
                    response.data;
                }).catch(function (error) {
                console.error("Erro na requisição:", error);
            });
        }
        
        
    }]);
})();