//Controller for Create new user
myModule.controller('UserRegisterController', ['$scope', 'UserRegisterService', 'UserLoginService', '$rootScope', function ($scope, UserRegisterService, UserLoginService,$rootScope) {
    //Controller Function for create new User
    $scope.registeruserobj = [];
    $scope.createUser = function () {

        UserRegisterService.registerUser($scope.registeruserobj).then(function (data) {

   
            alert("inside method");
            UserLoginService.LoginUser($scope.registeruserobj).then(function (data) {


                window.location.href = "/Index.html";
            });
            }
           )

    }, function (error) {

    };
}]);

