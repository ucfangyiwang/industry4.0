// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.\
function removeInfo(id) {
    if (document.getElementById(id) != null)
        document.getElementById(id).style.visibility = "hidden";
}

function displayInfo(id) {
    if (document.getElementById(id) != null)
        document.getElementById(id).style.visibility = "visible";
}


