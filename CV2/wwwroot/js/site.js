window.addEventListener("scroll", function () {
    var header = document.querySelector("header");
    header.classList.toggle("sticky", window.scrollY > 0);
});

$(document).ready(function () {
    $('#front').hide();
    $('#database').hide();   
});

$(document).ready(function () {
    $('#card-net').on('click', function () {
        $('#net').toggle();
        $('#front').hide();
        $('#database').hide();
    });
});

$(document).ready(function () {
    $('#card-front').on('click', function () {
        $('#front').toggle();
        $('#net').hide();
        $('#database').hide();
    });
});

$(document).ready(function () {
    $('#card-db').on('click', function () {
        $('#database').toggle();
        $('#front').hide();
        $('#net').hide();
    });
});

function initMap() {
    var location = { lat: 49.9683477, lng: 24.5909639 };
    var map = new google.maps.Map(document.getElementById('map'), {
        zoom: 8,
        center: location
    });

    var marker = new google.maps.Marker({
        position: location,
        map: map
    });
}
