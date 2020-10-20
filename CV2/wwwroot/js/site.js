window.addEventListener("scroll", function () {
    var header = document.querySelector("header");
    header.classList.toggle("sticky", window.scrollY > 0);
});

$(document).ready(function () {
    $('#front').hide();
    $('#database').hide(); 
    //$('#phone').hide();
    $('#map').hide();
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

$(document).ready(function () {
    $('#location').on('click', function () {
        $('#map').toggle();
        //$('#sendEmail').hide();
        $('#sendEmail').hide();
    });
});

//$(document).ready(function () {
//    $('#phone').on('click', function () {
//        //$('#phone').toggle();
//        $('#location').hide();
//        $('#sendEmail').hide();
//    });
//});

$(document).ready(function () {
    $('#mail').on('click', function () {
        $('#sendEmail').toggle();
        $('#map').hide();
        //$('#phone').hide();
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

//function loadDoc() {
    
//    alert('Posted using jQuery');

//}

//    $(function sendEmail() {
//        $('#submit').on('click', function () {
//            alert('Posted using jQuery');
//            //evt.preventDefault();
//            //$.post('', $('form').serialize(), function () {
//            //    alert('Posted using jQuery');
//            //});
//        });
//    });

$(document).ready(function () {
    $('#btn').on('click', function (evt) {
        evt.preventDefault();
        $.post('', $('contatct-form').serialize(), function () {
            });
    });
});

