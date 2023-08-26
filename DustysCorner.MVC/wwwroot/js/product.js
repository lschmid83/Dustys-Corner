$(document).ready(function() {

	// Show gallery.
	$('.product-image span').on('click', function(e)  {
		$(this).next().trigger('click');
    });

	// Hover maginify glass.
	$('.roll').css('opacity', '0');
	 
	// On mouse over.
	$('.roll').hover(function () {
	 
	// Set opacity to 70%.
	$(this).stop().animate({
		opacity: .7
		}, "fast");
	},
	// On mouse out.
	function () {	 
		// Set opacity bact to 50%.
		$(this).stop().animate({
			opacity: 0
		}, "slow");
	});
	
	// Close body.
	$('body').click(function(e){
		$('.popup').fadeOut().removeClass("active");
	});
	
	// Open popup.
	$('[data-popup-open]').on('click', function(e)  {      
		if(e.target.nodeName == 'DIV') {
			var targeted_popup_class = jQuery(this).attr('data-popup-open');
			$('[data-popup="' + targeted_popup_class + '"]').fadeIn(350);
			e.stopPropagation();
			e.preventDefault();
		}
	});
  
	// Close popup.
	$('[data-popup-close]').on('click', function(e)  {
		var targeted_popup_class = jQuery(this).attr('data-popup-close');
		$('[data-popup="' + targeted_popup_class + '"]').fadeOut(350);
		e.stopPropagation();
		e.preventDefault();
	});
	
	$('#product-option option:first-child').attr("selected", "selected");
});
