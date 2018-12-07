var map; function initMap()
{
    map = new google.maps.Map(document.getElementById('map'), {
        center: { lat: 33.6615191, lng: 73.08679759999995 },
        zoom: 15
    });

    var marker = new google.maps.Marker({
        position: { lat: 33.6615191, lng: 73.08679759999995 },
        map: map
    });

    var marker1 = new google.maps.Marker({
        position: { lat: 33.6750857, lng: 73.06358550000004 },
        map: map
    });

    var marker2 = new google.maps.Marker({
        position: { lat: 33.664435, lng: 73.05228779999993 },
        map: map
    });

    var marker3 = new google.maps.Marker({
        position: { lat: 31.4755864, lng: 74.34215960000006 },
        map: map
    });

    var marker4 = new google.maps.Marker({
        position: { lat: 33.5505196, lng: 73.12610910000001 },
        map: map
    });
}

