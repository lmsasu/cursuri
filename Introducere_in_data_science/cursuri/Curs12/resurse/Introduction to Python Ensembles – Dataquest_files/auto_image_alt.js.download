jQuery(document).ready(function(){
  jQuery("img").each(function() { 
      var img_src = jQuery(this).attr('src');
      if (typeof img_src !== typeof undefined && img_src !== false) {
      var img_alt = jQuery(this).attr('alt');
      var str = img_src
      var pieces = str.split('/');
      var imgName = pieces[pieces.length-1];
      var imgnameArray = imgName.split('.');
      var alt = imgnameArray[0];
	  if(img_alt == '' || typeof img_alt === typeof undefined || img_alt === false) {
        jQuery(this).attr('alt',alt);
	  }
      }
  }); 
});