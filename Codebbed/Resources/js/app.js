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