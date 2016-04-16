var multiDBApp = angular.module('multiDBApp', []);

multiDBApp.controller('multiController', function ($scope) {

    $scope.list = [
      {
          'name': 'Nexus S',
          'port': 1
      },
      {
          'name': 'Motorola XOOM™ with Wi-Fi',
          'port': 2
      },
      {
          'name': 'MOTOROLA XOOM™',
          'port': 3
      }
    ];
});