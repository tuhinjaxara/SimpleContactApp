
var app = angular.module('SimpleContactApp');

app.directive("asContact", function () {
    return {
        restrict: 'E',
        replace: 'true',
        templateUrl: 'app/contact/userListRow.html'
    }
});