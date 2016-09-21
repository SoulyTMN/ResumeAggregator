var app = angular.module('app', ['ngMaterial']);

app.config(function ($mdThemingProvider) {
    $mdThemingProvider.theme('default').primaryPalette('blue').accentPalette('red');
});

app.controller('ResumeController', function ($scope, ResumeService) {
    $scope.sortType = 'AddDate';
    $scope.sortReverse = true;

    getResumes();
    function getResumes() {
        ResumeService.getResumes()
        .success(function (trs) {
            $scope.resumes = trs;
        })
        .error(function (error) {
            $scope.status = 'Не удалось загрузить данные по резюме сотрудников: ' + error.message;
        });
    }
});

app.factory('ResumeService', ['$http', function ($http) {
    var ResumeService = {};
    ResumeService.getResumes = function () {
        var response = $http({
            url: "../api/InnerResumes",
            method: "GET"
        });

        return response;
    };

    return ResumeService;
}]);