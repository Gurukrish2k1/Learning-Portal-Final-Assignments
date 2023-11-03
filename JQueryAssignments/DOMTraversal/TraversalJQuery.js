$(document).ready(function(){
    $(".count").click(function () { 
        var text = $(".mainBox").find("h3");
        $(".title").text("No of H3 tag is: "+text.length);
        $(".date").text("No of Date tag is: "+$(".mainBox").children(".p1").length);
        $(".tags").text("No of Tags is: "+$(".mainBox").children(".t1").length);
    });  

    $(".change").click(function () { 
        $(".mainBox").children(".t1").addClass("colorChange");
    });  
});