(function () {
    'use strict';

    app.controller("SignInController",['$scope','$location','$http','API_BASE_URL', function ($scope, $location, $http, API_BASE_URL) {
        $scope.Usuario = {};
        $scope.msgRetornoReg = '';
        
        $scope.RegistraUsuario = function () {
            console.log('RegistraUsuario');
            $http.post('Usuario/Registro', $scope.Usuario,API_BASE_URL)
                .then(function (response) {
                    if (response.status === 204) {
                        $scope.msgRetornoReg = 'Usuario cadastrado com sucesso!';
                    }
                    response.data;
                }).catch(function (error) {
                console.error("Erro na requisição:", error);
            });
        }
    }]);
})();