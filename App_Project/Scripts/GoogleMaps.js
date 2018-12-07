var map; function initMap() {
    map = new google.maps.Map(document.getElementById('map'), {
        center: { lat: 33.6615191, lng: 73.08679759999995 },
        zoom: 15
    });

    var marker = new google.maps.Marker({
        position: { lat: 33.6615191, lng: 73.08679759999995 },
        map: map
    });
}



