$(document).ready(function () {
    $('#btnGetBikes').click(function () {
        $.getJSON("/Register/GetJsonData", null, function (data) {
            var div = $('#ajaxDiv');
            div.html("<br/> " + "Bikes received from server: " + "<br/>");
            $.each(data, function (i, item) {
                printBike(div, item);
            });
        });
    });
});

function printBike(div, item) {
    div.append("<br/>" + "BikeId: " + item.BikeId + ", RegNumber: " + item.RegNumber + ", Company: " + item.Company + ", Model: " + item.Model + ", Color: " + item.Color);
}