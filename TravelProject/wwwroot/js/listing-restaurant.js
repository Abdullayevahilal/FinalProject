(function(A) {
    if (!Array.prototype.forEach)
        A.forEach = A.forEach || function(action, that) {
            for (var i = 0, l = this.length; i < l; i++)
                if (i in this)
                    action.call(that, this[i], i, this);
        };

})(Array.prototype);

var
    mapObject,
    marker = [],
    markersArray = {
        'Restaurant': [{
                name: 'italian restro',
                location_latitude: 25.206426,
                location_longitude: 55.346465,
                map_image_url: '../assets/images/restaurant/environment/1.jpg',
                name_point: 'italian restro',
                price: '$1200',
                data_title: 'first',
                rating: 'four-star',
                url_point: 'restaurant-single-1.html'
            },
            {
                name: 'pizza mania',
                location_latitude: 25.222578,
                location_longitude: 55.319011,
                map_image_url: '../assets/images/restaurant/environment/2.jpg',
                name_point: 'pizza mania',
                price: '$1200',
                data_title: 'second',
                rating: 'three-star',
                url_point: 'restaurant-single-1.html'
            },
            {
                name: 'The Cafe',
                location_latitude: 25.209843,
                location_longitude: 55.293616,
                map_image_url: '../assets/images/restaurant/environment/3.jpg',
                name_point: 'The Cafe',
                price: '$1200',
                data_title: 'third',
                rating: 'five-star',
                url_point: 'restaurant-single-1.html'
            },
            {
                name: 'Go Maxican',
                location_latitude: 25.229721,
                location_longitude: 55.328229,
                map_image_url: '../assets/images/restaurant/environment/4.jpg',
                name_point: 'Go Maxican',
                price: '$1200',
                data_title: 'four',
                rating: 'two-star',
                url_point: 'restaurant-single-1.html'
            }
        ]
    };

var mapOptions = {
    zoom: 13,
    center: new google.maps.LatLng(25.229721, 55.338229),
    mapTypeId: google.maps.MapTypeId.ROADMAP,
    styles: [{
            "featureType": "administrative.land_parcel",
            "elementType": "labels",
            "stylers": [{
                "visibility": "off"
            }]
        },
        {
            "featureType": "poi",
            "elementType": "labels.text",
            "stylers": [{
                "visibility": "off"
            }]
        },
        {
            "featureType": "poi.business",
            "stylers": [{
                "visibility": "off"
            }]
        },
        {
            "featureType": "road",
            "elementType": "labels.icon",
            "stylers": [{
                "visibility": "off"
            }]
        },
        {
            "featureType": "road.arterial",
            "elementType": "labels",
            "stylers": [{
                "visibility": "off"
            }]
        },
        {
            "featureType": "road.highway",
            "elementType": "labels",
            "stylers": [{
                "visibility": "off"
            }]
        },
        {
            "featureType": "road.local",
            "stylers": [{
                "visibility": "off"
            }]
        },
        {
            "featureType": "road.local",
            "elementType": "labels",
            "stylers": [{
                "visibility": "off"
            }]
        },
        {
            "featureType": "transit",
            "stylers": [{
                "visibility": "off"
            }]
        }
    ]
};
var
    marker;
mapObject = new google.maps.Map(document.getElementById('map'), mapOptions);
for (var key in markersArray)
    markersArray[key].forEach(function(date) {
        marker = new google.maps.Marker({
            position: new google.maps.LatLng(date.location_latitude, date.location_longitude),
            map: mapObject,
            icon: '../assets/images/icon/food-marker.png',
            title: date.data_title
        });

        if ('undefined' === typeof marker[key])
            marker[key] = [];
        marker[key].push(marker);
        google.maps.event.addListener(marker, 'click', (function() {
            hideInfoBox();
            showInfoBox(date).open(mapObject, this);
            mapObject.setCenter(new google.maps.LatLng(date.location_latitude, date.location_longitude));
        }));


        $('.product-wrapper-grid .special-box').mouseenter(function() {
            var className = $(this).attr('data-class');
            $(".gm-style div[title|=" + className + "]").each(function(index) {
                var markerTitle = $(this).attr('title');
                if (markerTitle === className) {
                    $(this).children().addClass('add-animation');
                }
            });
        });

        $('.product-wrapper-grid .special-box').mouseleave(function() {
            var className = $(this).attr('data-class');
            $(".gm-style div[title|=" + className + "]").each(function(index) {
                var markerTitle = $(this).attr('title');
                if (markerTitle === className) {
                    $(this).children().removeClass('add-animation');
                }
            });
        });

        // map modal
        $('.sidebar-hotels .hotel-box').mouseenter(function() {
            var className = $(this).attr('data-class');
            $(".gm-style div[title|=" + className + "]").each(function(index) {
                var markerTitle = $(this).attr('title');
                if (markerTitle === className) {
                    $(this).children().addClass('add-animation');
                }
            });
        });

        $('.sidebar-hotels .hotel-box').mouseleave(function() {
            var className = $(this).attr('data-class');
            $(".gm-style div[title|=" + className + "]").each(function(index) {
                var markerTitle = $(this).attr('title');
                if (markerTitle === className) {
                    $(this).children().removeClass('add-animation');
                }
            });
        });

        // listing hotels
        $('.list-view .list-box').mouseenter(function() {
            var className = $(this).attr('data-class');
            $(".gm-style div[title|=" + className + "]").each(function(index) {
                var markerTitle = $(this).attr('title');
                if (markerTitle === className) {
                    $(this).children().addClass('add-animation');
                }
            });
        });

        $('.list-view .list-box').mouseleave(function() {
            var className = $(this).attr('data-class');
            $(".gm-style div[title|=" + className + "]").each(function(index) {
                var markerTitle = $(this).attr('title');
                if (markerTitle === className) {
                    $(this).children().removeClass('add-animation');
                }
            });
        });


    });




function hideAllMarkers() {
    for (var key in marker)
        marker[key].forEach(function(marker) {
            marker.setMap(null);
        });
};

function toggleMarkers(category) {
    hideAllMarkers();
    hideInfoBox();

    if ('undefined' === typeof marker[category])
        return false;
    marker[category].forEach(function(marker) {
        marker.setMap(mapObject);
        marker.setAnimation(google.maps.Animation.DROP);

    });
};

function hideInfoBox() {
    $('div.infoBox').remove();
};

function showInfoBox(date) {
    return new InfoBox({
        content: '<div class="marker-detail">' +
            '<img src="' + date.map_image_url + '" alt="Image"/>' +
            '<div class="detail-part">' +
            '<h6>' + date.name_point + '</h6>' +
            '<div class="rating ' + date.rating + '">' +
            '<i class="far fa-star"></i>' +
            '<i class="far fa-star"></i>' +
            '<i class="far fa-star"></i>' +
            '<i class="far fa-star"></i>' +
            '<i class="far fa-star"></i>' +
            '</div>' +
            '<span>' + date.price + ' /per two</span>' +
            '<a href="' + date.url_point + '">Details</a>' +
            '</div>' +
            '</div>',
        disableAutoPan: false,
        maxWidth: 0,
        pixelOffset: new google.maps.Size(10, 125),
        closeBoxMargin: '5px -20px 2px 2px',
        closeBoxURL: "../assets/images/icon/cancel.png",
        isHidden: false,
        alignBottom: true,
        pane: 'floatPane',
        enableEventPropagation: true
    });
};

function onContentClick(location_type, key) {
    google.maps.event.trigger(marker[location_type][key], "click");
}
setTimeout(function() {
    $(".gm-style img").each(function() {
        if (this.src.indexOf("food-marker.png") !== -1) {
            $(this).addClass("d-none");
        }
    });
}, 5000);