$(document).ready(function(){
    var arrImg=$(".im").get();
    var i;
    var imgs;
    $(".im").on("click",function(){
        i=arrImg.indexOf(this);
        $(".dv2").css({display:"block"})
         imgs=`<img id="tmp" src=${arrImg[i].src}>`
        $(".dv2").append(imgs).animate({
            width:"100%",
            hieght:"100%",
        })
        $(".dv").fadeToggle()
    })
    $(".next").on("click",function(){
        $("#tmp").remove()
        if(i==3){i=-1;}
        i++;
        imgs=`<img id="tmp" src=${arrImg[i].src}>`
        $(".dv2").append(imgs)
     })
     $(".prev").on("click",function(){
        
        $("#tmp").remove()
        if(i==0){i=4;}
        i--;
        imgs=`<img id="tmp" src=${arrImg[i].src}>`
        $(".dv2").append(imgs)
     })
     $(".exit").on("click",function(){
         $(".dv2").fadeToggle()
        $(".dv").fadeToggle() 
        $("#tmp").remove()    
      })
})