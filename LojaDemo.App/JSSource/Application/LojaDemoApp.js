(function () {
    'use strict';

    // create the module and name it LojaDemoApp
    var LojaDemoApp = angular.module('LojaDemoApp', ['ngRoute', 'ngCookies']);

    // configure our routes
    LojaDemoApp.config(function ($routeProvider) {
        $routeProvider

            // route for the home page
            .when('/', {
                templateUrl: '../../HtmlSource/Home/Home.html',
                controller: 'HomeController'
            })

            .when('/YourOrders', {
                templateUrl: '../../HtmlSource/User/YourOrders.html',
                controller: 'HomeController'
            })

             .when('/Cart', {
                 templateUrl: '../../HtmlSource/Home/Cart.html',
                 controller: 'CartController'
             })

            .otherwise({ redirectTo: '/' });
    });

    LojaDemoApp.run(['$rootScope', '$location', '$cookies', '$http',
        function ($rootScope, $location, $cookies, $http) {

            // keep user logged in after page refresh

            $rootScope.UserAuth = $cookies.getObject('loginCredential');

            if ($rootScope.UserAuth) {
                $http.defaults.headers.common['Authorization'] = 'Basic ' + $rootScope.UserAuth.TokenValid; // jshint ignore:line
            }

            $rootScope.$on('$locationChangeStart', function (event, next, current) {
                // redirect to login page if not logged in
                if ($location.path() == '/YourOrders' && !$rootScope.UserAuth) {
                    $location.path('/');
                }
                else {
                    $http.defaults.headers.common['Authorization'] = $rootScope.UserAuth.TokenValid; // jshint ignore:line
                }
            });
        }]);

})();