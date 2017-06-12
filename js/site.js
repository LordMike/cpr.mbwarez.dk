// Utilities
Number.prototype.pad = function (size) {
    var s = String(this);
    while (s.length < (size || 2)) { s = "0" + s; }
    return s;
}

var cprApp = angular.module('cprApp', []);

// Directives

// CPR JS
cprApp.controller('CprController', ['$scope', function CprController($scope) {
    var cpr = this;
    var controlDigits = [4, 3, 2, 7, 6, 5, 4, 3, 2, 1];

    $scope.cprDate = new Date();
    $scope.cprGender = 'either';

    cpr.getGender = function (number) {
        // Number in form '0123456789' (no "-") (string)
        if (parseInt(number[9]) % 2 == 0)
            return 'female';

        return 'male';
    }

    cpr.checkCpr = function (number, gender) {
        // Number in form '0123456789' (no "-")
        var sum = 0;

        for (var i = 0; i < 10; i++) {
            sum += parseInt(number[i]) * controlDigits[i];
        }

        if (sum % 11 != 0) {
            return false;
        }

        return gender == 'either' || gender == cpr.getGender(number);
    }

    cpr.candidates = function (date, gender) {

        // Determine range to generate
        // Even centuries: 5000-9999
        // Odd  centuries: 0000-4999
        var lower = 0;
        var upper = 4999;

        if (parseInt(date.getFullYear() / 100) % 2 == 0) {
            lower = 5000;
            upper = 9999;
        }

        var res = [];

        // Format prefix: DDMMYY
        var datePrefix = date.getDate().pad(2) + (date.getMonth() + 1).pad(2) + new String(date.getFullYear()).substr(2);

        for (var i = lower; i < upper; i++) {
            var number = datePrefix + i.pad(4);

            if (!cpr.checkCpr(number, gender))
                continue;

            var numberGender = cpr.getGender(number);
            var actualNumber = datePrefix + '-' + i.pad(4);

            // Valid CPR
            res.push({
                number: actualNumber,
                gender: numberGender
            });
        }

        return res;
    };
}]);