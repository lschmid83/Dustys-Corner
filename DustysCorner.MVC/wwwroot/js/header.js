$(document).ready(function() {
	
	// Get page folder path.
	var path = location.pathname.split('/')[1]
	path = capitalizeFirstLetter(path);
	
	// Set active menu item.
	if(path == '') {
		setActiveMenuItem('Home');
	}
	else {
		setActiveMenuItem(path);		
	}

	$(window).resize(function() {
		
		// Toggle responsive menu hide.
		if ($(window).width() > 768) {
			hideSideNav();
		}
	});

	if ($(window).width() > 768) {
		$('#basket').hover(function() {
		   if(!$('#cart-summary-container').is(":visible")) {
				$('#cart-summary-container').fadeIn('fast');
		   }  
		}, function() {
		   $('#cart-summary-container').fadeOut('fast');
		});
	}
	
	$('#basket-link').mouseenter(function() {
		$('#basket-text').css("text-decoration", "underline");
		$('#basket-link').css("cursor", "pointer");
	});
	
	$('#basket-link').mouseleave(function() {
		$('#basket-text').css("text-decoration", "none");
		$('#basket-link').css("cursor", "none");
	});	
	
	$('#basket-link').click(function() {
		if(!$('#cart-summary-container').is(":visible")) {
			$('#cart-summary-container').fadeIn('fast');
		}
		else {
			$('#cart-summary-container').fadeOut('fast');	
		}
	});		
	
	$('a:contains("Blog")').attr("target","_blank");

	function capitalizeFirstLetter(string) {
		return string.charAt(0).toUpperCase() + string.slice(1);
	}
	
	function setActiveMenuItem(name) {		
		$('#navbar').find('a:contains("' + name + '")').addClass('active');
	}			

	function hideSideNav() {
		
		if($('.navmenu-fixed-right').is(":visible")) {			
			$('.navmenu-fixed-right').offcanvas('hide');
			$('.navmenu-fixed-right').hide();
		}
    }

    $('.play-video').on('click', function (ev) {

        this.nextElementSibling.style.display = 'block';
        this.style.display = 'none';

        var src = $(this).parent().find('iframe').attr('src') + '?autoplay=1';
        $(this).parent().find('iframe').attr('src', src);
        ev.preventDefault();

    });
});