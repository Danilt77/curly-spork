let hours = document.querySelector('.hours .value').textContent;
let minutes = document.querySelector('.minutes .value').textContent;
let seconds = document.querySelector('.seconds .value').textContent;

let ms = hours * 3600000 + minutes * 60000 + seconds * 1000

setTimeout(changeTime, 1000);

function changeTime() {
    ms -= 1000;
    hours = Math.floor(ms/3600000);
    minutes = Math.floor((ms%3600000)/60000);
    seconds = Math.floor((ms%60000)/1000);
    document.querySelector('.hours .value').textContent = ('0' + hours).slice(-2);
    document.querySelector('.minutes .value').textContent = ('0' + minutes).slice(-2);
    document.querySelector('.seconds .value').textContent = ('0' + seconds).slice(-2);
    setTimeout(changeTime, 1000);
}