// Get all elements with class "track-title"
const trackName = document.querySelectorAll(".track-name");
const trackArtist = document.querySelectorAll(".track-artist");

// Loop through each element and replace "&amp;" with "&"
trackName.forEach((title) => {
    title.innerHTML = title.innerHTML.replace(/&amp;/g, "&");
});
trackArtist.forEach((title) => {
    title.innerHTML = title.innerHTML.replace(/&amp;/g, "&");
});


const musicName = document.querySelectorAll(".music-title");
const musicArtist = document.querySelectorAll(".music-artist");

// Loop through each element and replace "&amp;" with "&"
musicName.forEach((title) => {
    title.innerHTML = title.innerHTML.replace(/&amp;/g, "&");
});
musicArtist.forEach((title) => {
    title.innerHTML = title.innerHTML.replace(/&amp;/g, "&");
});
