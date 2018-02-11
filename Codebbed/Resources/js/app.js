$(function () {
    $("#head-title").typed({
        strings: ["We are developers^1000", "We can get things done!^1000", "24/7 available for hire^1000"],
        typeSpeed: 100,
        loop: true,
        startDelay: 100
    });
});

$("#btnSendMail").click(function () {
    debugger;
    $.ajax({
        url: "Home/SendMail", success: function (result) {
            debugger;
            if (result && result.isSuccess) {
                //$("#popup").show();
                $('#popup').modal('show');
                $("#message").text(result.message);
            }

            //$("#div1").html(result);
        }, error: function (result) {
            alert("Error");
        }
    });
});
$(document).ready(function () {
    var owl = $('.owl-carousel');
    owl.owlCarousel({
        items: 4,
        loop: true,
        margin: 10,
        autoPlay: true,
        
    });
    //autoplayTimeout: 1000,
    //    autoplayHoverPause: true
    //$('.play').on('click', function () {
    //    owl.trigger('play.owl.autoplay', [1000])
    //})
    //$('.stop').on('click', function () {
    //    owl.trigger('stop.owl.autoplay')
    //})
})