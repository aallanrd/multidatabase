var multiDBApp = angular.module('multiDBApp', []);

multiDBApp.controller('multiController', function ($scope,$http) {

    

    $scope.todas = [
    { name: 'Col1', type: 'varchar', length: 11 },
    { name: 'Col2', type: 'varchar', length: 11 }];
    
    $scope.addColumn = function () {
        $scope.todas.push({ name: $scope.name, type: $scope.type, length: $scope.length });
  
    };


    $scope.createTable = function () {

        
        $scope.retData = {};
    
        var json = JSON.stringify($scope.todas);
        $http.post('../App/HttpCreateTable?cID='+ $scope.cID +'&name='+ $scope.name +'&columns='+ json, { data: {  } })
        .success(function (data, status, headers, config) {
            $scope.retData.result = data.d;
            alert(data);  
        })
        .error(function (data, status, headers, config) {
            $scope.status = status;
            
        });
       
    }
    
        
}).config(function ($httpProvider) {
    $httpProvider.defaults.headers.post = {};
    $httpProvider.defaults.headers.post["Content-Type"] = "application/json; charset=utf-8";
});

