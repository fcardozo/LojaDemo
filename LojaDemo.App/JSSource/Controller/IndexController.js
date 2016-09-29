(function () {
    'use strict';

    // create the module and name it LojaDemoApp
    var LojaDemoApp = angular.module('LojaDemoApp');

    LojaDemoApp.controller('IndexController', function ($scope, $interval, $location, $rootScope, $cookies, $window, UserService) {

        $window.document.activeElement.blur();

        $scope.$on('handleBroadcast', function () {
            $scope.UserAuth = $rootScope.UserAuth;
            $scope.IsAuth = true;
        });

        /// Get cookies
        $scope.UserAuth = $rootScope.UserAuth;
        $scope.CartItens = $rootScope.CartItens;

        if ($scope.CartItens == undefined)
            $scope.CartItens = [];

        $scope.CartCount = $scope.CartItens.length;

        $scope.IsAuth = $scope.UserAuth != undefined;

        $scope.PaginaCarregando = false;

        $scope.ErroLogin = {
            MostraTextoErro: false,
            MenssagemErro: ''
        }


        $scope.LoginRequest = {
            Login: "",
            Password: ""
        };

        /// Set focus in inputLogin
        $('#modalLogin').on('shown.bs.modal', function () {
            $('#inputLogin').focus();
        })

        /// Method execute login on app
        $scope.ExecuteLogin = function () {

            $scope.ErroLogin.MostraTextoErro = false;
            $scope.PaginaCarregando = true;

            UserService.Login($scope.LoginRequest).then(
                 function (loginResponse) {
                     $scope.PaginaCarregando = false;
                     $scope.LoginRequest.Login = '';
                     $scope.LoginRequest.Password = '';

                     if (!loginResponse.IsAuthenticated) {
                         $scope.ErroLogin.MostraTextoErro = true;
                         $scope.ErroLogin.MenssagemErro = loginResponse.MessageError;
                         return;
                     }

                     $scope.SetCredential(loginResponse);
                     $('#modalLogin').modal('hide');
                 },
                   function (errorMessage) {
                       $scope.PaginaCarregando = false;

                       $scope.LoginRequest.Login = '';
                       $scope.LoginRequest.Password = '';
                       $scope.ErroLogin.MostraTextoErro = true;
                       $scope.ErroLogin.MenssagemErro = 'Não foi possível autenticar o usuário! Usuário ou senha inválidos.'
                   }
                );

        };

        /// Method to set credential
        $scope.SetCredential = function (loginResponse) {

            $rootScope.UserAuth = loginResponse.UserAuth;

            var outhCookie = {
                IsAuthenticated: loginResponse.IsAuthenticated,
                TokenValid: loginResponse.UserAuth.TokenValid,
                Name: loginResponse.UserAuth.Name
            };

            $cookies.putObject('loginCredential', outhCookie);
            var obj = $cookies.getObject('loginCredential')
            $rootScope.$broadcast('handleBroadcast');
        }

        /// Method to execute Logout
        $scope.Logout = function () {
            $rootScope.UserAuth = undefined;
            $cookies.remove('loginCredential');
            $scope.UserAuth = undefined;
            $scope.IsAuth = false;
        };

        $scope.OpenCart = function () {
            $location.path('/Cart');
            window.location = '#/Cart';
        }
    });

})();