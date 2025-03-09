(function () {
    "use strict";

    angular.module("app")
        .controller("MainController", function ($scope) {

            $scope.teste = "Mundo";

            $scope.mostrarMensagem = function () {
                $scope.mensagem = "Você clicou no botão!";
            };
        })
})();