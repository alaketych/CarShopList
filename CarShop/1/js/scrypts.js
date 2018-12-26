function SetIMG(selected_url)
{
   var item = document.getElementById("Preview");
    item.src=selected_url;
}

$(document).ready(function(){
   $('#header').fadeTo(2000,0.3,function(){ 
       $('html, body').animate({ scrollTop: $('#content').offset().top }, 2000);
   });
});


$(document).on('submit','form',function(){
    
    var UserName=$('input[name=Name]').val();
    var UserTel=$('input[name=Tel]').val();
    var Car=$('select').val();

    if(UserName.length>0)
    {
    var regular=/^\+380-[0-9]{3}-[0-9]{2}-[0-9]{4}/;
    if(regular.test(UserTel)==true)
    {
        alert('We will contact you soon!');
     SubmitForm(UserName,UserTel,Car);
    }
    else
    {
        alert("Invalid number.");
    }
    }
    else{
        alert("You forgot to specify the name.");
    }
});


function SubmitForm(name,tel,car)
{
   $.ajax({
  method: "POST",
  url: "/Home/Index",
  data: { Name: name, Tel: tel, Car:car }
})
  .done(function( msg ) {
    alert( "Greate: " + msg );
  }).fail(function() {
      alert( "An error occurred during data transfer." );
  }); 
}

