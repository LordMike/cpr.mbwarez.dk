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
    var controlDigits = [4, 3, 2, 7, 6, 5, 4, 3, 2, 1];

    this.cprDate = new Date();
    this.cprGender = 'either';

    this.candidateList = [];

    this.getGender = function (cprPart) {
        // cprPart in number form
        if (cprPart % 2 == 0)
            return 'female';

        return 'male';
    }
    
    this.checkCprPart = function (initialSum, partialNumber) {
        // InitialSum is the sum of the first 6 digits
        // PartialNumber is the last 4 digits, in string form
        var sum = 0;

        for (var i = 0; i < 4; i++) {
            sum += parseInt(partialNumber[i]) * controlDigits[6 + i];
        }

        if (sum % 11 != 0) {
            return false;
        }

        return true;
    }

    this.updateCandidates = function () {
        var date = this.cprDate;
        var gender = this.cprGender;

        // Determine range to generate
        // Even centuries: 5000-9999
        // Odd  centuries: 0000-4999
        var lower = 0;
        var upper = 4999;

        if (parseInt(date.getFullYear() / 100) % 2 == 0) {
            lower = 5000;
            upper = 9999;
        }

        // Determine desired gender and increment
        var increment = 2;
        if (gender == 'either') {
            // In case of both genders, all numbers are valid
            increment = 1;
        }
        else if (gender == 'male') {
            // Males are uneven, so we shift the start by 1
            lower += 1;
        }

        var res = [];

        // Format prefix: DDMMYY
        var datePrefix = date.getDate().pad(2) + (date.getMonth() + 1).pad(2) + new String(date.getFullYear()).substr(2);

        // Determine sum of date prefix
        var datePrefixSum = 0;
        for (var i = 0; i < 6; i++) {
            datePrefixSum += parseInt(datePrefix[i]) * controlDigits[i];
        }

        for (var i = lower; i < upper; i += increment) {
            var partNumer = i.pad(4);

            if (!this.checkCprPart(datePrefixSum, partNumer))
                continue;

            var number = datePrefix + partNumer;

            var numberGender = this.getGender(number);
            var actualNumber = datePrefix + '-' + partNumer;

            // Valid CPR
            res.push({
                number: actualNumber,
                gender: numberGender
            });
        }

        this.candidateList = res;
    };

    // Initial update
    this.updateCandidates();
}]);