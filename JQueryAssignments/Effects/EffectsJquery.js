$(".one button").click(function(){
    $(".two").fadeOut(3000, function(){
        $(".three").addClass("colorChange");
    });
});

$(".two button").click(function(){
    $("p").toggle();
});

$(".three button").click(function(){
    $("p").toggle();
});

