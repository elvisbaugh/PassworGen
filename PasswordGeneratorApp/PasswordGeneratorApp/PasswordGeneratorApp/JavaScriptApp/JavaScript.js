
    var dt = '@ViewBag.EndDate';
var dateAr = dt.split('-');
var newDate = dateAr[1] + '/' + dateAr[0] + '/' + dateAr[2];

var end = new Date(dateAr[1] + '/' + dateAr[0] + '/' + dateAr[2]);

var _second = 1000;
var _minute = _second * 60;
var _hour = _minute * 60;
var _day = _hour * 24;
var timer;

function showRemaining() {
    var now = new Date();
    var distance = end - now;
    if (distance < 0) {
        clearInterval(timer);
        document.getElementById('countdown').innerHTML = 'EXPIRED!';
        window.location.href = '/Password/Index';

        return;
    }
    var days = Math.floor(distance / _day);
    var hours = Math.floor((distance % _day) / _hour);
    var minutes = Math.floor((distance % _hour) / _minute);
    var seconds = Math.floor((distance % _minute) / _second);


    document.getElementById('countdown').innerHTML = hours + 'hrs ';
    document.getElementById('countdown').innerHTML += minutes + 'mins ';
    document.getElementById('countdown').innerHTML += seconds + 'secs';
}

timer = setInterval(showRemaining, 1000);
