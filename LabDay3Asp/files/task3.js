$(document).ready(function(){
    var el=$("<img src='1.jpg'>");
    el.css({ width:"640px",
            height:"400px",
            border:"1px solid black",
            position:"absolute"
           })
   
     var el1=$("<img src='2.jpg'>");
    el1.css({ width:"640px",
            height:"400px",
            border:"1px solid black",
            position:"absolute"
           })
    
    var el2=$("<img src='3.png'>");
    el2.css({ width:"640px",
            height:"400px",
            border:"1px solid black",
            position:"absolute"
           })
    
    var el3=$("<img src='4.jpg'>");
    el3.css({ width:"640px",
            height:"400px",
            border:"1px solid black",
            position:"absolute"
           })
           
    
    $("#i").hover(function(){
       
        $(this).on("mousemove",function(e){
            
            el.css({
            left:e.clientX,
                right:e.clientX,
                top:e.clientY,
                button:e.clientY
            })
            $("body").append(el).clone();
        })
        
        
    },function(){
        $(el).remove()
          
    });
    
    
     $("#i1").hover(function(){
       
        $(this).on("mousemove",function(e){
            
            el1.css({
            left:e.clientX,
                right:e.clientX,
                top:e.clientY,
                button:e.clientY
            })
            $("body").append(el1).clone();
        })
        
        
    },function(){
        $(el1).remove()
          
    });
    
     $("#i2").hover(function(){
       
        $(this).on("mousemove",function(e){
            
            el2.css({
            left:e.clientX,
                right:e.clientX,
                top:e.clientY,
                button:e.clientY
            })
            $("body").append(el2).clone();
        })
        
        
    },function(){
        $(el2).remove()
          
    });
    
     $("#i3").hover(function(){
       
        $(this).on("mousemove",function(e){
            
            el3.css({
            left:e.clientX,
                right:e.clientX,
                top:e.clientY,
                button:e.clientY
            })
            $("body").append(el3).clone();
        })
        
        
    },function(){
        $(el3).remove()
          
    });
     
})