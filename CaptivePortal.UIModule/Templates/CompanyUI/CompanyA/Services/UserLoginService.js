myModule.service('UserLoginService', ['$http', '$rootScope', function ($http, $rootScope) {
    //Service function for Login user.
    this.LoginUser = function (userobject) {
        
        var loginData = {
            UserName: userobject.UserName,
            UserPassword: userobject.PassWord,
            
        };
        $rootScope.UserName = userobject.username;
        var URL = BaseUrl+"account/login";
        return $http.post(URL, loginData);
    };

}]);