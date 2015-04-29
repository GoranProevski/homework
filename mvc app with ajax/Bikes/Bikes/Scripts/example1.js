$(function () {
    
    $('#myButton').click(function () {
        var x = $('#box1').val();
        var y = $('#box2').val();

        var z = parseInt(x) + parseInt(y);
        alert(z);
    })
})
