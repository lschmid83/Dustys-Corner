$(document).ready(function() {

	resizeIncludeFooter();
	
	// Hide cookies notice button.
	$(".cookies-btn .btn").click(function() {
		hideCookiesNotice();
		Cookies.set('accept-cookies', true, { expires: 30 });

	});
	
	if (!Cookies.get('accept-cookies')) {
	
		var cookieNoticeAnimated = true;
		
		// Hide cookie notice if scrolled.
		var scrollPos = $(document).scrollTop();
		if(scrollPos > 0) {
			$("#cookies-notice").css("display", "none");
		}
		else {
			$("#cookies-notice").css("display", "inline");
			cookieNoticeAnimated = false;
		}
    }
	
	// Window scroll event.
	$(window).scroll(function(){
		
		var scrollPos = $(document).scrollTop();
		
		if (!Cookies.get('accept-cookies')) {
				
			// Hide cookies notice on scroll.
			if(scrollPos == 0) {
				$("#cookies-notice").css("opacity", "1");
				$("#cookies-notice").show();
				cookieNoticeAnimated = false;
			}
			else {
				if(!cookieNoticeAnimated) {				
					hideCookiesNotice();
					cookieNoticeAnimated = true;
				}
			}
			
			// Hide back to top button.
			if ($(this).scrollTop() > 50) {
				$('#back-to-top').fadeIn();
			} else {
				$('#back-to-top').fadeOut();
			}
		
		}
	});
	
	// Window resize event.
	$(window).resize(function() {
		resizeIncludeFooter();
	});
		
	// Scroll body to 0px on click.
	$('#back-to-top').click(function () {
		$('#back-to-top').tooltip('hide');
		$('body,html').animate({
			scrollTop: 0
		}, 300);
		return false;
	});

	// Set content margin to footer height.
	function resizeIncludeFooter() {
		$('#content').css('margin-bottom', parseInt($('#footer').css('height')) + 40);
	}
	
	// Hides the cookies notice with animated transition.
	function hideCookiesNotice() {
		$('#cookies-notice').css("transition", "none");
		
		$('#cookies-notice').animate({
				opacity: 0.3,
				height: "toggle"
		}, 250, function() {
			$('#cookies-notice').hide();
		});
    }
});

