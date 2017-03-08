/// <reference path="C:\WORK\CativePortal.UI.Angular\CativePortal.UI.Angular\CativePortal.UI.Angular\Login.html" />
/// <reference path="C:\WORK\CativePortal.UI.Angular\CativePortal.UI.Angular\CativePortal.UI.Angular\Login.html" />
//Controller for Login User

myModule.controller('UserLoginController', ['$scope', 'UserLoginService', '$rootScope', function ($scope, UserLoginService,$rootScope) {
    //Controller Function for Login User
    $scope.loginuserobj = [];
    
    $scope.loginUser = function () {
      
        UserLoginService.LoginUser($scope.loginuserobj).then(function (data) {
            if (!!data || !!data.responseResultTls) {

             
                window.location.href = "Templates/CompanyUI/CompanyA/Views/Index.html";

            }
            else {

                   
            }
        }
        )},
        
    
    function (error) {
            Notification.error('Invalid credentials');
        };
}]);
