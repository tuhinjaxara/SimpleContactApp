
var app = angular.module('SimpleContactApp', [
    'ui.router',
    'ui.bootstrap',
    'ngAnimate'
]);

app.config(['$urlRouterProvider', '$stateProvider', function ($urlRouterProvider, $stateProvider) {

    // default route
    $urlRouterProvider.otherwise('/');

    $stateProvider
        .state('home', {
            url: '/',
            templateUrl: 'app/home/home.html',
            controller: 'homeCtrl'
        })
        .state('contact', {
            url: '/contact',
            templateUrl: 'app/contact/contact.html',
            controller: 'contactCtrl'
        })
        .state('contact.detail', {
            url: '^/contact/detail/{id:[0-9]{1,5}}',
            templateUrl: 'app/contact/contactdetail.html',
            controller: 'contactCtrl'
        });
}]);

app.directive('loading', ['$http', function ($http) {
    return {
        restrict: 'A',
        link: function (scope, elm, attrs) {
            scope.isLoading = function () {
                return $http.pendingRequests.length > 0;
            };
            scope.$watch(scope.isLoading, function (v) {
                if (v) {
                    elm.show();
                } else {
                    elm.hide();
                }
            });
        }
    };

}]);

app.directive('fileUpload', function () {
    return {
        scope: true,        //create a new scope
        link: function (scope, el, attrs) {
            el.bind('change', function (event) {
                var files = event.target.files;
                //iterate files since 'multiple' may be specified on the element
                for (var i = 0; i < files.length; i++) {
                    //emit event upward
                    scope.$emit("fileSelected", { file: files[i] });
                }
            });
        }
    };
});

