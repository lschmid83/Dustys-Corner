$(document).ready(function () {
    $.getScript('/js/product.js', function (data, textStatus, jqxhr) { });
    $('#content').show();
    $('#dusty-navbar .navbar-right').show();
});

var app = angular.module('app', ['ngCart', 'angularUtils.directives.dirPagination']);

app.controller ('CheckoutCtrl', ['$scope', '$http', 'ngCart', function ($scope, $http, ngCart) {

	if(!Cookies.get('shippingCountry') || Cookies.get('shippingCountry') === 'United Kingdom') {
		$scope.shippingCountry = 'United Kingdom';
		ngCart.setShipping(2.50);
	}
	else {
		$scope.shippingCountry = Cookies.get('shippingCountry');
		ngCart.setShipping(5);
	}
			
    $scope.changedValue = function (item) {
        if (item === 'United Kingdom') {
            ngCart.setShipping(2.50);
        }
        else {
            ngCart.setShipping(5);
        }
        Cookies.set('shippingCountry', item, { expires: 30 });
    };
}]);

app.controller('CategoryCtrl', ['$scope', '$http', '$sce', function($scope, $http, $sce) { 
	
    $scope.init = function (categoriesJson) {
        $scope.mainmenu = $sce.trustAsHtml(buildMainMenuListItems(categoriesJson, false));
        $scope.sidemenu = $sce.trustAsHtml(buildSideMenuListItems(categoriesJson, false));
        $scope.footermenu = $sce.trustAsHtml(buildFooterListItems(categoriesJson));
    };
}]);

function buildMainMenuListItems(categories, dropdown) {

	var html = '';	
    for (var i = 0; i < categories.length; i++) {		
        if(categories[i].Children.length > 0) {
			html += '<li class="dropdown">';
			if(dropdown)		
                html += '	<a class="dropdown-toggle drop-menu" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">' + categories[i].Name + '<span class="caret dropdown-caret"></span></a>';	
            else
                html += '	<a class="dropdown-toggle main-menu" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">' + categories[i].Name + '<span class="caret main-dropdown"></span></a>';
			html += '	<ul class="dropdown-menu">';
			html += buildMainMenuListItems(categories[i].Children, true);
			html += '	</ul>';
			html += '</li>';
		}
        else {
            if (dropdown)
                html += '<li><a href="/' + categories[i].Route.toLowerCase() + '/' + categories[i].Name.toLowerCase() + '?id=' + categories[i].Id + '">' + categories[i].Name + '</a></li>';
            else
                html += '<li><a class="main-menu" href="/' + categories[i].Route.toLowerCase() + '">' + categories[i].Name + '</a></li>';	
        }
	}	
	return html;
}

function buildSideMenuListItems(categories, dropdown) {

	var html = '<li class="nav-item"><a class="nav-link" href="/">Home</a></li>' +
		'<li class="nav-item"><a class="nav-link" href="">Gallery</a></li>' +
		'<li class="nav-item"><a class="nav-link" href="/gallery/sculptures?id=3">&nbsp;&nbsp;&nbsp;&nbsp;Sculptures</a></li>' +
		'<li class="nav-item"><a class="nav-link" href="/gallery/models?id=4">&nbsp;&nbsp;&nbsp;&nbsp;Models</a></li>' +
		'<li class="nav-item"><a class="nav-link" href="/gallery/architectural?id=5">&nbsp;&nbsp;&nbsp;&nbsp;Architectural</a></li>' +
		'<li class="nav-item"><a class="nav-link" href="/gallery/sketches?id=6">&nbsp;&nbsp;&nbsp;&nbsp;Sketches</a></li>' +
		'<li class="nav-item"><a class="nav-link" href="">Shop</a></li>' +
		'<li class="nav-item"><a class="nav-link" href="/shop/sculptures?id=8">&nbsp;&nbsp;&nbsp;&nbsp;Sculptures</a></li>' +
		'<li class="nav-item"><a class="nav-link" href="/shop/bases?id=9">&nbsp;&nbsp;&nbsp;&nbsp;Bases</a></li>' +
		'<li class="nav-item"><a class="nav-link" href="/shop/jewellery?id=10">&nbsp;&nbsp;&nbsp;&nbsp;Jewellery</a></li>' +
		'<li class="nav-item"><a class="nav-link" href="/contact">Contact</a></li>';
	return html;
}

function buildFooterListItems(categories) {

    var html = '';
    for (var i = 0; i < categories.length; i++) {
        if (categories[i].Children.length > 0)
            html += '<li><a href="/' + categories[i].Route + '/' + categories[i].Children[0].Name + '?id=' + categories[i].Children[0].Id + '">' + categories[i].Name + '</a ></li>';
        else
            html += '<li><a href="/' + categories[i].Route + '">' + categories[i].Name + '</a ></li>';
    }
    return html;
}

app.controller('ProductCtrl', ['$scope', '$rootScope', '$http', '$sce', function($scope, $rootScope, $http, $sce) { 

    $scope.currentPage = 1;
    $scope.pageSize = 10;
	$scope.longItemName = false;
	
	$scope.init = function(productsJson)
	{	
        $(productsJson).each(function (index, item) {			

			var salePrice = item.Price - item.Price * (item.Discount / 100);
		
			if(item.Discount > 0) {
				item.BeforeSalePrice = item.Price.toFixed(2);
				item.Price = salePrice.toFixed(2);
			}
			else {
					
				item.Price = item.Price.toFixed(2);
			}
		
			item.Description = $sce.trustAsHtml(item.Description);
				
			var json = '{"picture":"' + '/images/products/' + item.Thumbnail + '"}',
				obj = JSON.parse(json);	
			item.Data = obj;	
				
			if(item.Options.length > 0) {
				item.productoption = {};
				item.productoption = item.Options[0];
			}
				
			if(item.Name.length > 30) {
				$scope.longItemNames = true;
			}	

			item.Id = item.Name.replace(/\s+/g, '-').toLowerCase();
        });	

		$scope.products = productsJson; 
	
		$rootScope.$on('ngCart:itemAdded', function (event, data) {
							
			$('#cart-summary-container').fadeIn('fast');
			
            if (window.cartSummaryTimer) {
                clearTimeout(window.cartSummaryTimer);				
			}
			
            window.cartSummaryTimer = setTimeout(function() { $('#cart-summary-container').fadeOut('fast'); }, 2000);

			var $container = $('#cart-summary'), $scrollTo = $('#' + data.getSummaryId());

			if($scrollTo.length > 0) {
				$container.animate({
					scrollTop: $scrollTo.offset().top - $container.offset().top + $container.scrollTop()
				});	
			}
		
		});	
	};	
}]);

app.controller('GalleryCtrl', ['$scope', '$http', '$sce', function($scope, $http, $sce) { 

	$scope.currentPage = 1;
	$scope.pageSize = 10;
	
	$(window).resize(function(){

		$scope.$apply(function(){		
			$scope.setColumnCount();
		});
	});

    $scope.setColumnCount = function () {
        if (window.innerWidth >= 768) {
            $scope.columns = 3;
        }
        else if (window.innerWidth >= 475) {
            $scope.columns = 2;
        }
        else {
            $scope.columns = 1;
        }
    };

    $scope.init = function (galleryJson)
    {
        $scope.galleryItems = galleryJson; 
		$scope.setColumnCount();
	};		
}]);

app.controller('EventCtrl', ['$scope', '$http', function($scope, $http) { 

    $scope.init = function (eventsJson) {		
        $scope.event = eventsJson; 
        $scope.event.StartDate = new Date($scope.event.StartDate); 
        $scope.event.EndDate = new Date($scope.event.EndDate); 
		var today = new Date();
		var one_day = 1000*60*60*24;
		var difference_ms =  $scope.event.StartDate.getTime() - today.getTime();
		$scope.event.RemainingDays = Math.round(difference_ms / one_day); 
	};
}]);

app.controller('ReviewCtrl', ['$scope', '$http', function ($scope, $http) {

    $scope.init = function (reviewsJson) {
        $scope.reviews = reviewsJson;
    };
}]);

app.controller('LinkCtrl', ['$scope', '$http', function($scope, $http) { 	
	
    $scope.init = function (linkJson) {
        var queryResult = Enumerable.From(linkJson)
					.GroupBy("$.Category", null,
                                function (key, g) {
                                 return {
                                     Category: key,
                                     Value: g
                                 };
					})
					.ToArray();	
		$scope.links = queryResult; 
	};
}]);
