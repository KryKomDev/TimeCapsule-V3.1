function check(id) {
    const element = document.getElementById(id);
    
    if (element.value === "Landsdorfův Pahorek") {
        window.location.replace("Rozcestnik");
    }
}