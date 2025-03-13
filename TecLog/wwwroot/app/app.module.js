(function () {
    'use strict';

    var app = angular.module('teste', ['ngRoute']);
    
    app.constant('API_BASE_URL', 'https://localhost:7113/');
    window.app = app;
})();