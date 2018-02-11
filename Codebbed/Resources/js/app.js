$(function () {
    $("#head-title").typed({
        strings: ["We are developers^1000", "We can get things done!^1000", "24/7 available for hire^1000"],
        typeSpeed: 100,
        loop: true,
        startDelay: 100
    });
});
$("#btnSendMail").click(function () {
    $.ajax({
        url: "Home/SendMail", success: function (result) {
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
    var owl = $('.testimonial');
    owl.owlCarousel({
        items: 1,
        loop: true,
        margin: 100,
        autoplay: true,
        autoplayTimeout: 3000,
        dots: true,
    });
})
function fnFacebookClick() {
    window.open('http://www.facebook.com/sharer.php?u=https://www.facebook.com/Codebbed-849208365280211/', 'popwin', 'width=640, height=480');
}
function fnLinkedClick() {
    window.open('https://www.linkedin.com/shareArticle?url=https://www.linkedin.com/company/codebbed', 'popwin', 'width=640, height=480');
}