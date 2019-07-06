var app = angular.module("myApp", []);
app.controller("myControl", function ($scope) {

    $scope.bookinglist = [
        {
            id: 2,
            object_name: "QUEEN - Rabac",
            date_from: "2019-06-27",
            date_to: "2019-07-04",
            is_active: true,
            amount: "396.03",
            currency: "EUR",
            comment: ""
        },
        {
            id: 3,
            object_name: "MARKO - Rome",
            date_from: "2019-07-11",
            date_to: "2019-07-24",
            is_active: true,
            amount: "1138.54",
            currency: "EUR",
            comment: ""
        },
        {
            id: "4",
            object_name: "MARKO - Amsterdam",
            date_from: "2019-07-11",
            date_to: "2019-07-24",
            is_active: false,
            amount: "1088.68",
            currency: "EUR",
            comment: ""
        }
    ]

    $scope.deleteObject = function (item) {
        $scope.index = $scope.bookinglist.findIndex(i=>i.id === item)
        if ($scope.index !== -1) {
            $scope.bookinglist.splice($scope.index, 1);
        }
    };
    $scope.SerializeObject = function () {
        var json = JSON.stringify($scope.bookinglist);
        console.log(json);
        var tab = window.open('about:blank', '_blank');
        tab.document.write(json);
    };
});