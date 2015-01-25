/*price range*/

 $('#sl2').slider();

	var RGBChange = function() {
	  $('#RGB').css('background', 'rgb('+r.getValue()+','+g.getValue()+','+b.getValue()+')')
	};	
		
/*scroll to top*/

$(document).ready(function(){
	$(function () {
		$.scrollUp({
	        scrollName: 'scrollUp', // Element ID
	        scrollDistance: 300, // Distance from top/bottom before showing element (px)
	        scrollFrom: 'top', // 'top' or 'bottom'
	        scrollSpeed: 300, // Speed back to top (ms)
	        easingType: 'linear', // Scroll to top easing (see http://easings.net/)
	        animation: 'fade', // Fade, slide, none
	        animationSpeed: 200, // Animation in speed (ms)
	        scrollTrigger: false, // Set a custom triggering element. Can be an HTML string or jQuery object
					//scrollTarget: false, // Set a custom target element for scrolling to the top
	        scrollText: '<i class="fa fa-angle-up"></i>', // Text for element, can contain HTML
	        scrollTitle: false, // Set a custom <a> title if required.
	        scrollImg: false, // Set true to use image
	        activeOverlay: false, // Set CSS color to display scrollUp active point, e.g '#00FFFF'
	        zIndex: 2147483647 // Z-Index for the overlay
		});
	});

    /*滚动时搜索框自动出现*/
	$(window).scroll((function () {
	    var bn = $("#headerMiddle"),
        bl = $(window);
	    var bm = 40;
	    var bq;
	    var bp = bn.offset().top;
	    var bo = function () {
	        if (bq) {
	            clearTimeout(bq);
	            bq = false;
	        }
	        bq = setTimeout(function() {
	                var br = bl.scrollTop();
	                if (br > bm + bp) {
	                    bq = setTimeout(function() {
	                            bn.addClass("HomeSearchBoxShow");
	                        },
	                        0);
	                } else {
	                    if (br <= bm + bp) {
	                        bq = setTimeout(function() {
	                                bn.removeClass("HomeSearchBoxShow");
	                            },
	                            0);
	                    }
	                }
	            },
	            50);
	    };
	    bo();
	    return bo;
	})());
}); 


