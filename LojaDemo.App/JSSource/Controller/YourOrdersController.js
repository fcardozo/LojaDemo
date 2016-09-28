(function () {
    'use strict';

    // create the module and name it LojaDemoApp
    var LojaDemoApp = angular.module('LojaDemoApp');

    LojaDemoApp.controller('YourOrdersController', function ($scope, $interval, $location, $rootScope, $cookies, $window, UserService) {

        $window.document.activeElement.blur();

        $scope.$on('handleBroadcast', function () {
            $scope.UserAuth = $rootScope.UserAuth;
        });

    });

})();