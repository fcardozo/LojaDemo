(function () {
    'use strict';

    // create the module and name it LojaDemoApp
    var LojaDemoApp = angular.module('LojaDemoApp');

    LojaDemoApp.controller('HomeController', function ($scope, $interval, $location, $rootScope, $cookies, $window, CategoryService) {

        if ($window.document.activeElement != null)
            $window.document.activeElement.blur();

        $scope.$on('handleBroadcast', function () {
            $scope.UserAuth = $rootScope.UserAuth;
        });

        $scope.ChoseItem = "";

        $scope.LoadAllOfCategory = function () {
            CategoryService.GetAllCategoryForList().then(
               function (response) {
                   $scope.ListOfCategory = response.ListOfCategoryItem;
               },
                 function (errorMessage) {
                     $scope.ListOfCategory = [];
                 }
              );
        }

        $scope.TestSelect = function () {
            // alert($scope.ChoseItem);
            $window.document.activeElement.blur();
        }

    });

})();