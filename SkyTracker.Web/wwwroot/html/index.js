function initMap() {

    const map = new google.maps.Map(document.getElementById("map"), {
        center: { lat: 23.825716288660082, lng: -89.12079528143671 },
        zoom: 3,
        mapId: "e7851d2154fc3e57"
    });

    // Set LatLng and title text for the markers. The first marker (Gulf of Mexico)
    // receives the initial focus when tab is pressed. Use arrow keys to
    // move between markers; press tab again to cycle through the map controls.
    const tourStops = [
        [{ lat: 61.17722677876709, lng: -149.99065401560944 }, "ANC/PANC"],
        [{ lat: 41.16953985239386, lng: -71.58052399948453 }, "BID/KBID"],
        [{ lat: 42.93991008181565, lng: -78.72959253365957 }, "BUF/KBUF"],
        [{ lat: 60.56511015321005, lng: -151.2467758309837 }, "ENA/PAEN"],
        [{ lat: 35.860619136430515, lng: -83.53895041673171 }, "GKT/KGKT"],
        [{ lat: 43.10108184541733, lng: -78.94098824714688 }, "IAG/KIAG"],
        [{ lat: 17.644854961462727, lng: -63.22072830368736 }, "SAB/TNCS"],
        [{ lat: 17.904442214376015, lng: -62.84499925950639 }, "SBH/TFFJ"],
        [{ lat: 18.044477115469203, lng: -63.113348444162554 }, "SXM/TNCM"],
        [{ lat: 41.349309415701384, lng: -71.80439788954519 }, "WST/KWST"],
        [{ lat: 43.18947540625031, lng: -79.17109808947245 }, "YCM/CYSN"],
        [{ lat: 43.172967809253116, lng: -79.93176906063778 }, "YHM/CYHM"],
        [{ lat: 43.455977185677234, lng: -80.3857616722722 }, "YKF/CYKF"],
    ];
    // Create an info window to share between markers.
    const infoWindow = new google.maps.InfoWindow();

    // Create the markers.
    tourStops.forEach(([position, title], i) => {
        const marker = new google.maps.Marker({
            position,
            map,
            title: `${i + 1}. ${title}`,
            label: `${i + 1}`,
            optimized: false,
        });
       
        // Add a click listener for each marker, and set up the info window.
        marker.addListener("click", () => {
            infoWindow.close();
            infoWindow.setContent(marker.getTitle());
            infoWindow.open(marker.getMap(), marker);
        });
    });
}

window.addEventListener("load", initMap);