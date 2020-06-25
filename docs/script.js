$(document).ready(function(){
    $('#conditionZoom').css('display','none');
    $('#truthZoom').css('display','none');

});

function showZoom(image){
    $('#'+image+'Zoom').css('display', 'block');
}

function closeZoom(image){
    $('#'+image+'Zoom').css('display', 'none');
}

function displayText(textId){
    console.log($('#'+textId+' .stepText').css("display"));
    if($('#'+textId+' .stepText').css("display")=="none"){
        $('#'+textId+' .stepText').css("display", "block");
    }else{
        $('#'+textId+' .stepText').css("display", "none");
    }

    
}