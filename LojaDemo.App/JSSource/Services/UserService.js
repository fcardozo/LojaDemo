(function () {
    'use strict';

    var LojaDemoApp = angular.module('LojaDemoApp');

    // I act a repository for the remote friend collection.
    LojaDemoApp.service("UserService", function ($http, $q) {
        // Return public API.
        return ({
            Login: login
        });

        // ---
        // PUBLIC METHODS.
        // ---
        function login(loginData) {
            var request = $http({
                method: "post",
                url: "http://localhost:2001/api/User/Login",
                data: loginData
            });
            return (request.then(handleSuccess, handleError));
        }

        // ---
        // PRIVATE METHODS.
        // ---
        // I transform the error response, unwrapping the application dta from
        // the API response payload.
        function handleError(response) {
            // The API response from the server should be returned in a
            // nomralized format. However, if the request was not handled by the
            // server (or what not handles properly - ex. server error), then we
            // may have to normalize it on our end, as best we can.
            if (
                !angular.isObject(response.data) ||
                !response.data.message
                ) {
                return ($q.reject("An unknown error occurred."));
            }
            // Otherwise, use expected error message.
            return ($q.reject(response.data.message));
        }
        // I transform the successful response, unwrapping the application data
        // from the API response payload.
        function handleSuccess(response) {
            return (response.data);
        }

    });
})();