myModule.service('UserRegisterService', ['$http', '$rootScope', function ($http, $rootScope) {
    //Service function for POST new user.
    this.registerUser = function (userobject) {
        debugger;
        var registerData = {
            username: userobject.Email,
            email: userobject.Email,
            userpassword: userobject.Password,
            ConfirmPassword: userobject.ConfirmPassword
        };

        var URL = BaseUrl+"account/Register";
        return $http.post(URL, registerData);
    };
}]);